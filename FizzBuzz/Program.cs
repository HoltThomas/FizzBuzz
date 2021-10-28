using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        static List<uint> numbers = new List<uint>();
        static List<string> strNumbers = new List<string>();
        static uint total = 0;

        static void Main(string[] args)
        {
            total = AskForTotal();
            PopulateArray(numbers, total);
            CheckFizzBuzz(numbers, strNumbers);
            DisplayConvertedList(strNumbers);
        }

        static uint AskForTotal()
        {
            string totalStr;
            uint totalUInt;
            
            Console.Write("Please enter a positive whole number: ");
            totalStr = Console.ReadLine();
            return totalUInt = uint.Parse(totalStr);
        }

        static void PopulateArray(List<uint> list, uint total)
        {
            for(uint i = 0; i < total; i++)
            {
                list.Add(i + 1);
            }
        }

        static void CheckFizzBuzz(List<uint> listToCheck, List<string> listOfStrings)
        {
            int total = listToCheck.Count;

            for(int i = 0; i < total; i++)
            {
                if(listToCheck[i] % 15 == 0)
                {
                    listOfStrings.Add("fizz buzz");
                }
                else if(listToCheck[i] % 5 == 0)
                {
                    listOfStrings.Add("buzz");
                }
                else if(listToCheck[i] % 3 == 0)
                {
                    listOfStrings.Add("fizz");
                }
                else
                {
                    listOfStrings.Add(listToCheck[i].ToString());
                }
            }
        }

        static void DisplayConvertedList(List<string> strNumbers)
        {
            int total = strNumbers.Count;

            for(int i = 0; i < total; i++)
            {
                Console.WriteLine("{0}: {1}", i + 1, strNumbers[i]);
            }
        }
    }
}