using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface ICustomerService: IService<Customer>
    {
         IEnumerable<CustomerViewModel> GetAllCustomers();
    }
}