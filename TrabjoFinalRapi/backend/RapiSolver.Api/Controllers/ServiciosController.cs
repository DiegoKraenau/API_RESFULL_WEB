using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/rapiservices")]
    [ApiController]
    public class ServiciosController: ControllerBase
    {
       private IServicioService servicioService;

        public ServiciosController(IServicioService servicioService)
        {
            this.servicioService = servicioService;
        }

        /// <summary>
        /// It allows  to obtain all the services that were added
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                servicioService.GetAllServicios()
            );
        }


        /// <summary>
        /// It allows to add a service
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Servicio servicio)
        {
            return Ok(
                servicioService.Save(servicio)
            );
        }


        
        /// <summary>
        /// It allows to search a service by their corresponding name
        /// </summary>
        /// <returns></returns>
        [HttpGet("searchByName/{name}")]
        public ActionResult Get([FromRoute] string name)
        {
            return Ok(
                servicioService.GetServiciosByCategory(name)
            );
        }

         /// <summary>
        /// It allows to obtain all the services  by their user Id
        /// </summary>
        /// <returns></returns>
        [Route("searchByUserId/{id}")]
        [HttpGet]
        public ActionResult Get2(int id)
        {
            return Ok(
                servicioService.GetServiciosByUserId(id)
            );
        }

        /// <summary>
        /// It allows to obtain a service by  his ID
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get3(int id)
        {
            return Ok(
                servicioService.Get(id)
            );
        }

         /// <summary>
        /// It allows to update a service 
        /// </summary>
        /// <returns></returns>
        [HttpPut()]
        public ActionResult Put([FromBody] ServicioViewModel servicioViewModel)
        {
            return Ok(
                servicioService.UpdateServicio(servicioViewModel)
            );
        }

        /// <summary>
        /// It allows to delete a service 
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                servicioService.Delete(id)
            );
        }


        
    }
}