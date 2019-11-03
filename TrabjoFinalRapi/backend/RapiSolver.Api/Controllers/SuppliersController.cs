using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]

    public class SuppliersController: ControllerBase
    {
        private ISupplierService supplierService;

         private IServicioService servicioService;

        public SuppliersController(ISupplierService supplierService,IServicioService servicioService)
        {
            this.supplierService = supplierService;
            this.servicioService = servicioService;
        }

       

        
        
         /// <summary>
        /// It allows  to obtain all the suppliers that were added
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                supplierService.GetAllSuppliers()
            );
        }

        /// <summary>
        /// It allows to add a supplier
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Supplier supplier)
        {
            return Ok(
                supplierService.Save(supplier)
            );
        }

        /// <summary>
        /// It allows to search a supplier by their corresponding Id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok(
                supplierService.Get(id)
            );
        }


        /// <summary>
        /// It allows to obtain all the services related to a supplier
        /// </summary>
        /// <returns></returns>
        [Route("{id}/servicios")]
        [HttpGet]
        public ActionResult Get2(int id)
        {
            return Ok(
                servicioService.GetServiciosByIdSupplier(id)
            );
        }
        
    }
}