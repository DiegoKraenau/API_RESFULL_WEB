using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class LocationController: ControllerBase
    {
        private ILocationService locationService;

        public LocationController(ILocationService locationService)
        {
            this.locationService = locationService;
        }

         [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                locationService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Location location)
        {
            return Ok(
                locationService.Save(location)
            );
        }

       
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                locationService.Get(id)
            );
        }
        
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                locationService.Delete(id)
            );
        }

    }
}