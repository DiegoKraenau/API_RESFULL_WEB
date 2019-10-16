using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;
using RapiSolver.Repository.context;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository.implementation
{
    public class CustomerRepository : ICustomerRepository
    {

        private ApplicationDbContext context;

        public CustomerRepository (ApplicationDbContext context) {
            this.context = context;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Customer Get(int id)
        {
            var result = new Customer();
            try
            {
                result = context.customers.Find(id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<CustomerViewModel> GetAllCustomers()
        {
            var customers = context.customers
                .Include (o => o.Usuario)
                .Include(o=>o.Location)
                .OrderByDescending (o => o.CustomerId)
                .Take (10)
                .ToList ();

            return customers.Select (o => new CustomerViewModel {
                    CustomerId = o.CustomerId,
                    Name = o.Name,
                    LastName = o.LastName,
                    Email = o.Email,
                    Phone=o.Phone,
                    Age=o.Age,
                    Genger=o.Genger,
                    UsuarioId=o.UsuarioId,
                    LocationId=o.LocationId,
                    UserName=o.Usuario.UserName,
                    Country=o.Location.Country
             });
        }

        public bool Save(Customer entity)
        {
             try
            {
                entity.Location=context.locations.Find(entity.LocationId);
                entity.Usuario=context.usuarios.Find(entity.UsuarioId);
                
                context.Add(entity);
                context.SaveChanges();
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}