namespace App
{
    using SIS.HTTP;
    using SIS.HTTP.Response;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static async Task Main()
        {
            var http = new HttpServer(80);
            http.AddRoute(HttpMethodType.Get, "/", Index);
            http.AddRoute(HttpMethodType.Get, "/favicon.ico", Favicon);
            http.AddRoute(HttpMethodType.Get, "/login", Login);
            http.AddRoute(HttpMethodType.Get, "/register", Register);

            await http.StartAsync();
        }

        public static HttpResponse Favicon(HttpRequest request)
        {
            var favicon = File.ReadAllBytes("www.root/favicon.ico");
            return new FileResponse(favicon, "image/x-icon");
        }

        public static HttpResponse Index(HttpRequest request)
        {
            return new HtmlResponse("<h1>Home Page</h1>");
        }

        public static HttpResponse Register(HttpRequest request)
        {
            return new HtmlResponse("<h1>Register Page</h1>");
        }

        public static HttpResponse Login(HttpRequest request)
        {
            return new HtmlResponse("<h1>Login Page</h1>");
        }
    }
}
