using System;

namespace Ofi.App.Dominio
{
    public class Ingreso
    { 
        public int id{get;set;}
        public DateTime horaIngreso{ get; set; }
        public Persona persona { get; set; }
        public Oficina oficina { get; set; }

    }
}
