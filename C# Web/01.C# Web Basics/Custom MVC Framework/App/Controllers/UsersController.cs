using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework;

namespace App.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Register(HttpRequest request)
        {
            return new HtmlResponse("<h1>Register Page</h1>");
        }

        public HttpResponse Login(HttpRequest request)
        {
            return new HtmlResponse("<h1>Login Page</h1>");
        }
    }
}
