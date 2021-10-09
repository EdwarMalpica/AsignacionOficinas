using System.Collections.Generic;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;


namespace Ofi.App.Persistencia
{
    
public interface IRepositorioSecretaria
{
    //GetAllSecretaria

    IEnumerable <Secretaria> GetAllSecretarias();

    //GetSecretaria
    Secretaria GetSecretaria(int idSecretaria);

    //AddSecretaria
    Secretaria AddSecretaria(Secretaria secretaria);

    //UpdateSecretaria
    Secretaria UpdateSecretaria(Secretaria secretaria);

    //DeleteSecretaria
    void DeleteSecretaria(int idSecretaria);



}
}