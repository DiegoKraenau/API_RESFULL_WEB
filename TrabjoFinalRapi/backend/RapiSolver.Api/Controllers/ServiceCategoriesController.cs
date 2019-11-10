using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{

    [Route("api/servicecategories")]
    [ApiController]
    public class ServiceCategoriesController: ControllerBase
    {

        private IServiceCategoryService serviceCategoryService;

        public ServiceCategoriesController(IServiceCategoryService serviceCategoryService)
        {
            this.serviceCategoryService = serviceCategoryService;
        }

        /// <summary>
        /// It allows to obtain all the  categories that were added
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(
                serviceCategoryService.GetAll()
            );
        }

        /// <summary>
        /// It allows to add a category to a servicie
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] ServiceCategory serviceCategory)
        {
            return Ok(
                serviceCategoryService.Save(serviceCategory)
            );
        }


         /// <summary>
        /// It allows to search for a category  by their corresponding Id
        /// </summary>
        /// <returns></returns>       
        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                serviceCategoryService.Get(id)
            );
        }
        
    }
}