using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace SIS.MvcFramework.ViewEngine
{
    public class SusViewEngine : IViewEngine
    {
        public string GetHtml(string template, object viewModel)
        {
            string csharpCode = GenerateCSharpFromTemplate(template, viewModel);
            IView executable = GenerateExecutableCode(csharpCode, viewModel);
            string html = executable.GetHtml(viewModel);

            return html;
        }

        private IView GenerateExecutableCode(string csharpCode, object viewModel)
        {
            //create runtime dll with references
            var result = CSharpCompilation.Create("View")
                .WithOptions(new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary))
                .AddReferences(MetadataReference.CreateFromFile(typeof(object).
                        Assembly.Location))
                .AddReferences(MetadataReference.CreateFromFile(typeof(IView)
                        .Assembly.Location));

            if (viewModel != null)
            {
                result = result.AddReferences(MetadataReference.CreateFromFile(viewModel.GetType().Assembly.Location));
            }

            //get all libraries from netstandard
            var libraries = Assembly.Load("netstandard").GetReferencedAssemblies();

            //load each library to dll assembly
            foreach (var library in libraries)
            {
                result = result.AddReferences(MetadataReference.
                    CreateFromFile(Assembly.Load(library).Location));
            }

            //add our csharpcode to dll assembly
            result = result.AddSyntaxTrees(SyntaxFactory.ParseSyntaxTree(csharpCode));

            using (var memoryStream = new MemoryStream())
            {
                EmitResult compileResult = result.Emit(memoryStream);

                if (!compileResult.Success)
                {
                    return new ErrorView(compileResult.Diagnostics.
                        Where(x => x.Severity == DiagnosticSeverity.Error)
                        .Select(x => x.GetMessage()), csharpCode);
                }

                memoryStream.Seek(0, SeekOrigin.Begin);
                byte[] byteAssembly = memoryStream.ToArray();
                var assembly = Assembly.Load(byteAssembly);
                var viewType = assembly.GetType("ViewNamespace.ViewClass");
                IView instance = Activator.CreateInstance(viewType) as IView;
                return instance;
            }
            
        }

        private string GenerateCSharpFromTemplate(string template, object viewModel)
        {
            var typeModel = "object";

            if (viewModel != null)
            {
                if (viewModel.GetType().IsGenericType)
                {
                    var modelName = viewModel.GetType().FullName;
                    var genericArgs = viewModel.GetType().GenericTypeArguments;

                    typeModel = modelName.Substring(0, modelName.IndexOf('`')) + "<"
                        + string.Join(",", genericArgs.Select(x => x.FullName)) + ">";

                }
                else
                {
                    viewModel = viewModel.GetType().FullName;
                }
            }
            string methodBody = GetMethodBody(template);
            var csharpCode = @"
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using SIS.MvcFramework.ViewEngine;

namespace ViewNamespace
{
    public class ViewClass : IView
    {
        public string GetHtml(object viewModel)
        {
            var Model = viewModel as " + typeModel + @";
            StringBuilder sb = new StringBuilder();
            
            " + methodBody + @"

            return sb.ToString();
        }
    }
}"
;


            return csharpCode;
        }

        private string GetMethodBody(string template)
        {
            Regex csharpCodeRegex = new Regex(@"[^\""\s&\'\<]+");
            List<string> supportedOperators = new List<string>()
            {
                "for", "while", "if", "else", "foreach"
            };

            StringBuilder body = new StringBuilder();
            StringReader reader = new StringReader(template);

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (supportedOperators.Any(x => line.TrimStart().StartsWith("@" + x)))
                {
                    int index = line.IndexOf("@");
                    line = line.Remove(index, 1);
                    body.AppendLine(line);
                }
                else if (line.TrimStart().StartsWith("{") || line.TrimStart().StartsWith("}"))
                {
                    body.AppendLine(line);
                }
                else
                {
                    body.Append($"sb.AppendLine(@\"");

                    while (line.Contains("@"))
                    {
                        int index = line.IndexOf("@");
                        string beforeIndex = line.Substring(0, index);
                        body.Append(beforeIndex + "\" + ");

                        var afterSign = line.Substring(index + 1);
                        var code = csharpCodeRegex.Match(afterSign).Value;
                        body.Append(code + " + @\"");
                        line = afterSign.Substring(code.Length);
                    }

                    body.AppendLine(line.Replace("\"", "\"\"") + "\");");
                }
            }

            return body.ToString();
        }
    }
}
