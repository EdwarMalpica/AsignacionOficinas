using System.Collections.Generic;
using ofi.App.Dominio;
using System.Linq;

namespace Ofi.App.Persistencia
{
    public class RepositorioGobernadorYAsesor : IRepositorioGobernadorYAsesor
    {
        private readonly AppContext_appContext;
        public RepositorioGobernadorYAsesor (AppContext appContext)
        {
          _appContext = appContext;
        }
        //CRUD
        //GetAllGobernacionYAsesor
        IEnumerable <GobernadorYAsesor> IRepositorioGobernadorYAsesor.GetAllGobernadorYAsesor()
        {
            return_appContext.gobernador_y_asesores;
        }
        //GetGobernadorYAsesor
        GobernadorYAsesor IRepositorioGobernadorYAsesor.GetGobernadorYAsesores (int idGobernadorYAsesor);
        {
         var GobernadorYAsesorEncontrado = _appContext.GobernadorYAsesor.FirstOrDefault(p =>p.id==idGobernadorYAsesor);
            return GobernadorYAsesorEncontrado;
        }

    }
}
