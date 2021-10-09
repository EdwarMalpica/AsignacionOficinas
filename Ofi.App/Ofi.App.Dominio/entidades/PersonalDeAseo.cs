using System;

namespace Ofi.App.Dominio
{
    public class PersonalDeAseo : Persona
    {

       
        public Turno turno { get; set; }
        public Secretaria unidadServicio { get; set; }
    }
}