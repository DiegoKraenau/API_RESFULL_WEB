using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;

namespace RapiSolver.Service.implementation
{
    public class LocationService : ILocationService
    {

        private ILocationRepository locationRepository;
        public LocationService(ILocationRepository locationRepository)
        {
            this.locationRepository=locationRepository;
        }
        public bool Delete(int id)
        {
            return locationRepository.Delete(id);
        }

        public Location Get(int id)
        {
            return locationRepository.Get(id);
        }

        public IEnumerable<Location> GetAll()
        {
            return locationRepository.GetAll();
        }

        public bool Save(Location entity)
        {
            return locationRepository.Save(entity);
        }

        public bool Update(Location entity)
        {
            return locationRepository.Update(entity);
        }
    }
}