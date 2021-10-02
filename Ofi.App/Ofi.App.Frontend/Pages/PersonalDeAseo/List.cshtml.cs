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
    public class ListModel : PageModel
    {
        //private List<PersonalDeAseo> personalDeAseos{get;set;}
        public readonly IRepositoriosPersonalDeAseo repositoriosPersonalDeAseo;
        public IEnumerable<PersonalDeAseo> personalDeAseos{get;set;}
        public ListModel(IRepositoriosPersonalDeAseo repositoriosPersonalDeAseo){
            this.repositoriosPersonalDeAseo = repositoriosPersonalDeAseo;
        }
        
        public void OnGet(){
            personalDeAseos = repositoriosPersonalDeAseo.GetAllPersonalDeAseo();
        }
    }
}
