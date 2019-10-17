using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository
{
    public interface ICustomerRepository: IRepository<Customer>
    {
          IEnumerable<CustomerViewModel> GetAllCustomers();
    }
}