using MXGP.Core.Contracts;
using MXGP.Models.Motorcycles;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Races;
using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories;
using System;
using System.Linq;
using System.Text;

namespace MXGP.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private RiderRepository riderRepository;
        private MotorcycleRepository motorcycleRepository;
        private RaceRepository raceRepository;

        public ChampionshipController()
        {
            this.riderRepository = new RiderRepository();
            this.motorcycleRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            var rider = this.riderRepository.GetByName(riderName);
            var motocycle = this.motorcycleRepository.GetByName(motorcycleModel);

            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            if (motocycle == null)
            {
                throw new InvalidOperationException($"Motorcycle {motorcycleModel} could not be found.");
            }

            rider.AddMotorcycle(motocycle);
            return $"Rider {riderName} received motorcycle {motorcycleModel}.";
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            var race = this.raceRepository.GetByName(raceName);
            var rider = this.riderRepository.GetByName(riderName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if (rider == null)
            {
                throw new InvalidOperationException("Rider {name} could not be found.");
            }

            race.AddRider(rider);
            return $"Rider {riderName} added in {raceName} race.";
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            IMotorcycle motorcycle = null;
            if (type == "Speed")
            {
                motorcycle = new SpeedMotorcycle(model, horsePower);
            }
            else if (type == "Power")
            {
                motorcycle = new PowerMotorcycle(model, horsePower);
            }

            if (this.motorcycleRepository.GetAll().Any(x => x.Model == model))
            {
                throw new ArgumentException($"Motorcycle {model} is already created.");
            }

            this.motorcycleRepository.Add(motorcycle);
            return $"{type} {model} is created.";
        }

        public string CreateRace(string name, int laps)
        {
            var raceRepo = raceRepository.GetByName(name);

            if (raceRepo != null)
            {
                throw new InvalidOperationException($"Race {name} is already created.");
            }

            IRace race = new Race(name);
            this.raceRepository.Add(race);

            return $"Race {name} is created.";

        }

        public string CreateRider(string riderName)
        {
            IRider rider = new Rider(riderName);

            if (this.riderRepository.GetAll().Any(x => x.Name == riderName))
            {
                throw new ArgumentException($"Rider {riderName} is already created.");
            }

            this.riderRepository.Add(rider);

            return $"Rider {riderName} is created.";
        }

        public string StartRace(string raceName)
        {
            var race = this.raceRepository.GetByName(raceName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if (raceRepository.ListModels.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            StringBuilder sb = new StringBuilder();
            var riders = riderRepository.ListModels.
                OrderByDescending(x => x.Motorcycle.CalculateRacePoints(race.Laps)).Take(3).
                ToList();
            var races = raceRepository.ListModels.Take(3).ToList();
            this.raceRepository.Remove(race);

            sb.AppendLine($"Rider {riders[0]} wins {races[0]} race.");
            sb.AppendLine($"Rider {riders[1]} is second in {races[1]} race.");
            sb.AppendLine($"Rider {riders[2]} is third in {races[2]} race.");

            return sb.ToString();
        }
    }
}
