using System;


namespace Ofi.App.Dominio
{
    public class SecretariosDeDespacho : Persona
    {
     


    /* public SecretariosDeDespacho(int idPersona, string nombre, string apellido, int edad, EstadoCovid estadoCovid,int id, Oficina despacho) : base(idPersona, nombre, apellido, edad, estadoCovid)
        {
            this.id = id;
            this.despacho = despacho;
        }*/

        //public int id { get; set; }
        public Oficina despacho { get; set; }
    }
}