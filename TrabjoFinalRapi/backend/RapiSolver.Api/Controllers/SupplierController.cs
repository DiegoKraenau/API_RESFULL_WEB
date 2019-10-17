using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class SupplierController: ControllerBase
    {
        private ISupplierService supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }
        
        
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                supplierService.GetAllSuppliers()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] Supplier supplier)
        {
            return Ok(
                supplierService.Save(supplier)
            );
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                supplierService.Get(id)
            );
        }
    }
}