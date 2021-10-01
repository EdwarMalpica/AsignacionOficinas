using System.Collections.Generic;
using Ofi.App.Dominio;
using System.Linq;


namespace Ofi.App.Persistencia
{
    public class RepositorioSecretaria : IRepositorioSecretaria
    {

            private readonly AppContext _appContext;

            public RepositorioSecretaria (AppContext appContext)
            {

                _appContext=appContext;
        

            }


            //GetAllSecretarias
            IEnumerable<Secretaria> IRepositorioSecretaria.GetAllSecretarias()
            {

                return _appContext.secretarias;
            
            }

            //GetSecretaria

            Secretaria IRepositorioSecretaria.GetSecretaria(int idSecretaria)
            {
                var SecretariaEncontrada = _appContext.secretarias.FirstOrDefault(g=>g.id==idSecretaria);
                return SecretariaEncontrada;

            }

            //AddSecretaria
            Secretaria IRepositorioSecretaria.AddSecretaria(Secretaria secretaria )
            {
            var SecretariaAdicionada = _appContext.secretarias.Add(secretaria);
            _appContext.SaveChanges();
            return SecretariaAdicionada.Entity;
            }


            //DeleteSecretaria
            void IRepositorioSecretaria.DeleteSecretaria (int idSecretaria)
            {
                var SecretariaEncontrada =_appContext.secretarias.FirstOrDefault(g=>g.id==idSecretaria);
                if(SecretariaEncontrada==null)
                        return;
                _appContext.secretarias.Remove(SecretariaEncontrada);
                _appContext.SaveChanges();



            }


    }


    
}