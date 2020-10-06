using SIS.HTTP;
using SIS.MvcFramework;
using System.IO;

namespace App.Controllers
{
    public class StaticFileController : Controller
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            var favicon = File.ReadAllBytes("www.root/favicon.ico");
            return new FileResponse(favicon, "image/x-icon");
        }
    }
}
