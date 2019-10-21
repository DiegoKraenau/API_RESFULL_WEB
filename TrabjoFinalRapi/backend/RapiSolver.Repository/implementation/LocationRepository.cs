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
            throw new System.NotImplementedException();
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
            try{
                    var locationOrigina = context.locations.Single(x => x.LocationId == entity.LocationId);

                    locationOrigina.LocationId = entity.LocationId;
                    locationOrigina.Country = entity.Country;
                    locationOrigina.City = entity.City;
                    locationOrigina.State = entity.State;
                    locationOrigina.Address = entity.Address;


                    context.Update(locationOrigina);
                    context.SaveChanges();

                }
                catch(System.Exception)
                {
                    return false;
                }
                return true;
        
        }
    }
}