﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeACake
{
    //Represents a product created by the builder
    public class Cake
    {
        private readonly string cakeType;

        public Cake(string cakeType)
        {
            this.cakeType = cakeType;
        }

        public string CakeBase { get; set; }
        public string Cream { get; set; }

        public void Show()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("{0} with {1} base and {2} cream", this.cakeType, this.CakeBase, this.Cream);
        }
    }
}
