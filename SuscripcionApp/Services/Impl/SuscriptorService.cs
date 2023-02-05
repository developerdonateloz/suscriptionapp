using SuscripcionApp.Models;
using SuscripcionApp.NewFolder;

namespace SuscripcionApp.Services.Impl
{
    public class SuscriptorService : ISuscriptorService
    {
        private readonly DataContext _context;
        public SuscriptorService(DataContext context)
        {
            _context = context;
        }

        public bool RegistrarSuscriptor(Suscriptor suscriptor)
        {
            throw new NotImplementedException();
        }

        public bool ModificarSuscriptor(Suscriptor suscriptor)
        {
            throw new NotImplementedException();
        }

        public List<Suscriptor> GetListSuscriptores()
        {
            var lista = _context.Suscriptores.ToList();
            return lista;

        }

        public Suscriptor GetSuscriptorByTipoNumeroDocumento(int tipoDocumento, string numeroDocumento)
        {
            var s = _context.Suscriptores
                .Where(q => q.IdTipoDocumento == tipoDocumento && q.NumeroDocumento == numeroDocumento)
                .FirstOrDefault();
            return s;

        }
    }
}
