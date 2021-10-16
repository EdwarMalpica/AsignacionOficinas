using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;
using System.Diagnostics;

namespace Ofi.App.Frontend.Pages
{
    public class DetallesGobernadorYAsesorModel : PageModel
    {
        private static IRepositorioGobernadorYAsesor _repoGobernadorYAsesor = new RepositorioGobernadorYAsesor(new Ofi.App.Persistencia.AppContext());

        public GobernadorYAsesor gobernadoryasesor {get;set;}

        public IActionResult OnGet(int gobernadoryasesorid)
        {
            gobernadoryasesor = _repoGobernadorYAsesor.GetGobernacionYAsesor(gobernadoryasesorid);
            if(gobernadoryasesor == null)
            {
                return RedirectToPage("./GobernadorYAsesores");
            }
            return Page();
        }
    }
}