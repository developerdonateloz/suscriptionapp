using SuscripcionApp.Models;

namespace SuscripcionApp.NewFolder
{
    public interface ISuscriptorService
    {
        bool RegistrarSuscriptor(Suscriptor suscriptor);
        bool ModificarSuscriptor(Suscriptor suscriptor);
        List<Suscriptor> GetListSuscriptores();
        Suscriptor GetSuscriptorByTipoNumeroDocumento(int tipoDocumento, string numeroDocumento);
    }
}
