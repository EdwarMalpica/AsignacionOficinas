using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;

namespace Ofi.App.Frontend.Pages
{
    [Authorize]
    public class ListProvedoresModel : PageModel
    {
        public static readonly IRepositorioProovedoresDeServicios _repositorioProvedoresDeServicios = new RepositorioProveedoresDeServicios(new Ofi.App.Persistencia.AppContext());
        public IEnumerable<Ofi.App.Dominio.ProveedoresDeServicios> proveedoresDeServicios {get;set;}
        public void OnGet()
        {
            proveedoresDeServicios = _repositorioProvedoresDeServicios.GetAllProveedorServicio();
        }
    }
}
