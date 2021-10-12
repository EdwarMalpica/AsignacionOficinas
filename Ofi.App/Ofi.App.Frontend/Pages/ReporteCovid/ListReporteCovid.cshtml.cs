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
    public class ListReporteCovidModel : PageModel
    {
         private static IRepositorioReporteCovid repositorioReporteCovid = new RepositorioReporteCovid(new Ofi.App.Persistencia.AppContext());
        public IEnumerable<ReporteCovid> reporteCovid {get; set;}

       // public  ListModel(IRepositorioReporteCovid repositoriosReporteCovid){
       //     this.repositoriosReporteCovid = repositoriosReporteCovid;
       // }
       
        public void OnGet()
        {
            reporteCovid = repositorioReporteCovid.GetAllReporteCovid();
        }
    }
}
