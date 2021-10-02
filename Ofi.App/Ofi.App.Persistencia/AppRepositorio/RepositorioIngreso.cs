using System.Collections.Generic;
using Ofi.App.Dominio;
using System.Linq;

namespace Ofi.App.Persistencia
{
    public class RepositorioIngreso: IRepositorioIngreso
    {
        private readonly AppContext _appContext;
        public RepositorioIngreso(AppContext appContext)
        {
          _appContext = appContext;
        }
        //CRUD
        //GetAllIngreso
        IEnumerable<Ingreso> IRepositorioIngreso.GetAllIngreso()
        {
            return _appContext.ingresos;
        }
        //GetIngreso
        Ingreso IRepositorioIngreso.GetIngreso(int idIngreso)
        {
         var IngresoEncontrado = _appContext.ingresos.FirstOrDefault(p =>p.id==idIngreso);
            return IngresoEncontrado;
        }
        //AddIngreso
        Ingreso IRepositorioIngreso.AddIngreso (Ingreso ingreso)
        {
            var ingresoAdicionado = _appContext.ingresos.Add(ingreso);
            _appContext.SaveChanges();
            return ingresoAdicionado.Entity;
        }
        //updateIngreso
        Ingreso IRepositorioIngreso.UpdateIngreso(Ingreso ingreso)
        {
            var ingresoEncontrado = _appContext.ingresos.FirstOrDefault(p =>p.id ==ingreso.id);
            if (ingresoEncontrado != null)
            {
              
              ingresoEncontrado.horaIngreso = ingreso.horaIngreso;
              ingresoEncontrado.persona = ingreso.persona;
              ingresoEncontrado.oficina = ingreso.persona;
               _appContext.SaveChanges();
            }
            return ingresoEncontrado;
        }
        //DeleteIngreso
        void IRepositorioIngreso.DeleteIngreso(int idIngreso)
        {
            var ingresoEncontrado = _appContext.ingresos.FirstOrDefault(p =>p.id ==idIngreso);
            if (ingresoEncontrado == null)
               return;
            _appContext.ingresos.Remove(ingresoEncontrado);
            _appContext.SaveChanges();
        }
    }
}


