using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController: ControllerBase
    {
       private IClienteService clienteService;

        public ClienteController(IClienteService clienteService)
        {
            this.clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                clienteService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Cliente cliente)
        {
            return Ok(
                clienteService.Save(cliente)
            );
        }

        //[HttpGet("{id}")]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(
                clienteService.Delete(id)
            );
        }


        
    }
}