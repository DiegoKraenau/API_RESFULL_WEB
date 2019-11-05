using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;
using RapiSolver.Repository.context;
using RapiSolver.Repository.ViewModel;

namespace RapiSolver.Repository.implementation
{
    public class SupplierRepository : ISupplierRepository
    {
        
        private ApplicationDbContext context;

        public SupplierRepository (ApplicationDbContext context) {
            this.context = context;
        }


        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Supplier Get(int id)
        {
           var result = new Supplier();
            try
            {
                result = context.suppliers.Find(id);
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Supplier> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SupplierViewModel> GetAllSupplierBySurname(string apellido)
        {
            var suppliers = context.suppliers
                .Include (o => o.Usuario)
                .Include(o=>o.Location)
                .OrderByDescending (o => o.SupplierId)
                .Where(o=>o.LastName==apellido)
                .ToList ();

            return suppliers.Select (o => new SupplierViewModel {
                    SupplierId = o.SupplierId,
                    Name = o.Name,
                    LastName = o.LastName,
                    Email = o.Email,
                    Phone=o.Phone,
                    Age=o.Age,
                    Genger=o.Genger,
                    UsuarioId=o.UsuarioId,
                    LocationId=o.LocationId,
                    UserName=o.Usuario.UserName,
                    Country=o.Location.Country,
                //    ServiciosDetails=context.serviceDetails.ToList() No se puede pasar listas al json
             });
        }

        public IEnumerable<SupplierViewModel> GetAllSuppliers()
        {
           var suppliers = context.suppliers
                .Include (o => o.Usuario)
                .Include(o=>o.Location)
                .OrderByDescending (o => o.SupplierId)
                .Take (10)
                .ToList ();

            return suppliers.Select (o => new SupplierViewModel {
                    SupplierId = o.SupplierId,
                    Name = o.Name,
                    LastName = o.LastName,
                    Email = o.Email,
                    Phone=o.Phone,
                    Age=o.Age,
                    Genger=o.Genger,
                    UsuarioId=o.UsuarioId,
                    LocationId=o.LocationId,
                    UserName=o.Usuario.UserName,
                    Country=o.Location.Country,
                //    ServiciosDetails=context.serviceDetails.ToList() No se puede pasar listas al json
             });
        }

        public  IEnumerable<SupplierViewModel> GetSupplierByUserId(int id)
        {
            var suppliers = context.suppliers
                .Include (o => o.Usuario)
                .Include(o=>o.Location)
                .OrderByDescending (o => o.SupplierId)
                .Where(o=>o.UsuarioId==id)
                .ToList ();

            return suppliers.Select (o => new SupplierViewModel {
                    SupplierId = o.SupplierId,
                    Name = o.Name,
                    LastName = o.LastName,
                    Email = o.Email,
                    Phone=o.Phone,
                    Age=o.Age,
                    Genger=o.Genger,
                    UsuarioId=o.UsuarioId,
                    LocationId=o.LocationId,
                    UserName=o.Usuario.UserName,
                    Country=o.Location.Country,
                //    ServiciosDetails=context.serviceDetails.ToList() No se puede pasar listas al json
             });
        }

        public Supplier GetSupplierOriginialByUserId(int id)
        {
            var result = new Supplier();
            try
            {
                result = context.suppliers.Where(x=>x.UsuarioId==id).First();
            }

            catch (System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Supplier entity)
        {
             try
            {
               Usuario u1=new Usuario();
                u1.UserName=entity.Email;
                u1.UserPassword=entity.Contraseña;
                u1.RolId=2;
                u1.Rol=context.roles.Find(u1.RolId);

                context.Add(u1);
                context.SaveChanges();

                entity.UsuarioId=context.usuarios.Single(x=>x.UserName==entity.Email).UsuarioId;

                Location l1=new Location();
                l1.Country=entity.Country;
                l1.City=entity.City;
                l1.State=entity.State;
                l1.Address=entity.Address;

                context.Add(l1);
                context.SaveChanges();
        
                entity.Location=l1;
                entity.LocationId=1;
               
                entity.Usuario=context.usuarios.Find(entity.UsuarioId);
                
                context.Add(entity);
                context.SaveChanges();
              //  entity.ServiciosDetails=context.serviceDetails.Where(y=>y.SupplierId==entity.SupplierId).ToList();
                
              
            }
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Supplier entity)
        {
            throw new System.NotImplementedException();
        }
    }
}