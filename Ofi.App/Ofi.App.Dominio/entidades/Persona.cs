using System;

namespace Ofi.App.Dominio
{
    public class Persona
    {

       /* public Persona(int id, string nombre, string apellido, int edad, EstadoCovid estadoCovid) 
        {
                this.idPersona = id;
                this.nombre = nombre;
                this.apellido = apellido;
                this.edad = edad;
                this.estadoCovid = estadoCovid;
               
        }*/

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public EstadoCovid estadoCovid { get; set; }

    }
}