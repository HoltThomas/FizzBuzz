using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz : Element
    {
        public string stringValue = "Fizz Buzz";

        public FizzBuzz(int newID, uint newValue)
        {
            id = newID;
            value = newValue;
        }
    }
}
