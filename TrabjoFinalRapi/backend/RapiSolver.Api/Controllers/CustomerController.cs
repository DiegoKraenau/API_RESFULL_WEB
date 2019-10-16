using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class CustomerController: ControllerBase
    {

        private ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                customerService.GetAllCustomers()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {
            return Ok(
                customerService.Save(customer)
            );
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                customerService.Get(id)
            );
        }

        
    }
}