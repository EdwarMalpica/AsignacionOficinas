using Ofi.App.Dominio;
using System.Collections.Generic;
using System.Linq;
namespace Ofi.App.Persistencia
{
    public class RepositoriosPersonalDeAseo : IRepositoriosPersonalDeAseo
    {
        List<PersonalDeAseo> personalDeAseos;

        public RepositoriosPersonalDeAseo(){
            personalDeAseos = new List<PersonalDeAseo>();/*{
                new PersonalDeAseo(){idPersona = 1,nombre = "Carlos",apellido = "Duarte",edad = 15,estadoCovid = EstadoCovid.negativo, id = 2,turno = Turno.diurno, unidadServicio = null},
                new PersonalDeAseo(){idPersona = 5,nombre = "Juan",apellido = "Duarte",edad = 15,estadoCovid = EstadoCovid.negativo, id = 25,turno = Turno.diurno, unidadServicio = null}
            };*/
            //personalDeAseos.Add(new PersonalDeAseo(1,"Carlos","Duarte",15,EstadoCovid.negativo,5,Turno.diurno
            //,null));
        }
        private readonly AppContext _appContext;
        public RepositoriosPersonalDeAseo(AppContext appContext){
            _appContext = appContext;
        }

        //CRUD
        //GetAllPersonalDeAseo
        IEnumerable<PersonalDeAseo> IRepositoriosPersonalDeAseo.GetAllPersonalDeAseo()
        {
            //return _appContext.personal_de_aseo;
            return personalDeAseos;

        }
        //GetPersonalDeAseo
        PersonalDeAseo IRepositoriosPersonalDeAseo.GetPersonalDeAseo(int idPersonalDeAseo){
            var personalDeAseoEncontrado = _appContext.personal_de_aseo.FirstOrDefault(p => p.id == idPersonalDeAseo);
            return personalDeAseoEncontrado;
        }
        //AddPersonalDeAseo
        PersonalDeAseo IRepositoriosPersonalDeAseo.AddPersonalDeAseo(PersonalDeAseo personalDeAseo){
            var personalDeAseoAdicionado = _appContext.personal_de_aseo.Add(personalDeAseo);
            _appContext.SaveChanges();
            return personalDeAseoAdicionado.Entity;
        }
        //UpdatePersonalDeAseo
        PersonalDeAseo IRepositoriosPersonalDeAseo.UpdatePersonalDeAseo(PersonalDeAseo personalDeAseo){
            var personalDeAseoEncontrado = _appContext.personal_de_aseo.FirstOrDefault(p => p.id == personalDeAseo.id);
            if(personalDeAseoEncontrado != null){
                personalDeAseoEncontrado.nombre = personalDeAseo.nombre;
                personalDeAseoEncontrado.id = personalDeAseo.id;
                personalDeAseoEncontrado.apellido = personalDeAseo.apellido;
                personalDeAseoEncontrado.edad = personalDeAseo.edad;
                personalDeAseoEncontrado.estadoCovid = personalDeAseo.estadoCovid;
                personalDeAseoEncontrado.turno = personalDeAseo.turno;
                personalDeAseoEncontrado.unidadServicio = personalDeAseo.unidadServicio;
                _appContext.SaveChanges();
            }
            return personalDeAseoEncontrado;
        }
        void IRepositoriosPersonalDeAseo.DeletePersonalDeAseo(int idPersonalDeAseo){
            var personalDeAseoEncontrado = _appContext.personal_de_aseo.FirstOrDefault(p=>p.id==idPersonalDeAseo);
            if(personalDeAseoEncontrado == null){
                return;
            }
            _appContext.personal_de_aseo.Remove(personalDeAseoEncontrado);
            _appContext.SaveChanges();
        }

    }

}