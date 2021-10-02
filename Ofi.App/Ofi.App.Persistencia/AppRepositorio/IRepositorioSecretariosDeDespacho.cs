using System.Collections.Generic;
using Ofi.App.Dominio;

namespace Ofi.App.Persistencia
{
    public interface IRepositorioSecretariosDeDespacho
    {
        //CRUD 
        //GetAllSecretariosDeDespachoes
        IEnumerable<SecretariosDeDespacho> GetAllSecretariosDeDespacho();
        //GetSecretariosDeDespacho 
        SecretariosDeDespacho GetSecretariosDeDespacho(int idSecretariosDeDespacho);
        //AddSecretariosDeDespacho
        SecretariosDeDespacho AddSecretariosDeDespacho(SecretariosDeDespacho secretarios_de_despacho);
        //UpdateSecretariosDeDespacho
        SecretariosDeDespacho UpdateSecretariosDeDespacho(SecretariosDeDespacho secretarios_de_despacho);
        //DeleteSecretariosDeDespacho
        bool DeleteSecretariosDeDespacho(int idSecretariosDeDespacho);
    }
}
