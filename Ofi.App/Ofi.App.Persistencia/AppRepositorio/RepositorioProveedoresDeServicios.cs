using Ofi.App.Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Ofi.App.Persistencia
{
    public class RepositorioProveedoresDeServicios : IRepositorioProovedoresDeServicios
    {
        private readonly AppContext _appContext;
        public RepositorioProveedoresDeServicios(AppContext appContext){
            _appContext = appContext;
        }

        //CRUD
        //GetAllProveedoresDeServicios
        IEnumerable<ProveedoresDeServicios> IRepositorioProovedoresDeServicios.GetAllProveedorServicio()
        {
            return _appContext.proveedores_de_servicio;

        }
        //GetProveedoresDeServicios
        ProveedoresDeServicios IRepositorioProovedoresDeServicios.GetProveedorServicio(int idProveedoresDeServicios){
            var ProveedoresDeServiciosEncontrado = _appContext.proveedores_de_servicio.FirstOrDefault(p => p.id == idProveedoresDeServicios);
            return ProveedoresDeServiciosEncontrado;
        }
        //AddProveedoresDeServicios
        ProveedoresDeServicios IRepositorioProovedoresDeServicios.AddProveedorServicio(ProveedoresDeServicios ProveedoresDeServicios){
            var ProveedoresDeServiciosAdicionado = _appContext.proveedores_de_servicio.Add(ProveedoresDeServicios);
            _appContext.SaveChanges();
            return ProveedoresDeServiciosAdicionado.Entity;
        }
        //UpdateProveedoresDeServicios
        ProveedoresDeServicios IRepositorioProovedoresDeServicios.UpdateProveedorServicio(ProveedoresDeServicios ProveedoresDeServicios){
            var ProveedoresDeServiciosEncontrado = _appContext.proveedores_de_servicio.FirstOrDefault(p => p.id == ProveedoresDeServicios.id);
            if(ProveedoresDeServiciosEncontrado != null){
                ProveedoresDeServiciosEncontrado.nombre = ProveedoresDeServicios.nombre;
                ProveedoresDeServiciosEncontrado.id = ProveedoresDeServicios.id;
                ProveedoresDeServiciosEncontrado.apellido = ProveedoresDeServicios.apellido;
                ProveedoresDeServiciosEncontrado.edad = ProveedoresDeServicios.edad;
                ProveedoresDeServiciosEncontrado.estadoCovid = ProveedoresDeServicios.estadoCovid;
                ProveedoresDeServiciosEncontrado.servicioRealizado = ProveedoresDeServicios.servicioRealizado;
                ProveedoresDeServiciosEncontrado.unidadServicio = ProveedoresDeServicios.unidadServicio;
                _appContext.SaveChanges();
            }
            return ProveedoresDeServiciosEncontrado;
        }
        void IRepositorioProovedoresDeServicios.DeleteProveedorServicio(int idProveedoresDeServicios){
            var ProveedoresDeServiciosEncontrado = _appContext.proveedores_de_servicio.FirstOrDefault(p=>p.id==idProveedoresDeServicios);
            if(ProveedoresDeServiciosEncontrado == null){
                return;
            }
            _appContext.proveedores_de_servicio.Remove(ProveedoresDeServiciosEncontrado);
            _appContext.SaveChanges();
        }

    }

}