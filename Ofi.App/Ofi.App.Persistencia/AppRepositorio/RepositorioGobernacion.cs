using System.Collections.Generic;
using Ofi.App.Dominio;
using System.Linq;


namespace Ofi.App.Persistencia
{
    public class RepositorioGobernacion : IRepositorioGobernacion
    {

            private readonly AppContext _appContext;

            public RepositorioGobernacion (AppContext appContext)
            {

                _appContext=appContext;
        

            }


            //GetAllGobernaciones
            IEnumerable<Gobernacion> IRepositorioGobernacion.GetAllGobernaciones()
            {

                return _appContext.gobernaciones;
            
            }

            //GetGobernacion

            Gobernacion IRepositorioGobernacion.GetGobernacion(int idGobernacion)
            {
                var GobernacionEncontrada = _appContext.gobernaciones.FirstOrDefault(g=>g.id==idGobernacion);
                return GobernacionEncontrada;

            }

            //AddGobernacion
            Gobernacion IRepositorioGobernacion.AddGobernacion(Gobernacion gobernacion )
            {
            var GobernacionAdicionada = _appContext.gobernaciones.Add(gobernacion);
            _appContext.SaveChanges();
            return GobernacionAdicionada.Entity;
            }

            //UpdateGobernacion
            Gobernacion IRepositorioGobernacion.UpdateGobernacion(Gobernacion gobernacion)
            {

                var GobernacionEncontrada = _appContext.gobernaciones.FirstOrDefault(g=>g.id==gobernacion.id);
                if (GobernacionEncontrada != null)
                {
                    GobernacionEncontrada.listaSecretarias= gobernacion.listaSecretarias;
                    GobernacionEncontrada.nombre=gobernacion.nombre;

                    _appContext.SaveChanges();

                }
                return GobernacionEncontrada;

            }

            //DeleteGobernacion
            Gobernacion IRepositorioGobernacion.DeleteGobernacion (Gobernacion gobernacion)
            {
                var GobernacionEncontrada =_appContext.gobernaciones.FirstOrDefault(g=>g.id==gobernacion.id);
                if(GobernacionEncontrada==null)
                        return null;
                _appContext.gobernaciones.Remove(GobernacionEncontrada);
                _appContext.SaveChanges();
                return GobernacionEncontrada;



            }


    }


    
}