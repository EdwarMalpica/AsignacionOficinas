using Ofi.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ofi.App.Persistencia
{
    public class RepositorioSecretariosDeDespacho : IRepositorioSecretariosDeDespacho
    {
        private readonly AppContext _appContext;

        public RepositorioSecretariosDeDespacho(AppContext appContext)
        {
            _appContext = appContext;
        }

        //CRUD
        //GetAllSecretarios_de_despachos
        IEnumerable<SecretariosDeDespacho> IRepositorioSecretariosDeDespacho.GetAllSecretariosDeDespacho()
        {
            return _appContext.secretarios_de_despacho;
        }
        //GetSecretarios_de_despacho
        SecretariosDeDespacho IRepositorioSecretariosDeDespacho.GetSecretariosDeDespacho(int idSecretariosDeDespacho)
        {
            var secretarios_de_despachoEncontrado = _appContext.secretarios_de_despacho.FirstOrDefault(p => p.id==idSecretariosDeDespacho);
            return secretarios_de_despachoEncontrado;
        }
        //AddSecretarios_de_despacho
        SecretariosDeDespacho IRepositorioSecretariosDeDespacho.AddSecretariosDeDespacho(SecretariosDeDespacho secretarios_de_despacho)
        {
            var secretarios_de_despachoAdicionado = _appContext.secretarios_de_despacho.Add(secretarios_de_despacho);
            _appContext.SaveChanges();
            return secretarios_de_despachoAdicionado.Entity;
        }
        //UpdateSecretarios_de_despacho
        SecretariosDeDespacho IRepositorioSecretariosDeDespacho.UpdateSecretariosDeDespacho(SecretariosDeDespacho secretarios_de_despacho)
        {
            var secretarios_de_despachoEncontrado = _appContext.secretarios_de_despacho.FirstOrDefault(p => p.id==secretarios_de_despacho.id);
            if (secretarios_de_despachoEncontrado != null)
            {
                secretarios_de_despachoEncontrado.nombre = secretarios_de_despacho.nombre;
                secretarios_de_despachoEncontrado.apellido = secretarios_de_despacho.apellido;
                secretarios_de_despachoEncontrado.edad = secretarios_de_despacho.edad;
                secretarios_de_despachoEncontrado.estadoCovid = secretarios_de_despacho.estadoCovid;
               // secretarios_de_despachoEncontrado.aforoMaximo = secretarios_de_despacho.aforoMaximo;
               
               

                _appContext.SaveChanges();
            }
            return secretarios_de_despachoEncontrado;
        }
        //DeleteSecretarios_de_despacho
        bool IRepositorioSecretariosDeDespacho.DeleteSecretariosDeDespacho(int idSecretariosDeDespacho)
        {
            var secretarios_de_despachoEncontrado = _appContext.secretarios_de_despacho.FirstOrDefault(p=>p.id==idSecretariosDeDespacho);
            if (secretarios_de_despachoEncontrado == null)
                return false;
            _appContext.secretarios_de_despacho.Remove(secretarios_de_despachoEncontrado);
            _appContext.SaveChanges();
            return true;
        }
    }
}
