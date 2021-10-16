using System;
using System.Collections.Generic;
namespace Ofi.App.Dominio
{
    public class Gobernacion
    {
        /*public Gobernacion (int id, string nombre,List<Secretaria> listaSecretarias){
            this.id =id;
            this.nombre =nombre;
            this.listaSecretarias= listaSecretarias;
        }*/
        public int id { get; set; }
        public string nombre { get; set; }
        public List<Secretaria> listaSecretarias { get; set; }
        
    }
}