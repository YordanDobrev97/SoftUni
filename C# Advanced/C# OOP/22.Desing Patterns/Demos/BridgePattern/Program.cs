using System;

namespace BridgePattern
{
    public interface ICoder
    {
        public string Text();
    }

    public class GeneratorCoder : ICoder
    {
        private ICoder coder;

        public GeneratorCoder(ICoder coder)
        {
            this.coder = coder;
        }

        public string Text()
        {
            return coder.Text();
        }
    }

    public class CSharpCode : ICoder
    {
        public string Text()
        {
            return "Console.WriteLine(\"Hello, C#!\");";
        }
    }

    public class JavaScriptCode : ICoder
    {
        public string Text()
        {
            return "console.log(\"Hello, JavaScript!\");";
        }
    }

    class Program
    {
        static void Main()
        {
            GeneratorCoder cSharpCode = new GeneratorCoder(new CSharpCode());
            GeneratorCoder jsCode = new GeneratorCoder(new JavaScriptCode());
            
            Console.WriteLine($"C# Hello World code: ");

            Console.WriteLine();
            Console.WriteLine(cSharpCode.Text());

            Console.WriteLine();
            Console.WriteLine("--------------------------");
            Console.WriteLine();

            Console.WriteLine("JavaScript Hello World code:");

            Console.WriteLine();
            Console.WriteLine(jsCode.Text());
        }
    }
}
