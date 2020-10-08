using SIS.HTTP;
using SIS.HTTP.Response;
using SIS.MvcFramework.ViewEngine;
using System.IO;
using System.Runtime.CompilerServices;

namespace SIS.MvcFramework
{
    public abstract class Controller
    {
        private SusViewEngine viewEngine;

        public Controller()
        {
            this.viewEngine = new SusViewEngine();
        }

        public HttpResponse View(object viewModel = null,
            [CallerMemberName]string path = null)
        {
            var layout = File.ReadAllText("Views/Shared/_Layout.cshtml");
            layout = layout.Replace("@RenderBody()", "_VIEW_ENGINE_");
            layout = this.viewEngine.GetHtml(layout, viewModel);

            var fullPath = $"Views/{this.GetType().Name.Replace("Controller", string.Empty)}/{path}.cshtml";
            
            var html = File.
                ReadAllText(fullPath);

            html = this.viewEngine.GetHtml(html, viewModel);

            layout = layout.Replace("_VIEW_ENGINE_", html);

            return new HtmlResponse(layout);
        }

        public HttpResponse Favicon()
        {
            var favicon = File.ReadAllBytes("www.root/favicon.ico");
            return new FileResponse(favicon, "image/x-icon");
        }
    }
}
