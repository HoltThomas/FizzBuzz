using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Functions
    {
        List<Buzz> listOfBuzz = new List<Buzz>();
        List<Fizz> listOfFizz = new List<Fizz>();
        List<FizzBuzz> listOfFizzBuzz = new List<FizzBuzz>();

        public uint RequestTotal()
        {
            string totalStr;
            uint totalUInt;

            Console.WriteLine("===================");
            Console.WriteLine("     FIZZ BUZZ     ");
            Console.WriteLine("===================");

            Console.Write("Please enter a positive whole number: ");
            totalStr = Console.ReadLine();
            return totalUInt = uint.Parse(totalStr);
        }

        public void PopulateTheArray(List<uint> numList, uint total)
        {
            for (uint num = 0; num < total; num++)
            {
                numList.Add(num + 1);
            }
        }

        public void CheckFizzBuzz(List<uint> numList, List<string> listOfStrings)
        {
            int total = numList.Count;

            for (int i = 0; i < total; i++)
            {
                var isThisFizzBuzz = numList[i] % 15 == 0;
                var isThisBuzz = numList[i] % 5 == 0;
                var isThisFizz = numList[i] % 3 == 0;

                if (isThisFizzBuzz)
                {
                    FizzBuzz fizzBuzzElement = new FizzBuzz(i, numList[i]);
                    listOfFizzBuzz.Add(fizzBuzzElement);
                    fizzBuzzElement.AddToList(listOfStrings, fizzBuzzElement.stringValue);
                }
                else if (isThisBuzz)
                {
                    Buzz buzzElement = new Buzz(i, numList[i]);
                    listOfBuzz.Add(buzzElement);
                    buzzElement.AddToList(listOfStrings, buzzElement.stringValue);
                }
                else if (isThisFizz)
                {
                    Fizz fizzElement = new Fizz(i, numList[i]);
                    listOfFizz.Add(fizzElement);
                    fizzElement.AddToList(listOfStrings, fizzElement.stringValue);
                }
                else
                {
                    listOfStrings.Add(numList[i].ToString());
                }
            }
        }

        public void DisplayConvertedList(List<string> strNumbers)
        {
            int total = strNumbers.Count;

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, strNumbers[i]);
            }
        }
    }
}
