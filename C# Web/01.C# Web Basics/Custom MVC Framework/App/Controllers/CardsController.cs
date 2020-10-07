using SIS.HTTP;
using SIS.MvcFramework;

namespace App.Controllers
{
    public class CardsController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {
            return this.View();
        }
    }
}
