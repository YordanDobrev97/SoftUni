namespace App
{
    using SIS.HTTP;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static async Task Main()
        {
            var routeTable = new List<Route>();
            routeTable.Add(new Route(HttpMethodType.Get, "/", Index));
            routeTable.Add(new Route(HttpMethodType.Get, "/login", Login));
            routeTable.Add(new Route(HttpMethodType.Get, "/register", Register));

            var http = new HttpServer(80, routeTable);

            await http.StartAsync();
        }

        public static HttpResponse Index(HttpRequest request)
        {
            var content = "<h1>Home Page</h1>";
            var byteContent = Encoding.UTF8.GetBytes(content);
            var response = new HttpResponse(HttpResponseCode.Ok, byteContent);
            return response;
        }

        public static HttpResponse Register(HttpRequest request)
        {
            var content = "<h1>Register Page</h1>";
            var byteContent = Encoding.UTF8.GetBytes(content);
            var response = new HttpResponse(HttpResponseCode.Ok, byteContent);
            return response;
        }

        public static HttpResponse Login(HttpRequest request)
        {
            var content = "<h1>Login Page</h1>";
            var byteContent = Encoding.UTF8.GetBytes(content);
            var response = new HttpResponse(HttpResponseCode.Ok, byteContent);
            return response;
        }
    }
}
