using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicioController: ControllerBase
    {
       private IServicioService servicioService;

        public ServicioController(IServicioService servicioService)
        {
            this.servicioService = servicioService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                servicioService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Servicio servicio)
        {
            return Ok(
                servicioService.Save(servicio)
            );
        }
        
    }
}