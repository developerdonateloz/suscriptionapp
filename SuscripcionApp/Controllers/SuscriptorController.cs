using Microsoft.AspNetCore.Mvc;
using SuscripcionApp.Models;
using SuscripcionApp.NewFolder;
using SuscripcionApp.ViewModels;

namespace SuscripcionApp.Controllers
{
    public class SuscriptorController : Controller
    {
        private readonly ISuscriptorService _suscriptorService;

        public SuscriptorController(ISuscriptorService suscriptorService)
        {
            _suscriptorService = suscriptorService;
        }
        public IActionResult Index()
        {
            var lista = _suscriptorService.GetListSuscriptores();

            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SuscriptorViewModel suscriptorDto)
        {
            if (!ModelState.IsValid)
            {
                Suscriptor suscriptor = new Suscriptor()
                {
                    Email = suscriptorDto.Email,
                    Nombre = suscriptorDto.Nombre,
                };
                _suscriptorService.RegistrarSuscriptor(suscriptor);

                return View("Index");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult GetByTipoNumeroDocumento([FromBody] SearchSuscriptorParameters parameters)
        {
            
            
            var tipoDocumento = int.Parse(parameters.TipoDocumento);
            var numeroDocumento = parameters.NumeroDocumento;

            var s = _suscriptorService.GetSuscriptorByTipoNumeroDocumento(tipoDocumento, numeroDocumento);

            if (s == null)
            {
                return NotFound();
            }

            return Ok(s);
        }
    }
}
