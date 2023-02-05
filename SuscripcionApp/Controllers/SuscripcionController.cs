using Microsoft.AspNetCore.Mvc;
using SuscripcionApp.Models;
using SuscripcionApp.ViewModels;

namespace SuscripcionApp.Controllers
{
    public class SuscripcionController : Controller
    {
        public IActionResult Index()
        {
            var tiposDocumentos = TipoDocumento.ListaDocumentos();

            var model = new CreateSuscripcionModel()
            {
                TiposDocumentos = tiposDocumentos
            };
            return View(model);
        }
    }
}
