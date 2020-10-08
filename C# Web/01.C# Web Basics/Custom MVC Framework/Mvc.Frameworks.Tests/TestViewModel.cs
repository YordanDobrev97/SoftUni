using System.Collections.Generic;

namespace Mvc.Frameworks.Tests
{
    public class TestViewModel
    {
        public string Name { get; set; }

        public string Value { get; set; }

        public ICollection<int> Numbers { get; set; }
    }
}
