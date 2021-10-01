using System;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;
using System.Collections.Generic;

namespace Ofi.App.Consola
{
    class Program
    {
        private static IRepositorioSecretaria _repoSecretaria= new RepositorioSecretaria(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarSecretaria();
            //ActualizarSecretaria(1);
            EncontrarSecretaria(1);
            EncontrarSecretarias();
            //EliminarSecretaria(1);
        }

        //AdicionarSecretaria
        private static void AdicionarSecretaria()
        {

                var secretaria= new Secretaria
                {
                    numeroOficinas=2
                };

                _repoSecretaria.AddSecretaria(secretaria);

        }

        //ActualizarSecretaria
        //private static void ActualizarSecretaria (int idSecretaria)
        //{
        //        var secretaria = new Secretaria
        //        {
        //            id=idSecretaria
        //        };

        //    Secretaria SecretariaActualizada =_repoSecretaria.UpdateSecretaria(secretaria);
        //    if (SecretariaActualizada != null)
        //        Console.WriteLine("se actualizó la secretaria");

        //}

        //EncontrarSecretaria
        private static void EncontrarSecretaria (int idSecretaria)
        {
            var SecretariaEncontrada = _repoSecretaria.GetSecretaria(idSecretaria);
            Console.WriteLine(SecretariaEncontrada.id);
        }

        //EncontrarSecretarias

        private static void EncontrarSecretarias()
        {
            IEnumerable<Secretaria> secretarias = _repoSecretaria.GetAllSecretarias();

            foreach (var secretaria in secretarias)
            {
                Console.WriteLine(secretaria.id);
            }

        }

        //EliminarSecretaria

        private static void EliminarSecretaria (int idSecretaria)
        {
            _repoSecretaria.DeleteSecretaria(idSecretaria);
            Console.WriteLine("Se elimino");

        }
    }
}

