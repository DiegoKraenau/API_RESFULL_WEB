using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface IRecommendationService: IService<Recommendation>
    {
          IEnumerable<RecommendationViewModel> GetRecommendationsBySupplierId(int id);
    }
}