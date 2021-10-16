using System.Collections.Generic;
using Ofi.App.Persistencia;
using Ofi.App.Dominio;


namespace Ofi.App.Persistencia
{
    
public interface IRepositorioGobernacion
{
    //GetAllGobernaciones

    IEnumerable <Gobernacion> GetAllGobernaciones();

    //GetGobernacion
    Gobernacion GetGobernacion(int idGobernacion);

    //AddGobernacion
    Gobernacion AddGobernacion(Gobernacion gobernacion);

    //UpdateGobernacion
    Gobernacion UpdateGobernacion(Gobernacion gobernacion);

    //DeleteGobernacion
    Gobernacion DeleteGobernacion(Gobernacion gobernacion);



}





}
