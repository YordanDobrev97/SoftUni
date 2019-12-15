using System;

namespace AquaShop.Models.Decorations
{
    public class Ornament : Decoration
    {
        private const int DefaultConfort = 1;
        private const int DefaulPrice = 5;

        public Ornament()
            : base(DefaultConfort, DefaulPrice)
        {
        }
    }
}
