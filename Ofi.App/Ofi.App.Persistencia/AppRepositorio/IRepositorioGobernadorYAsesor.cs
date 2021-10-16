using System.Collections.Generic;
using Ofi.App.Dominio;

namespace Ofi.App.Persistencia

 {
     public interface IRepositorioGobernadorYAsesor

     { 
         //CRUD 
         //GetAllGobernadorYAsesor
         IEnumerable<GobernadorYAsesor> GetAllGobernadorYAsesor();
         //GetAllGobernadorYAsesor
         GobernadorYAsesor GetGobernadorYAsesor(int idGobernadorYAsesor);
         //AddGobernadorYAsesor
         GobernadorYAsesor AddGobernadorYAsesor(GobernadorYAsesor gobernadoryasesor);
         
         //UpdateGobernadorYAsesor
         GobernadorYAsesor UpdateGobernadorYAsesor(GobernadorYAsesor gobernadoryasesor); 
          //DeleteGobernadorYAsesor
          void DeleteGobernadorYAsesor (int idGobernadorYAsesor);
     }
  }
