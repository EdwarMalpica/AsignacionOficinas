using System;

namespace Ofi.App.Dominio
{
    public class GobernadorYAsesor : Persona
    {
        public int id { get; set; }
        public System.Collections.Generic.List<Oficina> oficinasVisitadas {get;set;}
    }
}