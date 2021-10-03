using System;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;
using System.Collections.Generic;
//using System.Collections.IEnumerable;





namespace Ofi.App.Consola
{
    class Program
    {
        private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarGobernacion();
            ActualizarGobernacion(2);
            EncontrarGobernacion(2);
            EncontrarGobernaciones();
            EliminarGobernacion(2);
        }

        //AdicionarGobernacion
        private static void AdicionarGobernacion()
        {

                //var gobernacion= new Gobernacion(1,"secretaria salud",new List<Secretaria>());
                var gobernacion= new Gobernacion{

                     listaSecretarias= new List<Secretaria>(),
                    nombre ="secretaria salud"
                       

            

                };


                _repoGobernacion.AddGobernacion(gobernacion);

        }

        //ActualizarGobernacion
        private static void ActualizarGobernacion (int idGobernacion)
        {
               //var gobernacion= new Gobernacion(1,"secretaria salud",new List<Secretaria>());
               var gobernacion= new Gobernacion{

                   id=idGobernacion,
                   nombre="secretaria transporte",
                    listaSecretarias= new List<Secretaria>()
               };

            Gobernacion GobernacionActualizada =_repoGobernacion.UpdateGobernacion(gobernacion);
            if (GobernacionActualizada != null)
                Console.WriteLine("se actualizó la gobernacion");

        }

        //EncontrarGobernacion
        private static void EncontrarGobernacion (int idGobernacion)
        {
            var GobernacionEncontrada = _repoGobernacion.GetGobernacion(idGobernacion);
            Console.WriteLine(GobernacionEncontrada.id);
        }

        //EncontrarGobernaciones

        private static void EncontrarGobernaciones()
        {
            IEnumerable<Gobernacion> gobernaciones = _repoGobernacion.GetAllGobernaciones();

            foreach (var gobernacion in gobernaciones)
            {
                Console.WriteLine(gobernacion.id);
            }

        }

        //EliminarGobernacion

     private static void EliminarGobernacion (int idGobernacion)
        {
            _repoGobernacion.DeleteGobernacion(idGobernacion);
            Console.WriteLine("Se elimino");

        }



    }
}
