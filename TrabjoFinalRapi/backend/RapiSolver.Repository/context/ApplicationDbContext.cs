using Microsoft.EntityFrameworkCore;
using RapiSolver.Entity;

namespace RapiSolver.Repository.context
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Cliente> clientes{get;set;}


        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }

    }
}