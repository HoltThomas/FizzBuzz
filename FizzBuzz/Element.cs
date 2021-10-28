using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Element
    {
        public int id;
        public uint value;

        public void AddToList(List<string> strList, string stringValue)
        {
            strList.Add(stringValue);
        }
    }
}
