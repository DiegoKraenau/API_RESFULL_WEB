using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository
{
    public interface IReservationRepository: IRepository<Reservation>
    {
         IEnumerable<ReservationViewModel> GetAllReservationsByUserId(int id);
    }
}