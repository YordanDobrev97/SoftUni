﻿using System.Collections.Generic;

namespace SpaceStation.Models.Bags
{
    public class Backpack : IBag
    {
        private List<string> items;

        public Backpack()
        {
            this.items = new List<string>();
        }

        public ICollection<string> Items
        {
            get => this.items;
        }
    }
}
