using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RolController: ControllerBase
    {
        private IRolService rolService;

        public RolController(IRolService rolService)
        {
            this.rolService = rolService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                rolService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Rol rol)
        {
            return Ok(
                rolService.Save(rol)
            );
        }

       
        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                rolService.Get(id)
            );
        }
        /* 
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                rolService.Delete(id)
            );
        }
        */
    }
}