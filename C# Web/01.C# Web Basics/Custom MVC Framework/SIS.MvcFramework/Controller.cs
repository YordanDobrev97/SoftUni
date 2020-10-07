using SIS.HTTP;
using SIS.HTTP.Response;
using System.IO;
using System.Runtime.CompilerServices;

namespace SIS.MvcFramework
{
    public abstract class Controller
    {
        public HttpResponse View([CallerMemberName]string path = null)
        {
            var layout = File.ReadAllText("Views/Shared/_Layout.cshtml");
            var fullPath = $"Views/{this.GetType().Name.Replace("Controller", string.Empty)}/{path}.cshtml";

            var html = File.
                ReadAllText(fullPath);

            layout = layout.Replace("@RenderBody()", html);

            return new HtmlResponse(layout);
        }

        public HttpResponse Favicon()
        {
            var favicon = File.ReadAllBytes("www.root/favicon.ico");
            return new FileResponse(favicon, "image/x-icon");
        }
    }
}
