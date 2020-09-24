﻿namespace SIS.HTTP
{
    using System.Collections.Generic;
    using System.Text;

    public class HttpResponse
    {
        public HttpResponse(HttpResponseCode statusCode, byte[] body)
        {
            this.Version = HttpVersionType.Http10;
            this.StatusCode = statusCode;
            this.Headers = new List<Header>();
            this.Body = body;

            if (this.Body?.Length > 0)
            {
                this.Headers.Add(new Header("Content-Length", body.Length.ToString()));
            }
        }

        public HttpVersionType Version { get; set; }

        public HttpResponseCode StatusCode { get; set; }

        public ICollection<Header> Headers { get; set; }

        public byte[] Body { get; set; }

        public override string ToString()
        {
            StringBuilder response = new StringBuilder();
            var httpVersion = this.Version switch
            {
                HttpVersionType.Http10 => "HTTP/1.0",
                HttpVersionType.Http11 => "HTTP/1.1",
                HttpVersionType.Http20 => "HTTP/2.0",
                _ => "HTTP/1.1"
            };

            response.Append($"{httpVersion} {(int)this.StatusCode}" + HttpConstants.NewLine);

            foreach (var header in this.Headers)
            {
                response.Append(header.ToString() + HttpConstants.NewLine);
            }

            response.Append(HttpConstants.NewLine);

            return response.ToString();
        }
    }
}
