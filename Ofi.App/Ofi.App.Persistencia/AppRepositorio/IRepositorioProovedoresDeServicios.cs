using System.Collections.Generic;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;
namespace Ofi.App.Persistencia
{
    public interface IRepositorioProovedoresDeServicios
    {
         //CRUD
         //GetAllProveedorServicio
         IEnumerable<ProveedoresDeServicios> GetAllProveedorServicio();
         //GetProveedorServicio
         ProveedoresDeServicios GetProveedorServicio(int idProveedorServicio);
         //AddProveedorServicio
         ProveedoresDeServicios AddProveedorServicio(ProveedoresDeServicios ProveedorServicio);
         //UpdateProveedorServicio
         ProveedoresDeServicios UpdateProveedorServicio(ProveedoresDeServicios ProveedorServicio);
         //DeleteProveedorServicio
         void DeleteProveedorServicio(int idProveedorServicio);

    }
}