using System;
using System.Collections.Generic;
namespace Ofi.App.Dominio
{
    public class Gobernacion
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public List<Secretaria> listaSecretarias { get; set; }
        
    }
}