using System;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;
using System.Collections.Generic;


namespace Ofi.App.Consola
{
    class Program
    {
        private static IRepositorioSecretaria _repoSecretaria= new RepositorioSecretaria(new Persistencia.AppContext());

        private static IRepositorioReporteCovid _repoReporteCovid= new RepositorioReporteCovid(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AdicionarSecretaria();
            ActualizarSecretaria(0);
            EncontrarSecretaria(0);
            EncontrarSecretarias();
            EliminarSecretaria(0);
            AdicionarReporteCovid();
            ActualizarReporteCovid(300);
            EncontrarReporteCovid(300);
            EncontrarReporteCovid();
            EliminarReporteCovid(300);
        }

        //AdicionarSecretaria
        private static void AdicionarSecretaria()
         {

                
                var secretaria= new Secretaria
                {
                    
                    listaOficinas= new List<Oficina>(),
                    tipoSecretaria= TipoSecretaria.educacion

                };


                _repoSecretaria.AddSecretaria(secretaria);

        }

        //ActualizarSecretaria
         private static void ActualizarSecretaria (int idSecretaria)
           {
               //var gobernacion= new Gobernacion(1,"secretaria salud",new List<Secretaria>());
               var secretaria= new Secretaria
               {

                   id=idSecretaria,
                   tipoSecretaria= TipoSecretaria.educacion,
                    listaOficinas= new List<Oficina>()
               };

            Secretaria SecretariaActualizada =_repoSecretaria.UpdateSecretaria(secretaria);

            if (SecretariaActualizada != null)
                Console.WriteLine("se actualizó la secretaria");

        }

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

        //AdicionarSecretaria
        private static void AdicionarReporteCovid()
         {

                
                var reporteCovid= new ReporteCovid
                {
                    
                    persona= new Persona(),
                    sintomas= new string ("dolor"),
                    fechaDiagnostico= new DateTime(),
                    tiempoAistamiento= (2)

                };


                _repoReporteCovid.AddReporteCovid(reporteCovid);

        }

        //ActualizarReporteCovid
         private static void ActualizarReporteCovid (int idReporteCovid)
           {
            
               var reporteCovid= new ReporteCovid
               {

                    persona= new Persona(),
                    sintomas= new string ("dolor"),
                    fechaDiagnostico= new DateTime(),
                    tiempoAistamiento= (2)
               };

            ReporteCovid ReporteCovidActualizado =_repoReporteCovid.UpdateReporteCovid(reporteCovid);

            if (ReporteCovidActualizado != null)
                Console.WriteLine("se actualizó el reporte covid");

        }

        //EncontrarReporteCovid
        private static void EncontrarReporteCovid (int idReporteCovid)
        {
            var ReporteCovidEncontrada = _repoReporteCovid.GetReporteCovid(idReporteCovid);
            Console.WriteLine(ReporteCovidEncontrada.id);
        }

        //EncontrarReporteCovid

        private static void EncontrarReporteCovid()
        {
            IEnumerable<ReporteCovid> reporte_covid = _repoReporteCovid.GetAllReporteCovid();

            foreach (var reporteCovid in reporte_covid)
            {
                Console.WriteLine(reporteCovid.id);
            }

        }

        //EliminarReporteCovid

        private static void EliminarReporteCovid (int idReporteCovid)
        {
            _repoReporteCovid.DeleteReporteCovid(idReporteCovid);
            Console.WriteLine("Se elimino");

        }
    }
}

