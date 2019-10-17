using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository
{
    public interface ISupplierRepository: IRepository<Supplier>
    {
         IEnumerable<SupplierViewModel> GetAllSuppliers();
    }
}