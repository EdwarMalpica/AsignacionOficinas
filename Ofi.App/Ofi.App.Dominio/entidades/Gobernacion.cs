using System;

namespace Ofi.App.Dominio
{
    public class Gobernacion
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public List<Secretarias> listaSecretarias { get; set; }
        
    }
}