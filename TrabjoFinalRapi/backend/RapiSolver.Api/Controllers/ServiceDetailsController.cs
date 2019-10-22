using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;
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

         /// <summary>
        /// It allows  to obtain all the service details from a supplier with a service
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                serviceDetailsService.GetAllDetails()
            );
        }

        /// <summary>
        /// It allows to add a service detail  between a supplier with a service
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] ServiceDetailsViewModel serviceDetails)
        {
            return Ok(
                serviceDetailsService.SaveServicio(serviceDetails)
            );
        }

        /// <summary>
        /// It allows to obtain a service detail between a supplier with a service by its corresponding Id
        /// </summary>
        /// <returns></returns>
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