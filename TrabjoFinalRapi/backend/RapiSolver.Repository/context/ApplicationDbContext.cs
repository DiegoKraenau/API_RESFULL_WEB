using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;

namespace RapiSolver.Repository.context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Cliente> clientes{get;set;}

        public DbSet<Rol> roles{get;set;}

        public DbSet<Usuario> usuarios{get;set;}

         public DbSet<Customer> customers{get;set;}

        public DbSet<Supplier> suppliers{get;set;}
        public DbSet<ServiceCategory> categories{get;set;}

        public DbSet<Servicio> servicios{get;set;}

        public DbSet<ServiceDetails> serviceDetails{get;set;}
        

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {


        modelBuilder.Entity<Usuario>().HasMany(x=>x.Roles).WithOne(o=>o.Usuario);

       

        modelBuilder.Entity<Supplier>().HasOne(x=>x.Usuario);

        modelBuilder.Entity<Customer>().HasOne(x=>x.Usuario);

        modelBuilder.Entity<Customer>().HasOne(x=>x.Location);

        modelBuilder.Entity<Supplier>().HasOne(x=>x.Location);

         
        modelBuilder.Entity<ServiceCategory>().HasMany(x=>x.Servicios).WithOne(o=>o.ServiceCategory);

       
    
        }

    }
}