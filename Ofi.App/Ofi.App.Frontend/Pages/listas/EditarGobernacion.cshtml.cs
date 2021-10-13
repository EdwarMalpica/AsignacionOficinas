using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;

namespace miWeb.App.Frontend.Pages
{
    public class EditarGobernacionModel : PageModel
    {
         private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new Ofi.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion { get; set; }
        public IActionResult OnGet(int? gobernacionid)
        {
            if (gobernacionid.HasValue)
            {
                gobernacion = _repoGobernacion.GetGobernacion(gobernacionid.Value);
            }
            else
            {
                gobernacion = new Gobernacion();
            }

            if (gobernacion == null)
            {
                return RedirectToPage("./Gobernaciones");
            }
            return Page();
        }





       
    }
}
