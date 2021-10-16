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
    public class EditarSecretariaModel : PageModel
    {
       private static IRepositorioSecretaria _repoSecretaria = new RepositorioSecretaria(new Ofi.App.Persistencia.AppContext());
        [BindProperty]
        public Secretaria secretaria { get; set; }
        public IActionResult OnGet(int? secretariaid)
        {
            if (secretariaid.HasValue)
            {
                secretaria = _repoSecretaria.GetSecretaria(secretariaid.Value);

            }else{
                secretaria = new Secretaria();

            }

            if (secretaria == null)
            {
                //return RedirectToPage("./ListSecretaria");

            }
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                if (secretaria.id > 0)
                {
                    _repoSecretaria.UpdateSecretaria(secretaria);
                }
                else
                {
                   _repoSecretaria.AddSecretaria(secretaria);
                }
                return RedirectToPage("./ListSecretaria");
        }

    }
}
}
