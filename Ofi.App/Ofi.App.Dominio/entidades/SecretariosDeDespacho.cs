using System;


namespace Ofi.App.Dominio
{
    public class SecretariosDeDespacho : Persona
    {
        public int id { get; set; }
        public Oficina despacho { get; set; }
      //  public int desOficinas { get; set; }
    }
}