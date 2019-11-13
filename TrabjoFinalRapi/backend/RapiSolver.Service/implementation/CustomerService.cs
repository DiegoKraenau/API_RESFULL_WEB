using System.Collections.Generic;
using RapiSolver.Entity;
using RapiSolver.Repository;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Service.implementation
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository=customerRepository;
        }


        public bool Delete(int id)
        {
            return customerRepository.Delete(id);
        }

        public Customer Get(int id)
        {
            return customerRepository.Get(id);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customerRepository.GetAll();
        }

        public IEnumerable<CustomerViewModel> GetAllCustomers()
        {
            return customerRepository.GetAllCustomers();
        }

        public IEnumerable<CustomerViewModel> GetCustomerByUserId(int id)
        {
             return customerRepository.GetCustomerByUserId(id);
        }

        public bool Save(Customer entity)
        {
            return customerRepository.Save(entity);
        }

        public bool Update(Customer entity)
        {
            return customerRepository.Update(entity);
        }

        public bool ValidarSubscripcion(int id)
        {
            return customerRepository.ValidarSubscripcion(id);
        }
    }
}