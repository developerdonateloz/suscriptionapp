namespace SuscripcionApp.Models
{
    public class TipoDocumento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        public static List<TipoDocumento> ListaDocumentos()
        {
            var list= new List<TipoDocumento>();
            list.Add(new TipoDocumento(){Id = 0,Tipo = "Ninguno"});
            list.Add(new TipoDocumento(){Id = 1,Tipo = "DNI"});
            list.Add(new TipoDocumento(){Id = 2,Tipo = "Pasaporte"});
            return list;
        }
    }
}
