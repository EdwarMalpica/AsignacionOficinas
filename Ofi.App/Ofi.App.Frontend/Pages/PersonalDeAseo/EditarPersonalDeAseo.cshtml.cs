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
    public class EditarPersonalDeAseoModel : PageModel
    {
        private static IRepositoriosPersonalDeAseo _repositorioPersonalDeAseo = new RepositoriosPersonalDeAseo(new Ofi.App.Persistencia.AppContext());
        [BindProperty]
        public PersonalDeAseo personal {get;set;}
        public IActionResult OnGet(int? personalDeAseoId)
        {
            if(personalDeAseoId.HasValue){
                personal = _repositorioPersonalDeAseo.GetPersonalDeAseo(personalDeAseoId.Value);
            }else{
                return RedirectToPage("./ListaPersonalDeAseo");
            }
            if(personal == null){
                 return RedirectToPage("./ListaPersonalDeAseo");   
            }
            return Page();
        }

        public IActionResult OnPost(){
            if(!ModelState.IsValid){
                return Page();
            }else{
                _repositorioPersonalDeAseo.UpdatePersonalDeAseo(personal);
            }
            return RedirectToPage("./ListaPersonalDeAseo");
        }
    }
}
