using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;
using System.IO;

namespace App.Controllers
{
    public class AboutController : Controller
    {
        public HttpResponse Index(HttpRequest request)
        {
            return this.View();
        }
    }
}
