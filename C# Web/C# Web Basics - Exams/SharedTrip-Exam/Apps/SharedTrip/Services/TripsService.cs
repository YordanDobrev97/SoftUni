using SharedTrip.Data;
using SharedTrip.ViewModels.Trips;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SharedTrip.Services
{
    public class TripsService : ITripsService
    {
        private readonly ApplicationDbContext db;

        public TripsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(AddTripViewModel tripViewModel)
        {
            this.db.Trips.Add(new Trip
            {
                StartPoint = tripViewModel.StartPoint,
                EndPoint = tripViewModel.EndPoint,
                ImagePath = tripViewModel.ImagePath,
                Description = tripViewModel.Description,
                Seats = tripViewModel.Seats,
                DepartureTime = DateTime.ParseExact(tripViewModel.DepartureTime, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None)
            });

            this.db.SaveChanges();
        }

        public bool AddUserToTrip(string userId, string tripId)
        {
            if (this.db.UserTrips.Any(e => e.UserId == userId && e.TripId == tripId))
            {
                return false;
            }

            int freeSeats = this.db.Trips.Where(e => e.Id == tripId)
                 .Select(e => e.Seats - e.UserTrips.Count)
                 .FirstOrDefault();

            if (freeSeats == 0)
            {
                return false;
            }

            this.db.UserTrips.Add(new UserTrip
            {
                UserId = userId,
                TripId = tripId
            });

            this.db.SaveChanges();
            return true;
        }

        public List<AllTripsViewModel> All()
        {
            return this.db.Trips.Select(e => new AllTripsViewModel
            {
                Id = e.Id,
                StartPoint = e.StartPoint,
                EndPoint = e.EndPoint,
                DepartureTime = e.DepartureTime.ToString("s"),
                Seats = e.Seats - e.UserTrips.Count
            }).ToList();
        }

        public DetailsTripViewModel GetTripById(string tripId)
        {
            var trip = this.db.Trips.Where(t => t.Id == tripId)
                .Select(e => new DetailsTripViewModel
                {
                    Id = e.Id,
                    ImagePath = e.ImagePath,
                    StartPoint = e.StartPoint,
                    EndPoint = e.EndPoint,
                    DepartureTime = e.DepartureTime.ToString("s"),
                    Seats = e.Seats - e.UserTrips.Count,
                    Description = e.Description
                }).FirstOrDefault();



            return trip;
        }
    }
}
