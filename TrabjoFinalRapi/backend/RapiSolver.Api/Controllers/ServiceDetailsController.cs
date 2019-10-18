using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceDetailsController: ControllerBase
    {
        private IServiceDetailsService serviceDetailsService;

        public ServiceDetailsController(IServiceDetailsService serviceDetailsService)
        {
            this.serviceDetailsService = serviceDetailsService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                serviceDetailsService.GetAllDetails()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] ServiceDetails serviceDetails)
        {
            return Ok(
                serviceDetailsService.Save(serviceDetails)
            );
        }

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                serviceDetailsService.GetServicioById(id)
            );
        }


          /* 

        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                serviceDetailsService.Get(id)
            );
        }
        */
    }
}