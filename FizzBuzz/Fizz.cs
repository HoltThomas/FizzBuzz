﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Fizz : Element
    {
        public int id;
        public uint value;

        public string stringValue = "Fizz";

        public Fizz(int newID, uint newValue)
        {
            id = newID;
            value = newValue;
        }
    }
}
