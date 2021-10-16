using System;

namespace Ofi.App.Dominio
{
    public class PersonalDeAseo : Persona
    {
        
        public int id { get; set; }
        public Turno turno { get; set; }
        public Secretaria unidadServicio { get; set; }
    }
}