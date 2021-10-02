using System;
using System.Collections.Generic;

namespace Ofi.App.Dominio
{
    public class GobernadorYAsesor : Persona
    {
       

        public GobernadorYAsesor(int idPersona, string nombre, string apellido, int edad, EstadoCovid estadoCovid,int id) : base(idPersona, nombre, apellido, edad, estadoCovid)
        {
            this.id = id;
        }

       
        public int id { get; set; }
        public List<Oficina> oficinasVisitadas { get; set; }
    }
}