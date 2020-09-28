namespace SIS.HTTP
{
    using System;

    public class Route
    {
        public Route(HttpMethodType method, string path, Func<HttpRequest, HttpResponse> action)
        {
            this.Method = method;
            this.Path = path;
            this.Action = action;
        }

        public string Path { get; set; }

        public HttpMethodType Method { get; set; }

        public Func<HttpRequest, HttpResponse> Action { get; set; }
    }
}
