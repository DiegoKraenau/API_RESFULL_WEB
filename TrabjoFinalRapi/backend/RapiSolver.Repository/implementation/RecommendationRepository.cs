using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;
using RapiSolver.Repository.context;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository.implementation
{
    public class RecommendationRepository : IRecommendationRepository
    {

        private ApplicationDbContext context;

        public RecommendationRepository (ApplicationDbContext context) {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Recommendation Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Recommendation> GetAll()
        {
            var result = new List<Recommendation>();
            try{
                result = context.recommendations.ToList();

            }
            catch(System.Exception){
                throw;
            }
            return result;
        }

        public IEnumerable<RecommendationViewModel> GetRecommendationsBySupplierId(int id)
        {
             var recommendations = context.recommendations
                .Include (o => o.Supplier)
                .Include(o=>o.Usuario)
                .OrderByDescending (o => o.RecommendationId)
                .Where(o=>o.SupplierId==id)
                .ToList ();


              return recommendations.Select (o => new RecommendationViewModel {
                    RecommendationId = o.RecommendationId,
                    Note = o.Note,
                    SupplierId = o.SupplierId,
                    NameSupllier = o.Supplier.Name,
                    LastNameSupllier=o.Supplier.LastName,
                    EmailSupllier=o.Supplier.Email,
                    UsuarioId = o.UsuarioId,
                    UserName = o.Usuario.UserName,
                    Mark=o.Mark
             });
        }

        public bool Save(Recommendation entity)
        {
            try
            {
                Usuario c1=new Usuario();
                c1=context.usuarios.Find(entity.UsuarioId);
                Supplier s1=new Supplier();
                s1=context.suppliers.Find(entity.SupplierId);
                
                entity.Supplier=s1;
                entity.Usuario=c1;
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Recommendation entity)
        {
            throw new System.NotImplementedException();
        }
    }
}