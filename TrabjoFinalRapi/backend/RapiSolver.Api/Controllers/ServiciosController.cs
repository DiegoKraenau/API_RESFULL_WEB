using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/[controller]")]
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

        /* 

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                servicioService.Get(id)
            );
        }
        */

        
        /// <summary>
        /// It allows to search a service by their corresponding name
        /// </summary>
        /// <returns></returns>
        [HttpGet("{name}")]
        public ActionResult Get([FromRoute] string name)
        {
            return Ok(
                servicioService.GetServiciosByCategory(name)
            );
        }

        


        
    }
}