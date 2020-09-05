using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        private DecorationRepository decorations;
        private List<IAquarium> aquariums;

        public Controller()
        {
            this.decorations = new DecorationRepository();
            this.aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            if (aquariumType != "FreshwaterAquarium" && aquariumType != "SaltwaterAquarium")
            {
                throw new InvalidOperationException("Invalid aquarium type.");
            }

            IAquarium aquarium = null;

            switch (aquariumType)
            {
                case "FreshwaterAquarium":
                    aquarium = new FreshwaterAquarium(aquariumName);
                    break;
                case "SaltwaterAquarium":
                    aquarium = new SaltwaterAquarium(aquariumName);
                    break;
            }

            if (aquarium.Comfort > aquarium.Capacity)
            {
                return "Not enough capacity";
            }

            this.aquariums.Add(aquarium);
            return $"Successfully added {aquariumType}.";
        }

        public string AddDecoration(string decorationType)
        {
            if (decorationType != "Ornament" && decorationType != "Plant")
            {
                throw new InvalidOperationException("Invalid decoration type.");
            }

            IDecoration decoration = null;

            switch (decorationType)
            {
                case "Ornament":
                    decoration = new Ornament();
                    break;
                case "Plant":
                    decoration = new Plant();
                    break;
            }

            this.decorations.Add(decoration);
            return $"Successfully added {decorationType}.";
        }

        public string AddFish(string aquariumName, string fishType, string fishName,
            string fishSpecies, decimal price)
        {
            if (fishType != "FreshwaterFish" && fishType != "SaltwaterFish")
            {
                throw new InvalidOperationException("Invalid fish type.");
            }

            var aquarium = this.aquariums
                .FirstOrDefault(x => x.Name == aquariumName);

            IFish fish = null;

            switch (fishType)
            {
                case "FreshwaterFish":
                    fish = new FreshwaterFish(fishName, fishSpecies, price);
                    break;
                case "SaltwaterFish":
                    fish = new SaltwaterFish(fishName, fishSpecies, price);
                    break;
            }

             //???
             var currentFishType = fish.GetType().Name;
             if (aquarium.Comfort <= 0 && fishType == "FreshwaterAquarium" && fish.GetType().Name != "FreshwaterAquarium")
             {
                 return "Water not suitable.";
             }

            if (aquarium.Comfort <= 0 && fishType == "SaltwaterAquarium" && fish.GetType().Name != "SaltwaterAquarium")
            {
                return "Water not suitable.";
            }

            aquarium.AddFish(fish);

            return $"Successfully added {fishType} to {aquariumName}.";
        }

        public string CalculateValue(string aquariumName)
        {
            decimal sumFish = 0;

            foreach (var item in this.aquariums)
            {
                if (item.Name == aquariumName)
                {
                    var aquariumPrice = item.Fish.Sum(x => x.Price);
                    var decorationPrice = item.Decorations.Sum(x => x.Price);
                    sumFish += aquariumPrice;
                    sumFish += decorationPrice;
                }
            }

            return $"The value of Aquarium {aquariumName} is {sumFish:f2}.";
        }

        public string FeedFish(string aquariumName)
        {
            int fedCount = 1;

            foreach (var aquarium in this.aquariums)
            {
                if (aquarium.Name == aquariumName)
                {
                    fedCount++;
                }
            }

            return $"Fish fed: {fedCount}";
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            //Ornament Plant
            if (decorationType != "Ornament" && decorationType != "Plant")
            {
                throw new InvalidOperationException($"There isn't a decoration of type {decorationType}.");
            }

            var aquarium = this.aquariums.FirstOrDefault(x => x.Name == aquariumName);

            IDecoration decoration = null;

            switch (decorationType)
            {
                case "Ornament":
                    decoration = new Ornament();
                    break;
                case "Plant":
                    decoration = new Plant();
                    break;
            }

            aquarium.AddDecoration(decoration);
            this.decorations.Remove(decoration);

            return $"Successfully added {decorationType} to {aquariumName}.";
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var aquarium in this.aquariums)
            {
                sb.AppendLine($"{aquarium} ({aquarium.GetType().Name}):");

                sb.AppendLine($"Fish: {string.Join(", ", aquarium.Fish)}");
                sb.AppendLine($"Decorations: {aquarium.Decorations.Count}");
                sb.AppendLine($"Comfort: {aquarium.Comfort}");

                sb.AppendLine(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
