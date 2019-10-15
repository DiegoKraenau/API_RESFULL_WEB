namespace RapiSolver.Entity
{
    public abstract class Persona
    {
       
      
        public string Name{get;set;}

       
        public string LastName{get;set;}

      
        public string Email{get;set;}

     
        public string Phone{get;set;}

         
        public int Age{get;set;}

         
        public string Genger{get;set;}

        public Usuario Usuario{get;set;}

        public int UsuarioId{get;set;}

       public Location Location{get;set;}

       public int LocationId{get;set;} 
    }
}