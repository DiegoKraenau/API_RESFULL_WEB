using Microsoft.AspNetCore.Mvc;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;
using RapiSolver.Service;

namespace RapiSolver.Api.Controllers
{
    [Route("api/recommendations")]
    [ApiController]
    public class RecommendationController: ControllerBase
    {
        private IRecommendationService recommendationService;

        public RecommendationController(IRecommendationService recommendationService)
        {
            this.recommendationService = recommendationService;
        }

         /// <summary>
        /// It allows to add a recommendation  
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Post([FromBody] Recommendation recommendation)
        {
            return Ok(
                recommendationService.Save(recommendation)
            );
        }


         /// <summary>
        /// It allows  to obtain all the recommendations by supplierId
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public ActionResult Get([FromRoute] int id)
        {
            return Ok(
                recommendationService.GetRecommendationsBySupplierId(id)
            );
        }
        
    }
}