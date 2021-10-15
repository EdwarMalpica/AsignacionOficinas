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
    public class CrearReporteCovidModel : PageModel
    {
        private static IRepositorioReporteCovid _repoReporteCovid = new RepositorioReporteCovid(new Ofi.App.Persistencia.AppContext());
        [BindProperty]
        public ReporteCovid reporteCovid { get; set; }
        public IActionResult OnGet(int? reporteCovidid)
        {
            if (reporteCovidid.HasValue)
            {
                return RedirectToPage("./ListReporteCovid");

            }else{
                reporteCovid= new ReporteCovid();

            }

            if(reporteCovid == null)
            {
                return RedirectToPage("./ListReporteCovid");

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
                if (reporteCovid.id > 0)
                {
                    _repoReporteCovid.UpdateReporteCovid(reporteCovid);
                }
                else
                {
                   _repoReporteCovid.AddReporteCovid(reporteCovid);
                }
                return RedirectToPage("./ListReporteCovid");
        }

    }
}
}
