using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}
