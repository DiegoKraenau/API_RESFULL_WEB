using System.Collections.Generic;

namespace RapiSolver.Entity
{
    public class Usuario
    {
        
        public int UsuarioId{get;set;}

       
        public string UserName{get;set;}

        
        public string UserPassword{get;set;}

        public List<Rol> Roles{get;set;}
    }
}