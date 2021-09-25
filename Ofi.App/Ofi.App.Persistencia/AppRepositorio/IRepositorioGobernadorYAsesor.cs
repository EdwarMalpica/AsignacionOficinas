using System.Collections.Generic;
using ofi.App.Dominio;

namespace ofi.App.Persistencia

 {
     public interface IRepositorioGobernadorYAsesor

     { 
         //CRUD 
         //GetAllGobernadorYAsesor
         IEnumerable <GobernadorYAsesor> GetAllGobernadorYAsesor();
         //GetAllGobernadorYAsesor
         GobernadorYAsesor GetGobernadorYAsesor(int idGobernadorYAsesor);
         //AddGobernadorYAsesor
         GobernadorYAsesor AddGobernadorYAsesor (Gobernador GobernadorYAsesor);
         
         //UpdateGobernadorYAsesor
         GobernadorYAsesor UpdateGobernadorYAsesor (int idGobernadorYAsesor); 
          //DeleteGobernadorYAsesor
          void DeleteGobernadorYAsesor (int idGobernadorYAsesor);
     }
  }
