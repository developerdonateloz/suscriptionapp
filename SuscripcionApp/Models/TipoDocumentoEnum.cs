namespace SuscripcionApp.Models
{
    public enum TipoDocumentoEnum
    {
        Ninguno = 0,
        DNI = 1,
        Pasaporte = 2
    }

    public static class TipoDocumentoLabel
    {
        public static string ToLabel(TipoDocumentoEnum tipoDocumentoEnum)
        {
            return tipoDocumentoEnum switch
            {
                TipoDocumentoEnum.Ninguno => "Ninguno",
                TipoDocumentoEnum.DNI => "DNI",
                TipoDocumentoEnum.Pasaporte => "Pasaporte",
                _ => "Desconocido",
            };
        }

    }
}
