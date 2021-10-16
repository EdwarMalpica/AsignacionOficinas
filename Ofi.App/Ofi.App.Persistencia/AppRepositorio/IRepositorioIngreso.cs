using System.Collections.Generic;
using Ofi.App.Dominio;

namespace Ofi.App.Persistencia

 {
     public interface IRepositorioIngreso

     { 
         //CRUD 
         //GetAllIngreso
         IEnumerable<Ingreso> GetAllIngreso();
         //GetAllIngreso
         Ingreso GetIngreso(int idIngreso);
         //AddIngreso
         Ingreso AddIngreso(Ingreso ingreso);
         
         //UpdateIngreso
         Ingreso UpdateIngreso(Ingreso ingreso); 
          //DeleteIngreso
          void DeleteIngreso (int idIngreso);
     }
  }
