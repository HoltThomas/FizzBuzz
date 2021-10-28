using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Buzz : Element
    {
        public string stringValue = "Buzz";

        public Buzz(int newID, uint newValue)
        {
            id = newID;
            value = newValue;
        }
    }
}
