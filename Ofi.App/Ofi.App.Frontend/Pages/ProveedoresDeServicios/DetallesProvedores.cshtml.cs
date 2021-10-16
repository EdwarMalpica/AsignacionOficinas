using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;


namespace miWeb.App.Frontend.Pages
{
    public class DetallesProvedoresModel : PageModel
    {
        public static readonly IRepositorioProovedoresDeServicios _repositorioProvedoresDeServicios = new RepositorioProveedoresDeServicios(new Ofi.App.Persistencia.AppContext());
        public ProveedoresDeServicios proveedoresDeServicios{get;set;}
        public IActionResult OnGet(int? proveedoresDeServiciosId)
        {
            if(proveedoresDeServiciosId.HasValue){
                proveedoresDeServicios = _repositorioProvedoresDeServicios.GetProveedorServicio(proveedoresDeServiciosId.Value);
                if(proveedoresDeServicios == null){
                    return RedirectToPage("./ListProvedores");
                }else{
                    return Page();
                }
            }else{
                return RedirectToPage("./ListProvedores");
            }

        }
    }
}
