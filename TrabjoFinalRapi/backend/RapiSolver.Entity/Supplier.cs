using System.Collections.Generic;

namespace RapiSolver.Entity
{
    public class Supplier: Persona
    {
          public int SupplierId{get;set;}

          public  IEnumerable<ServiceDetails> ServiciosDetails{get;set;}

          public IEnumerable<Recommendation> Recommendations{get;set;}
    }
}