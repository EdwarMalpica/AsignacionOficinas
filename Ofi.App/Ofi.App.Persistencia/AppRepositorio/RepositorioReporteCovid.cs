using System.Collections.Generic;
using Ofi.App.Dominio;
using System.Linq;


namespace Ofi.App.Persistencia
{
    public class RepositorioReporteCovid : IRepositorioReporteCovid
    {

            private readonly AppContext _appContext;

            public RepositorioReporteCovid (AppContext appContext)
            {

                _appContext=appContext;
        

            }


            //GetAllReporteCovid
            IEnumerable<ReporteCovid> IRepositorioReporteCovid.GetAllReporteCovid()
            {

                return _appContext.reporte_covid;
            
            }

            //GetReporteCovid

            ReporteCovid IRepositorioReporteCovid.GetReporteCovid(int idReporteCovid)
            {
                var ReporteCovidEncontrado = _appContext.reporte_covid.FirstOrDefault(g=>g.id==idReporteCovid);
                return ReporteCovidEncontrado;

            }

            //AddReporteCovid
            ReporteCovid IRepositorioReporteCovid.AddReporteCovid(ReporteCovid reporte_covid )
            {
            var ReporteCovidAdicionado = _appContext.reporte_covid.Add(reporte_covid);
            _appContext.SaveChanges();
            return ReporteCovidAdicionado.Entity;
            }

             //UpdateReporteCovid
            ReporteCovid IRepositorioReporteCovid.UpdateReporteCovid(ReporteCovid reporte_covid)
            {

                var ReporteCovidEncontrada = _appContext.reporte_covid.FirstOrDefault(g=>g.id==reporte_covid.id);
                if (ReporteCovidEncontrada != null)
                {
                    ReporteCovidEncontrada.id= reporte_covid.id;

                    _appContext.SaveChanges();

                }
                return ReporteCovidEncontrada;

            }


            //DeleteReporteCovid
            void IRepositorioReporteCovid.DeleteReporteCovid (int idReporteCovid)
            {
                var ReporteCovidEncontrado =_appContext.reporte_covid.FirstOrDefault(g=>g.id==idReporteCovid);
                if(ReporteCovidEncontrado==null)
                        return;
                _appContext.reporte_covid.Remove(ReporteCovidEncontrado);
                _appContext.SaveChanges();



            }


    }


    
}