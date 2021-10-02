using System;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;
using System.Collections.Generic;

namespace Ofi.App.Consola
{
    class Program
    {
        private static IRepositorioSecretariosDeDespacho _repoSecretariosDeDespacho = new RepositorioSecretariosDeDespacho(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarSecretarioDeDespacho();
           // ActualizarSecretarioDeDespacho(1);
            //EncontrarSecretarioDeDespacho(1);
            //EncontrarSecretarioDeDespacho(2);
          //  EncontrarSecretarioDeDespacho(3);
          //  EncontrarSecretarioDeDespachoes();
            //EliminarSecretarioDeDespacho(2);
        }
        
        
        //CRUD
        //AdicionarSecretarioDeDespacho
        private static void AdicionarSecretarioDeDespacho()
        {
            var secretario_de_despacho = new SecretariosDeDespacho
            {
                    aforoMaximo= 4
              //desOficinas= 4
            };
            _repoSecretarioDeDespacho.AddSecretariosDeDespacho(secretario_de_despacho);
        }

        /*

        //ActualizarSecretarioDeDespacho
        private static void ActualizarSecretarioDeDespacho(int idSecretarioDeDespacho)
        {
            var secretario_de_despacho = new SecretarioDeDespacho
            {
                id =idSecretarioDeDespacho,
                nombre = "Santiago",
                apellido = "Murillo",
                edad = 100000,
                despacho = "30",
                
            };
            SecretarioDeDespacho secretario_de_despachoActualizado=_repoSecretarioDeDespacho.UpdateSecretarioDeDespacho(secretario_de_despacho);
            if (secretario_de_despachoActualizado!=null)
                Console.WriteLine("Se actualizó el secretario_de_despacho");
            
        }

        //EncontrarSecretarioDeDespacho
        private static void EncontrarSecretarioDeDespacho(int idSecretarioDeDespacho)
        {
            var secretario_de_despachoEncontrado = _repoSecretarioDeDespacho.GetSecretarioDeDespacho(idSecretarioDeDespacho);
            Console.WriteLine(secretario_de_despachoEncontrado.nombre);
        }

        //EncontrarSecretarioDeDespachoes
        private static void EncontrarSecretarioDeDespachoes()
        {
            IEnumerable<SecretarioDeDespacho> secretario_de_despachoes = _repoSecretarioDeDespacho.GetAllSecretarioDeDespachoes();

            foreach (var secretario_de_despacho in secretario_de_despachoes)
            {
                Console.WriteLine(secretario_de_despacho.nombre+" "+secretario_de_despacho.apellido+" "+secretario_de_despacho.condicionEspecial);
            }
        }
        //Eliminar SecretarioDeDespacho
        private static void EliminarSecretarioDeDespacho(int idSecretarioDeDespacho)
        {
            bool bandera=_repoSecretarioDeDespacho.DeleteSecretarioDeDespacho(idSecretarioDeDespacho);
            if (bandera)
                Console.WriteLine("Se eliminó el secretario_de_despacho");
            else
            {
                Console.WriteLine("Hubo un error al acceder a la base de datos");
            }
        }
            */


    }
}
