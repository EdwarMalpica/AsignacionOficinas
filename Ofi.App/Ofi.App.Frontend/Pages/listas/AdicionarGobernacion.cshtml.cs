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
    public class AdicionarGobernacionModel : PageModel
    {

         private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new Ofi.App.Persistencia.AppContext());
        [BindProperty]
        public Gobernacion gobernacion { get; set; }
       
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (gobernacion.id > 0)
                {
                    _repoGobernacion.UpdateGobernacion(gobernacion);
                }
                else
                {
                    _repoGobernacion.AddGobernacion(gobernacion);
                }
                return RedirectToPage("./Gobernaciones");
            }
        }
    }
}
    

