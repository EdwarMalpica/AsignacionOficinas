using System;

namespace Ofi.App.Dominio
{
    public class ProveedoresDeServicio : Persona
    {
        public string servicioRealizado { get; set; }
        public Secretaria unidadServicio { get; set; }
    }
}