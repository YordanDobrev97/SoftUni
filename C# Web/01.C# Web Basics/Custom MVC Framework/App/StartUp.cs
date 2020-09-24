namespace App
{
    using SIS.HTTP;
    using System.Threading.Tasks;

    public class StartUp
    {
        public static async Task Main()
        {
            var http = new HttpServer(80);

            await http.StartAsync();
        }
    }
}
