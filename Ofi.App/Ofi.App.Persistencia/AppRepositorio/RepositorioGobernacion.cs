using System.Collections.Generic;
using Ofi.App.Dominio;
Using System.Linq;


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
                var GobernacionEncontrada = _appContext.Gobernacion.FirstOrDefault(g=>g.id==idGobernacion);
                return gobernacionEncontrada;

            }

            //AddGobernacion
            Gobernacion IRepositorioGobernacion.AddGobernacion(Gobernacion gobernacion )
            {
            var GobernacionAdicionada = _appContext.gobernaciones.Add(Gobernacion);
            _appContext.SaveChanges();
            return gobernacionAdicionada.Entity;
            }

            //UpdateGobernacion
            Gobernacion IRepositorioGobernacion.UpdateGobernacion(Gobernacion gobernacion)
            {

                var gobernacionEncontrada = _appContext.gobernaciones.FirstOrDefault(g=>g.id==gobernacion.id);
                if (gobernacionEncontrada != null)
                {
                    gobernacionEncontrada.oficinas= gobernacion.oficinas;

                    _appContext.SaveChanges();

                }
                return gobernacionEncontrada;

            }

            //DeleteGobernacion
            void IRepositorioGobernacion.DeleteGobernacion (int idGobernacion)
            {
                var GobernacionEncontrada =_appContext.gobernaciones.FirstOrDefault(g=>g.id==idGobernacion);
                if(GobernacionEncontrada==null)
                        return;
                _appContext.gobernaciones.Remove(GobernacionEncontrada);
                _appContext.SaveChanges();



            }


    }


    
}