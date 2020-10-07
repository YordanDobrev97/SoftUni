using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;

namespace App.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Register(HttpRequest request)
        {
            return this.View();
        }

        public HttpResponse Login(HttpRequest request)
        {
            return this.View();
        }
    }
}
