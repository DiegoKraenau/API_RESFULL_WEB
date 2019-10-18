using System.Collections.Generic;
using System.Linq;
using RapiSolver.Entity;
using RapiSolver.Repository.context;

namespace RapiSolver.Repository.implementation
{
    public class ClienteRepository : IClienteRepository
    {

        private ApplicationDbContext context;

        public ClienteRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            var result = new Cliente();
            try
            {
                result = context.clientes.Single(x => x.Id == id);
                context.clientes.Remove(result);
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }
            return true;
        }

        public Cliente Get(int id)
        {
             var result = new Cliente();
            try
            {
                result = context.clientes.Single(x => x.Id == id);
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public IEnumerable<Cliente> GetAll()
        {
             var result = new List<Cliente>();
            try
            {
                result = context.clientes.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Cliente entity)
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

        public bool Update(Cliente entity)
        {
            throw new System.NotImplementedException();
        }
    }
}