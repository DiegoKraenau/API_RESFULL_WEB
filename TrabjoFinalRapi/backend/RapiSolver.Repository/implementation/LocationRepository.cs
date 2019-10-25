using System.Collections.Generic;
using System.Linq;
using RapiSolver.Entity;
using RapiSolver.Repository.context;

namespace RapiSolver.Repository.implementation
{
    public class LocationRepository : ILocationRepository
    {
        private ApplicationDbContext context;

        public LocationRepository (ApplicationDbContext context) {
            this.context = context;
        }       

        public bool Delete(int id)
        {
            var objEli = new Location();
            try {

                objEli = context.locations.Single(x=> x.LocationId == id);
                context.locations.Remove(objEli);
                context.SaveChanges();

            }
            catch(System.Exception){
                return false;
            }
            return true;
        }
      
        public Location Get(int id)
        {
            var result = new Location();
            try
            {
                result = context.locations.Single(x => x.LocationId == id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Location> GetAll()
        {
             var result = new List<Location>();
            try
            {
                result = context.locations.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Location entity)
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

        public bool Update(Location entity)
        {
            throw new System.NotImplementedException();
        }
    }
}