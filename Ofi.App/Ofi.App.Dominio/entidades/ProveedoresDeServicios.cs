using System;

namespace Ofi.App.Dominio
{
    public class ProveedoresDeServicio : Persona
    {
        public int id { get; set; }
        public string servicioRealizado { get; set; }
        public Secretaria unidadServicio { get; set; }
    }
}