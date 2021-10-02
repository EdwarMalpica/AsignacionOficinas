using System.Collections.Generic;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;
namespace Ofi.App.Persistencia
{
    public interface IRepositoriosPersonalDeAseo
    {
         //CRUD
         //GetAllPersonalDeAseo
         IEnumerable<PersonalDeAseo> GetAllPersonalDeAseo();
         //GetPersonalDeAseo
         PersonalDeAseo GetPersonalDeAseo(int idPersonalDeAseo);
         //AddPersonalDeAseo
         PersonalDeAseo AddPersonalDeAseo(PersonalDeAseo personalDeAseo);
         //UpdatePersonalDeAseo
         PersonalDeAseo UpdatePersonalDeAseo(PersonalDeAseo personalDeAseo);
         //DeletePersonalDeAseo
         void DeletePersonalDeAseo(int idPersonalDeAseo);

    }
}