﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    public class KannNichtFliegen : FlugFaehigkeit {
        public void fliegen() {
            Console.WriteLine("Ente fliegt nicht");
        }
    }
}
