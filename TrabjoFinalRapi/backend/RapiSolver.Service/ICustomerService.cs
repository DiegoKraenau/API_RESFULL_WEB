using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service
{
    public interface ICustomerService: IService<Customer>
    {
         IEnumerable<CustomerViewModel> GetAllCustomers();

         IEnumerable<CustomerViewModel> GetCustomerByUserId(int id);

         bool ValidarSubscripcion(int id);
    }
}