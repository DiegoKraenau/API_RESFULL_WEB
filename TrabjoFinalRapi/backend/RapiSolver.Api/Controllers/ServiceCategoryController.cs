using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCategoryController: ControllerBase
    {

        private IServiceCategoryService serviceCategoryService;

        public ServiceCategoryController(IServiceCategoryService serviceCategoryService)
        {
            this.serviceCategoryService = serviceCategoryService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                serviceCategoryService.GetAll()
            );
        }

        [HttpPost]
        public ActionResult Post([FromBody] ServiceCategory serviceCategory)
        {
            return Ok(
                serviceCategoryService.Save(serviceCategory)
            );
        }

       
        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                serviceCategoryService.Get(id)
            );
        }
        
    }
}