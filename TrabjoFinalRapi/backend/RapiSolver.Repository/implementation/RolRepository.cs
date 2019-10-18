using System.Collections.Generic;
using System.Linq;
using RapiSolver.Entity;
using RapiSolver.Repository.context;

namespace RapiSolver.Repository.implementation
{
    public class RolRepository : IRolRepository
    {
        private ApplicationDbContext context;

        public RolRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            /* 
            var result = new Rol();
            try
            {
                result = context.roles.Single(x => x.Id == id);
                context.roles.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
            */

            throw new System.NotImplementedException();
        }

        public Rol Get(int id)
        {
            var result = new Rol();
            try
            {
                result = context.roles.Single(x => x.RolId == id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Rol> GetAll()
        {
             var result = new List<Rol>();
            try
            {
                result = context.roles.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Rol entity)
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

        public bool Update(Rol entity)
        {
            throw new System.NotImplementedException();
        }
    }
}