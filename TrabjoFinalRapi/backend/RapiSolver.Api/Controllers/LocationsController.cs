using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class LocationsController: ControllerBase
    {
        private ILocationService locationService;

        public LocationsController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

        /// <summary>
        /// It allows to obtain all the locations
        /// </summary>
        /// <returns></returns>
         [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                locationService.GetAll()
            );
        }

        /// <summary>
        /// It allows to add a location
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Location location)
        {
            return Ok(
                locationService.Save(location)
            );
        }

        /// <summary>
        /// It allows  to search for a location by their corresponding Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                locationService.Get(id)
            );
        }
        
    }
}