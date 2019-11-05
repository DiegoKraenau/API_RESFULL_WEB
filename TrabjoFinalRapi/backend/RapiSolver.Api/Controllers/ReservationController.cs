using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController:ControllerBase
    {
        private IReservationService reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        /// <summary>
        /// It allows to reservations by user ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("searchByUserId/{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                reservationService.GetAllReservationsByUserId(id)
            );
        }

         /// <summary>
        /// It allows to delete a reservation by his ID
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                reservationService.Delete(id)
            );
        }


          /// <summary>
        /// It allows to add a reservation
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Reservation reservation)
        {
            return Ok(
                reservationService.Save(reservation)
            );
        }
    }
}