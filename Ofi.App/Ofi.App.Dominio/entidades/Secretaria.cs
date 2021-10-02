using System;
using System.Collections.Generic;

namespace Ofi.App.Dominio
{
    public class Secretaria
    {
        public int id { get; set; }
        public TipoSecretaria tipoSecretaria { get; set; }
        public int numeroOficinas { get; set; }
    }
}