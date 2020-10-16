using SharedTrip.Data;
using SharedTrip.Models;
using SharedTrip.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SharedTrip.Services
{
    public class TripService : ITripService
    {
        private readonly ApplicationDbContext db;

        public TripService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(AddTripInputViewModel viewModel, string userId)
        {
            var trip = new Trip
            {
                StartPoint = viewModel.StartPoint,
                EndPoint = viewModel.EndPoint,
                ImagePath = viewModel.ImagePath,
                Description = viewModel.Description,
                DepartureTime = DateTime.Parse(viewModel.DepartureTime),
                Seats = viewModel.Seats,
            };

            this.db.UserTrips.Add(new UserTrip
            {
                Trip = trip,
                UserId = userId
            });

            this.db.SaveChanges();
        }

        public void AddUserToTrip(string tripId, string userId)
        {
            if (this.db.UserTrips.Any(u => u.TripId == tripId && u.UserId == userId))
            {
                return;
            }

            this.db.UserTrips.Add(new UserTrip
            {
                TripId = tripId,
                UserId = userId,
            });

            this.db.SaveChanges();
        }

        public List<AllTripViewModel> All()
        {
            return this.db.Trips.Select(t => new AllTripViewModel
            {
                Id = t.Id,
                StartPoint = t.StartPoint,
                EndPoint = t.EndPoint,
                Seats = t.Seats,
                DepartureTime = t.DepartureTime.ToString("dd.MM.yyyy HH:mm")
            }).ToList();
        }

        public AllTripViewModel Details(string tripId)
        {
            var trip = this.db.Trips
                .Where(t => t.Id == tripId)
                .Select(t => new AllTripViewModel
                {
                    Id = t.Id,
                    StartPoint = t.StartPoint,
                    EndPoint = t.EndPoint,
                    DepartureTime = t.DepartureTime.ToString("dd.MM.yyy HH:mm"),
                    Seats = t.Seats,
                    Description = t.Description,
                    Image = t.ImagePath
                }).FirstOrDefault();

            return trip;
        }
    }
}
