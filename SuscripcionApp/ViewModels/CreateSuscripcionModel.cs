using SuscripcionApp.Models;

namespace SuscripcionApp.ViewModels
{
    public class CreateSuscripcionModel
    {
        public List<TipoDocumento> TiposDocumentos { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
    }
}
