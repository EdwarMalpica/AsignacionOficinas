using System;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;
using System.Collections.Generic;



namespace Ofi.App.Consola
{
    class Program
    {
        private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarGobernacion();
            ActualizarGobernacion(1);
            EncontrarGobernacion(1);
            EncontrarGobernaciones();
            EliminarGobernacion(1);
        }

        //AdicionarGobernacion
        private static void AdicionarGobernacion()
        {

                var gobernacion= new Gobernacion
                {
                    oficinas=2
                };

                _repoGobernacion.AddGobernacion(gobernacion);

        }

        //ActualizarGobernacion
        private static void ActualizarGobernacion (int idGobernacion)
        {
                var gobernacion = new Gobernacion
                {
                    id=idGobernacion
                };

            Gobernacion gobernacionActualizada =_repoGobernacion.UpdateGobernacion(gobernacion);
            if (profesorActuliazado != null)
                Console.WriteLine("se actualizó la gobernacion");

        }

        //EncontrarGobernacion
        private static void EncontrarGobernacion (int idGobernacion)
        {
            var gobernacionEncontrada = _repoGobernacion.GetGobernacion(idGobernacion);
            console.WriteLine(gobernacionEncontrada.id);
        }

        //EncontrarGobernaciones

        private static void EncontrarGobernaciones()
        {
            IEnumerable<Gobernacion> gobernaciones = _repoGobernacion.GetAllGobernaciones();

            foreach (var gobernacion in gobernaciones)
            {
                console.WriteLine(profesor.id);
            }

        }

        //EliminarGobernacion

        private static void EliminarGobernacion (int idGobernacion)
        {
            _repoGobernacion.DeleteGobernacion();
            console.WriteLine("Se elimino");

        }



    }
}
