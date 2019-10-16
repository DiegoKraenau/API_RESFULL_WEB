using System.Collections.Generic;
using System.Linq;
using RapiSolver.Entity;
using RapiSolver.Repository.context;

namespace RapiSolver.Repository.implementation
{
    public class ServicioRepository : IServicioRepository
    {

        private ApplicationDbContext context;

        public ServicioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Servicio Get(int id)
        {
             var result = new Servicio();
            try
            {
                result = context.servicios.Single(x => x.ServicioId == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Servicio> GetAll()
        {
             var result = new List<Servicio>();
            try
            {
                result = context.servicios.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Servicio entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Servicio entity)
        {
            throw new System.NotImplementedException();
        }
    }
}