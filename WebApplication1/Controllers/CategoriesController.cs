using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index(string id) //Startup kısmında route kısmında ne belirlediysek parantez içerisine o gelecektir.
        {
            string magaza =Request.Query["magaza"];
            return View();
        }
    }
}