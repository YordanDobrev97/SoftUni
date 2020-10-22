using SharedTrip.ViewModels.Trips;
using System.Collections.Generic;

namespace SharedTrip.Services
{
    public interface ITripsService
    {
        List<AllTripsViewModel> All();

        void Add(AddTripViewModel tripViewModel);

        DetailsTripViewModel GetTripById(string tripId);

        bool AddUserToTrip(string userId, string tripId);
    }
}
