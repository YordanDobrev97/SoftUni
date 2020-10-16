using SharedTrip.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SharedTrip.Services
{
    public interface ITripService
    {
        List<AllTripViewModel> All();

        void Add(AddTripInputViewModel viewModel, string userId);

        AllTripViewModel Details(string tripId);

        void AddUserToTrip(string tripId, string userId);
    }
}
