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
    public class DetallesReporteCovidModel : PageModel
    {
        private static IRepositorioReporteCovid _repoReporteCovid = new RepositorioReporteCovid(new Ofi.App.Persistencia.AppContext());
        public ReporteCovid reporteCovid {get; set; }
        public IActionResult OnGet(int? ReporteCovidid)
        {
            reporteCovid = _repoReporteCovid.GetReporteCovid((int)ReporteCovidid);
            Console.WriteLine(reporteCovid.id);
            if(reporteCovid == null)
            {
                return RedirectToPage("./ReporteCovid");
            }else{
                return Page();
            }
        }
    }
}
