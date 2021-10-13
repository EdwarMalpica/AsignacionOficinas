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
    public class GobernacionesModel : PageModel
    {

        
        private static IRepositorioGobernacion _repoGobernacion = new RepositorioGobernacion(new Ofi.App.Persistencia.AppContext());
        public IEnumerable<Gobernacion> gobernaciones {get;set;}
          public Gobernacion gobernacion{get;set;}


        public void OnGet()
        {

            gobernaciones=_repoGobernacion.GetAllGobernaciones();
        }
    }
}
