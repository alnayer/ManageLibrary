using LibraryContracts;
using Microsoft.AspNetCore.Mvc;

namespace LibraryUI.Controllers
{
    public class LibroController : Controller
    {
        private readonly ILibroService _servLibro;
        private readonly ILibroInterface _servLibro2;

        public LibroController(ILibroService libroService, ILibroInterface libroInterface)
        {
            _servLibro = libroService;
            _servLibro2 = libroInterface;
        }
        public async Task<IActionResult> Index()
        {
            var myLibros = _servLibro.GetLibros();
            return View(myLibros);
        }
    }
}
