using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coding_Test
{
    public class Three
    {
        public int id { get; set; }
        public int category { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        public string footer { get; set; }

        public List<Item> items { get; set; }

        public string createdAt { get; set; }
    }

    public class Item
    {
        public int id { get; set; }
        public int category { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string footer { get; set; }
        public string createdAt { get; set; }

    }
}
