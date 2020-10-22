using SharedTrip.Services;
using SharedTrip.ViewModels.Trips;
using SUS.HTTP;
using SUS.MvcFramework;

namespace SharedTrip.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripsService tripsService;

        public TripsController(ITripsService tripsService)
        {
            this.tripsService = tripsService;
        }

        public HttpResponse All()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var trips = this.tripsService.All();
            return this.View(trips);
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
        public HttpResponse Add(AddTripViewModel input)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (string.IsNullOrEmpty(input.StartPoint))
            {
                return this.Error("Invalid start point.");
            }

            if (string.IsNullOrEmpty(input.EndPoint))
            {
                return this.Error("Invalid end point.");
            }

            if (input.Seats < 2 || input.Seats > 6)
            {
                return this.Error("Invalid count seats.");
            }

            if (string.IsNullOrEmpty(input.Description) || input.Description.Length > 80)
            {
                return this.Error("Invalid description");
            }

            this.tripsService.Add(input);
            return this.Redirect("/Trips/All");
        }

        public HttpResponse Details(string tripId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var trip = this.tripsService.GetTripById(tripId);
            return this.View(trip);
        }

        public HttpResponse AddUserToTrip(string tripId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var userId = this.GetUserId();

            var isAddSuccessfully = this.tripsService.AddUserToTrip(userId, tripId);

            if (!isAddSuccessfully)
            {
                return this.Redirect("/Trips/Details?tripid=" + tripId);
            }

            return this.Redirect("/Trips/All");
        }
    }
}
