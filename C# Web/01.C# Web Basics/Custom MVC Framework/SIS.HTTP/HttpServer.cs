namespace SIS.HTTP
{
    using System;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class HttpServer : IHttpServer
    {
        private readonly TcpListener tcpListener;

        //TODO actions...
        public HttpServer(int port)
        {
            this.tcpListener = new TcpListener(IPAddress.Loopback, port);
        }

        public async Task ResetAsync()
        {
            this.Stop();
            await this.StartAsync();
        }

        public async Task StartAsync()
        {
            this.tcpListener.Start();

            while (true)
            {
                var client = await tcpListener.AcceptTcpClientAsync();
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
                Task.Run(() => ProcessClientAsync(client));
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
            }
        }

        public void Stop()
        {
            this.tcpListener.Stop();
        }

        public async Task ProcessClientAsync(TcpClient client)
        {
            using (var stream = client.GetStream())
            {
                byte[] buffer = new byte[1000000];
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                var lenght = await stream.ReadAsync(buffer, 0, buffer.Length);
                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);

                string requestString =
                    Encoding.UTF8.GetString(buffer, 0, lenght);
                Console.WriteLine(requestString);

                var content = Encoding.UTF8.GetBytes("<h1>Hello, World!");

                var response = new HttpResponse(HttpResponseCode.Ok, content);
                response.Headers.Add(new Header("Server", "NikiServer 2020"));
                response.Headers.Add(new Header("Content-Type", "text/html"));

                byte[] responseBytes = Encoding.UTF8.GetBytes(response.ToString());
                await stream.WriteAsync(response.Body);

                Console.WriteLine(new string('=', 70));
            }
        }
    }
}
