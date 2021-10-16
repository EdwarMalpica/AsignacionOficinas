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
    
    public class EliminarPersonalDeAseoModel : PageModel
    {
        private static IRepositoriosPersonalDeAseo _repositorioPersonalDeAseo = new RepositoriosPersonalDeAseo(new Ofi.App.Persistencia.AppContext());
        [BindProperty]
        public PersonalDeAseo personal{get;set;}

        public IActionResult OnGet(int? personalDeAseoId)
        {
            if(personalDeAseoId.HasValue){
                personal = _repositorioPersonalDeAseo.GetPersonalDeAseo(personalDeAseoId.Value);
                return Page();
            }else{
                return RedirectToPage("./ListaPersonalDeAseo");
            }

        }
        public IActionResult OnPost(){
            _repositorioPersonalDeAseo.DeletePersonalDeAseo(personal.id);
            return RedirectToPage("./ListaPersonalDeAseo");
        }
    }
}
