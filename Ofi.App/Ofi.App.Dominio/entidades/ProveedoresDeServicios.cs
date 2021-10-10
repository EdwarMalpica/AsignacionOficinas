using System;

namespace Ofi.App.Dominio
{
    public class ProveedoresDeServicios : Persona
    {

       /* public ProveedoresDeServicios(int idPersona, string nombre, string apellido, int edad, EstadoCovid estadoCovid,int id, string servicioRealizado, Secretaria unidadServicio) : base(idPersona, nombre, apellido, edad, estadoCovid)
        {
            this.id = id;
            this.servicioRealizado = servicioRealizado;
            this.unidadServicio = unidadServicio;
        }*/

       // public int id { get; set; }
        public string servicioRealizado { get; set; }
        public Secretaria unidadServicio { get; set; }
    }
}