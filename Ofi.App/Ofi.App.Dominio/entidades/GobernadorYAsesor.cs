using System;
using System.Collections.Generic;

namespace Ofi.App.Dominio
{
    public class GobernadorYAsesor : Persona
    {
       

        
       
        public int id { get; set; }
        public List<Oficina> oficinasVisitadas { get; set; }
    }
}