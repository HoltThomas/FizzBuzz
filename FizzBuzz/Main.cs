using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Main : Functions
    {
        public List<uint> numbers = new List<uint>();
        public List<string> strNumbers = new List<string>();
        public uint total = 0;

        public void StartProgram()
        {
            total = RequestTotal();
            PopulateTheArray(numbers, total);
            CheckFizzBuzz(numbers, strNumbers);
            DisplayConvertedList(strNumbers);
        }
    }
}
