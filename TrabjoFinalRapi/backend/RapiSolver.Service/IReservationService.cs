using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface IReservationService: IService<Reservation>
    {
          IEnumerable<ReservationViewModel> GetAllReservationsByUserId(int id);
    }
}