using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class IdentificatorFactory
    {
        public IIdentifiable Create(TypeIdentificator identifiable,  params string[] items)
        {
            switch (identifiable)
            {
                case TypeIdentificator.Citizen:
                    return new Citizen(items[0], int.Parse(items[1]), items[2]);
                case TypeIdentificator.Robot:
                    return new Robot(items[0], items[1]);
                default:
                    throw new ArgumentException("Invalid creation");
            }
        }
    }
}
