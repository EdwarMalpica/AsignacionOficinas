using System;

namespace Ofi.App.Dominio
{
    public class ReporteCovid 
    {
        public int id { get; set; }
        public Persona persona { get; set; }
        public string sintomas { get; set; }
        public DateTime fechaDiagnostico{get;set;}
        public int tiempoAistamiento { get; set; }
    }
}