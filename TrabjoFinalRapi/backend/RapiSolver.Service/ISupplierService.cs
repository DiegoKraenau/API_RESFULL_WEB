using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface ISupplierService: IService<Supplier>
    {
         IEnumerable<SupplierViewModel> GetAllSuppliers();

         IEnumerable<SupplierViewModel> GetAllSupplierBySurname(string apellido);

         IEnumerable<SupplierViewModel> GetSupplierByUserId(int id);

         Supplier GetSupplierOriginialByUserId(int id);
    }
}