namespace App
{
    using App.Controllers;
    using SIS.HTTP;
    using SIS.HTTP.Response;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.InteropServices;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static async Task Main()
        {
            var http = new HttpServer(80);
            http.AddRoute(HttpMethodType.Get, "/", new HomeController().Index);
            http.AddRoute(HttpMethodType.Get, "/favicon.ico", new StaticFileController().Favicon);
            http.AddRoute(HttpMethodType.Get, "/users/login", new UsersController().Login);
            http.AddRoute(HttpMethodType.Get, "/users/register", new UsersController().Register);

            OpenBrowser("http://localhost/");
            await http.StartAsync();
        }

        public static void OpenBrowser(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
