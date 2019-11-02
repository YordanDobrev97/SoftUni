﻿using System;
namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age) 
            : base(name, age)
        {

        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
