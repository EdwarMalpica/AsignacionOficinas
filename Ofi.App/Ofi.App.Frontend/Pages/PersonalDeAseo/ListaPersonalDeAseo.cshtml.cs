using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Ofi.App.Dominio;
using Ofi.App.Persistencia;

namespace miWeb.App.Frontend.Pages
{
    [Authorize]
     public class ListaPersonalDeAseoModel : PageModel
    {
        //private List<PersonalDeAseo> personalDeAseos{get;set;}
        public static readonly IRepositoriosPersonalDeAseo repositoriosPersonalDeAseo = new RepositoriosPersonalDeAseo(new Ofi.App.Persistencia.AppContext());
        public IEnumerable<PersonalDeAseo> personalDeAseos{get;set;}
       
        
        public void OnGet(){
            personalDeAseos = repositoriosPersonalDeAseo.GetAllPersonalDeAseo();
        }
    }
}
