using Microsoft.EntityFrameworkCore;
using Ofi.App.Dominio;

namespace Ofi.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona>                   personas {get;set;}
        public DbSet<GobernadorYAsesor>         gobernador_y_asesores {get;set;}
        public DbSet<Gobernacion>               gobernaciones {get;set;}
        public DbSet<Secretaria>                secretarias {get;set;}
        public DbSet<Oficina>                   oficinas {get;set;}
        public DbSet<ReporteCovid>              reporte_covid {get;set;}
        public DbSet<PersonalDeAseo>            personal_de_aseo {get;set;}
        public DbSet<SecretariosDeDespacho>     secretarios_de_despacho {get;set;}
        public DbSet<ProveedoresDeServicios>     proveedores_de_servicio {get;set;}
        public DbSet<Ingreso>                   ingresos {get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        if(!optionsBuilder.IsConfigured){
            optionsBuilder.UseSqlServer("Server=tcp:ofiapp.database.windows.net,1433;Initial Catalog=WinampBackend;Persist Security Info=False;User ID=winamp;Password=Code@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
}
}