using Microsoft.AspNetCore.Mvc;

namespace CadastroDeContato.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
