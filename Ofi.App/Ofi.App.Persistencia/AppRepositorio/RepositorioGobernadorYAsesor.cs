using System.Collections.Generic;
using Ofi.App.Dominio;
using System.Linq;

namespace Ofi.App.Persistencia
{
    public class RepositorioGobernadorYAsesor: IRepositorioGobernadorYAsesor
    {
        private readonly AppContext _appContext;
        public RepositorioGobernadorYAsesor(AppContext appContext)
        {
          _appContext = appContext;
        }
        //CRUD
        //GetAllGobernacionYAsesor
        IEnumerable<GobernadorYAsesor> IRepositorioGobernadorYAsesor.GetAllGobernadorYAsesor()
        {
            return _appContext.gobernador_y_asesores;
        }
        //GetGobernadorYAsesor
        GobernadorYAsesor IRepositorioGobernadorYAsesor.GetGobernadorYAsesor (int idGobernadorYAsesor)
        {
         var GobernadorYAsesorEncontrado = _appContext.gobernador_y_asesores.FirstOrDefault(p =>p.id==idGobernadorYAsesor);
            return GobernadorYAsesorEncontrado;
        }
        //AddGobernadorYAsesor
        GobernadorYAsesor IRepositorioGobernadorYAsesor.AddGobernadorYAsesor (GobernadorYAsesor gobernadoryasesor)
        {
            var gobernadoryasesorAdicionado = _appContext.gobernador_y_asesores.Add(gobernadoryasesor);
            _appContext.SaveChanges();
            return gobernadoryasesorAdicionado.Entity;
        }
        //updateGobernadorYAsesor
        GobernadorYAsesor IRepositorioGobernadorYAsesor.UpdateGobernadorYAsesor(GobernadorYAsesor gobernadoryasesor)
        {
            var gobernadoryasesorEncontrado = _appContext.gobernador_y_asesores.FirstOrDefault(p =>p.id ==gobernadoryasesor.id);
            if (gobernadoryasesorEncontrado != null)
            {
              //aqui va es una lista 
              gobernadoryasesorEncontrado.oficinasVisitadas = gobernadoryasesor.oficinasVisitadas;
               _appContext.SaveChanges();
            }
            return gobernadoryasesorEncontrado;
        }
        //DeleteGobernadorYAsesor
        void IRepositorioGobernadorYAsesor.DeleteGobernadorYAsesor(int idGobernadorYAsesor)
        {
            var gobernadoryasesorEncontrado = _appContext.gobernador_y_asesores.FirstOrDefault(p =>p.id ==idGobernadorYAsesor);
            if (gobernadoryasesorEncontrado == null)
               return;
            _appContext.gobernador_y_asesores.Remove(gobernadoryasesorEncontrado);
            _appContext.SaveChanges();
        }



    }
}
