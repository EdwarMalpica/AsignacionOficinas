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
    public class ListSecretariaModel : PageModel
    {
        private static IRepositorioSecretaria repositorioSecretaria = new RepositorioSecretaria(new Ofi.App.Persistencia.AppContext());
        public IEnumerable<Secretaria> secretaria {get; set;}
        
    //    public ListModel(IRepositorioSecretaria repositorioSecretaria){
    //        this.repositorioSecretaria = repositorioSecretaria;

    //    }

        public void OnGet()
        {
            secretaria = repositorioSecretaria.GetAllSecretarias();
        }
    }
}
