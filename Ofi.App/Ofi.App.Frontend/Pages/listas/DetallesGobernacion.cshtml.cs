using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;

namespace Ofi.App.Frontend.Pages
{
    public class DetallesGobernacionModel : PageModel
    {
        private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new Persistencia.AppContext());
        public Gobernacion gobernacion {get;set;}

        public IActionResult OnGet(int gobernacionid)
        {
             gobernacion = _repoGobernacion.GetGobernacion(gobernacionid);
            Console.WriteLine(gobernacion.id);
            if(gobernacion==null)
            {
                return RedirectToPage("./Gobernacion");
            }else{
                return Page();
            }




        }
    }
}


