using Microsoft.AspNetCore.Mvc;

namespace FormacaoDoZeroHtmlCss.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Curriculo()
        {
            return View();
        }
    }
}
