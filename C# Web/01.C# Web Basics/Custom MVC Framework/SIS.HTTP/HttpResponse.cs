namespace SIS.HTTP
{
    using System.Collections.Generic;
    using System.Text;

    public class HttpResponse
    {
        public HttpResponse(HttpResponseCode statusCode, byte[] body)
            : this()
        {
            this.Version = HttpVersionType.Http10;
            this.StatusCode = statusCode;
            this.Body = body;

            if (this.Body?.Length > 0)
            {
                this.Headers.Add(new Header("Content-Length", body.Length.ToString()));
            }
        }

        internal HttpResponse()
        {
            this.Headers = new List<Header>();
            this.Cookies = new List<ResponseCookie>();
        }


        public HttpVersionType Version { get; set; }

        public HttpResponseCode StatusCode { get; set; }

        public ICollection<Header> Headers { get; set; }

        public ICollection<ResponseCookie> Cookies { get; set; }

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

            foreach (var cookie in this.Cookies)
            {
                response.Append("Set-Cookie: " + cookie.ToString() + HttpConstants.NewLine);
            }

            response.Append(HttpConstants.NewLine);

            return response.ToString();
        }
    }
}
