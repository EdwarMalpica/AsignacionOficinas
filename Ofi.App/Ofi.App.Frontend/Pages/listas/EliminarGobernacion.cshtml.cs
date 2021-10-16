using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;

namespace Ofi.App.Frontend.Pages
{
    public class EliminarGobernacionModel : PageModel
    {

         private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new Ofi.App.Persistencia.AppContext());
         [BindProperty]
        public Gobernacion gobernacion{get;set;}

        public IActionResult OnGet(int gobernacionid)
        {
            gobernacion = _repoGobernacion.GetGobernacion(gobernacionid);
            return Page();
        }
        public IActionResult OnPost()
        {
            _repoGobernacion.DeleteGobernacion(gobernacion);
            return RedirectToPage("./Gobernaciones");
        }




        
    }
}
