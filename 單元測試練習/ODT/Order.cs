﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLab1.ODT
{
    public class Order
    {
        public string Type { get; internal set; }
        public string ProductName { get; internal set; }
        public int Price { get; internal set; }
        public string CustomerName { get; internal set; }
    }
}
