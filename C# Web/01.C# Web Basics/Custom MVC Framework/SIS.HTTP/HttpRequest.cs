namespace SIS.HTTP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Web;

    public class HttpRequest
    {
        public HttpRequest(string httpRequestString)
        {
            this.Headers = new List<Header>();
            this.Cookies = new List<Cookie>();

            var lines = httpRequestString.Split(new string[] { HttpConstants.NewLine }, StringSplitOptions.None);

            var httpInfo = lines[0];
            var httpInfoParts = httpInfo.Split();

            if (httpInfoParts.Length != 3)
            {
                throw new HttpServerException("Invalid http header line.");
            }

            var httpMethod = httpInfoParts[0];

            this.HttpMethod = httpMethod switch 
            {
                "GET" => HttpMethodType.Get,
                "POST" => HttpMethodType.Post,
                "PUT" => HttpMethodType.Put,
                "DELETE" => HttpMethodType.Delete,
                _ => HttpMethodType.Unknow
            };

            this.Path = httpInfoParts[1];
            var version = httpInfoParts[2];
            this.Version = version switch
            {
                "HTTP/1.0" => HttpVersionType.Http10,
                "HTTP/1.1" => HttpVersionType.Http11,
                "HTTP/2.0" => HttpVersionType.Http20,
                _ => HttpVersionType.Http11
            };

            bool isInHeader = true;
            StringBuilder bodyBuilder = new StringBuilder();
            for (int i = 1; i < lines.Length; i++)
            {
                var line = lines[i];

                if (string.IsNullOrWhiteSpace(line))
                {
                    isInHeader = false;
                    continue;
                }

                if (isInHeader)
                {
                    var headerParts = line.Split(
                        new string[] {": " }, 2, StringSplitOptions.None);

                    if (headerParts.Length != 2)
                    {
                        throw new HttpServerException("Invalid header");
                    }

                    var header = new Header(headerParts[0], headerParts[1]);
                    this.Headers.Add(header);

                    if (headerParts[0] == "Cookie")
                    {
                        var cookiesAsString = headerParts[1];
                        var cookies = cookiesAsString.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (var cookie in cookies)
                        {
                            var cookieParts = cookie.Split(new char[] { '=' }, 2);

                            if (cookieParts.Length == 2)
                            {
                                this.Cookies.Add(new Cookie(cookieParts[0], cookieParts[1]));
                            }
                        }
                    }
                }
                else
                {
                    bodyBuilder.AppendLine(line);
                }
            }

            this.Body = HttpUtility.UrlDecode(bodyBuilder.ToString().Trim('\r', '\r'));
        }

        public HttpMethodType HttpMethod { get; set; }

        public string Path { get; set; }

        public HttpVersionType Version { get; set; }

        public ICollection<Header> Headers { get; set; }

        public ICollection<Cookie> Cookies { get; set; }

        public string Body { get; set; }
    }
}
