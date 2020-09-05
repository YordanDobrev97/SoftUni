using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public class Plant : Decoration
    {
        private const int DefaultConfort = 5;
        private const int DefaulPrice = 10;

        public Plant() 
            : base(DefaultConfort, DefaulPrice)
        {
        }
    }
}
