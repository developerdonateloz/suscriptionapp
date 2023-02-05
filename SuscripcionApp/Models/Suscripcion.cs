using System.ComponentModel.DataAnnotations;

namespace SuscripcionApp.Models
{
    public class Suscripcion
    {
        [Key]
        public int Id { get; set; }
        public DateTime FechaSuscripcion { get; set; }
    }
}
