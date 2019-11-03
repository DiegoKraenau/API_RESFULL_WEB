using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository
{
    public interface IRecommendationRepository: IRepository<Recommendation>
    {
         IEnumerable<RecommendationViewModel> GetRecommendationsBySupplierId(int id);
    }
}