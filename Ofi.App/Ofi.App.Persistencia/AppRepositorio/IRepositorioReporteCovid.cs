using System.Collections.Generic;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;


namespace Ofi.App.Persistencia
{
    
public interface IRepositorioReporteCovid
{
    //GetAllReporteCovid

    IEnumerable <ReporteCovid> GetAllReporteCovid();

    //GetReporteCovid
    ReporteCovid GetReporteCovid(int idReporteCovid);

    //AddReporteCovid
    ReporteCovid AddReporteCovid(ReporteCovid reporteCovid);

    //UpdateReporteCovid
    ReporteCovid UpdateReporteCovid(ReporteCovid reporteCovid);

    //DeleteReporteCovid
    void DeleteReporteCovid(int idReporteCovid);



}
}