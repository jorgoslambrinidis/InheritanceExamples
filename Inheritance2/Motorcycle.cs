﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance2
{
    public class Motorcycle : Vehicle
    {
        public bool HasSideCar { get; set; }

        public override void Start()
        {
            Console.WriteLine("Starting the motorcycle");
        }
    }
}
