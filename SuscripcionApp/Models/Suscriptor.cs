using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace SuscripcionApp.Models
{
    public class Suscriptor
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Email { get; set; }
        public int IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
    }
}
