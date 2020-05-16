using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace HttpRequester
{
    public class StartUp
    {
        public static void Main()
        {
            string NewLine = "\r\n";
            TcpListener listener = new TcpListener(IPAddress.Loopback, 3000);
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                NetworkStream stream = client.GetStream();

                byte[] data = new byte[4096];
                int countReadBytes = stream.Read(data, 0, data.Length);
                string request = Encoding.UTF8.GetString(data, 0, countReadBytes);

                string responseText = "<h1>Hello</h1>";
                string response = "HTTP/1.0 200 OK" + NewLine +
                                  "Server: MyServer" + NewLine +
                                  "Content-Type: text/html" + NewLine + 
                                  "Content-Length: " + responseText.Length + NewLine + NewLine + 
                                  responseText;

                byte[] bytesData = Encoding.UTF8.GetBytes(response);

                stream.Write(bytesData, 0, bytesData.Length);
                Console.WriteLine(request);

                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
