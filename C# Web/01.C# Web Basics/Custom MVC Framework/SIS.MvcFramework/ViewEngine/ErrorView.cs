using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Text;

namespace SIS.MvcFramework.ViewEngine
{
    public class ErrorView : IView
    {
        private readonly IEnumerable<string> errors;
        private readonly string csharpCode;
        
        public ErrorView(IEnumerable<string> errors, string csharpCode)
        {
            this.errors = errors;
            this.csharpCode = csharpCode;
        }

        public string GetHtml(object viewModel)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("<h1>Errors:</h1>");

            foreach (var err in errors)
            {
                sb.AppendLine($"<p>{err}</p>");
            }

            sb.AppendLine(csharpCode);

            return sb.ToString();
        }
    }
}
