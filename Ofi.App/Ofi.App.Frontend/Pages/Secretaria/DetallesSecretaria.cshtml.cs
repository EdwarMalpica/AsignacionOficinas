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
    public class DetallesSecretariaModel : PageModel
    {
        private static IRepositorioSecretaria _repoSecretaria = new RepositorioSecretaria(new Ofi.App.Persistencia.AppContext());
        public Secretaria secretarias {get; set; }
        public IActionResult OnGet(int? secretariasid)
        {    
            if(secretariasid.HasValue)
            {
             Console.WriteLine(secretarias.id);
             secretarias = _repoSecretaria.GetSecretaria((int)secretariasid);
            
              if(secretarias == null)
              {
                  return RedirectToPage("./ListSecretaria");
              }else{
                  return Page();
              }
            }else{
                  return RedirectToPage("./ListSecretaria");
 
            }
        }
    }
}