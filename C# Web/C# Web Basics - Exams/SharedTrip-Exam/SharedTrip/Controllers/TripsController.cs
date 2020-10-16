using SharedTrip.Services;
using SharedTrip.ViewModels;
using SUS.HTTP;
using SUS.MvcFramework;
using System;
using System.Globalization;

namespace SharedTrip.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripService tripService;

        public TripsController(ITripService tripService)
        {
            this.tripService = tripService;
        }

        [HttpGet("/Trips/All")]
        public HttpResponse All()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var all = this.tripService.All();
            return this.View(all);
        }

        public HttpResponse Add()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(AddTripInputViewModel inputViewModel)
        {
            if (string.IsNullOrWhiteSpace(inputViewModel.StartPoint))
            {
                return this.Error("Invalid start point.");
            }

            if (string.IsNullOrWhiteSpace(inputViewModel.EndPoint))
            {
                return this.Error("Invalid end point.");
            }

            DateTime.TryParseExact(inputViewModel.DepartureTime,
                "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime date);

            if (date == null)
            {
                return this.Error("Invalid Departure Time.");
            }

            if (inputViewModel.Seats < 2 || inputViewModel.Seats > 6)
            {
                return this.Error("Invalid Seats count.");
            }

            if (inputViewModel.Description.Length > 80)
            {
                return this.Error("Invalid Description length.");
            }

            var userId = this.GetUserId();
            this.tripService.Add(inputViewModel, userId);
            return this.Redirect("/Trips/All");
        }

        public HttpResponse Details(string tripId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var trip = this.tripService.Details(tripId);
            return this.View(trip);
        }

        public HttpResponse AddUserToTrip(string tripId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var userId = this.GetUserId();
            this.tripService.AddUserToTrip(tripId, userId);
            return this.Redirect("/");
        }
    }
}
