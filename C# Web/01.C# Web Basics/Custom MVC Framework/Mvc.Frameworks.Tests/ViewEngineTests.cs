using SIS.MvcFramework.ViewEngine;
using System;
using System.Collections.Generic;
using System.IO;
using Xunit;

namespace Mvc.Frameworks.Tests
{
    public class ViewEngineTests
    {
        [Theory]
        [InlineData("Clean")]
        [InlineData("Foreach")]
        [InlineData("ViewModel")]
        [InlineData("IfElseFor")]
        public void TestHtml(string fileName)
        {
            var viewModel = new TestViewModel()
            {
                Name = "First test view model",
                Value = "The good view model",
                Numbers = new List<int>()
                {
                    1, 2, 3, 4, 5
                }
            };

            IViewEngine engine = new SusViewEngine();
            var view = File.ReadAllText($"Tests/{fileName}.Actual.html");
            var result = engine.GetHtml(view, viewModel);
            var expected = File.ReadAllText($"Tests/{fileName}.Expected.html");

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestTemplateViewModel()
        {
            IViewEngine engine = new SusViewEngine();
            var actual = engine.GetHtml(@"@foreach (var num in Model)
{
<span>@num</span>
}", new List<int> { 1, 2, 3, 4 });

            var expected = @"<span>1</span>
<span>2</span>
<span>3</span>
<span>4</span>
";
            Assert.Equal(expected, actual);
        }
    }
}
