using System;

namespace Ofi.App.Dominio
{
    public class PersonalDeAseo : Persona

    {
        public PersonalDeAseo(int id, Turno turno, Secretaria unidadServicio) 
        {
            this.id = id;
                this.turno = turno;
                this.unidadServicio = unidadServicio;
               
        }
                public int id { get; set; }
        public Turno turno { get; set; }
        public Secretaria unidadServicio { get; set; }
    }
}