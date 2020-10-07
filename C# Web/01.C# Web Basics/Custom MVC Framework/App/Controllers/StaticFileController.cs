using SIS.HTTP;
using SIS.MvcFramework;
using System.IO;

namespace App.Controllers
{
    public class StaticFileController : Controller
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            return this.Favicon();
        }
    }
}
