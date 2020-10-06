using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {
            return new HtmlResponse("<h1>Home Page</h1>");
        }
    }
}
