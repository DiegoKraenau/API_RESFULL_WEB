using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service.implementation
{
    public class SupplierService : ISupplierService
    {

        private ISupplierRepository supplierRepository;
        public SupplierService(ISupplierRepository supplierRepository)
        {
            this.supplierRepository=supplierRepository;
        }
        public bool Delete(int id)
        {
            return supplierRepository.Delete(id);
        }

        public Supplier Get(int id)
        {
            return supplierRepository.Get(id);
        }

        public IEnumerable<Supplier> GetAll()
        {
            return supplierRepository.GetAll();
        }

        public IEnumerable<SupplierViewModel> GetAllSuppliers()
        {
            return supplierRepository.GetAllSuppliers();
        }

        public bool Save(Supplier entity)
        {
            return supplierRepository.Save(entity);
        }

        public bool Update(Supplier entity)
        {
            return supplierRepository.Update(entity);
        }
    }
}