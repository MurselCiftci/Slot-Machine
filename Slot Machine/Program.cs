using System;
using System.Collections.Generic;

namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warning, seek medical help from a psychologist when becoming addicted to gambling.");

            /*
            var slotMachineNumbers = new int[3, 3, 10]
            {
                {
                   {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                   {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                   {0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
                },
                {
                    { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                   { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                   { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
                },
                {
                    { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                   { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                   { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
                }
            };
            */

            Random rand = new Random();

            var firstRowList = new List<int>();
            firstRowList.Add(rand.Next(0, 9));
            firstRowList.Add(rand.Next(0, 9));
            firstRowList.Add(rand.Next(0, 9));

            var secondRowList = new List<int>();
            secondRowList.Add(rand.Next(0, 9));
            secondRowList.Add(rand.Next(0, 9));
            secondRowList.Add(rand.Next(0, 9));

            var thirdRowList = new List<int>();
            thirdRowList.Add(rand.Next(0, 9));
            thirdRowList.Add(rand.Next(0, 9));
            thirdRowList.Add(rand.Next(0, 9));

            Console.WriteLine(string.Join(" ", firstRowList));
            Console.WriteLine(string.Join(" ", secondRowList));
            Console.WriteLine(string.Join(" ", thirdRowList));











            // Console.WriteLine(slotMachineNumbers[0, 0, 1]);

            // Console.WriteLine(slotMachineNumbers[0 , 0, rand.Next(slotMachineNumbers.GetLength(0))]);

            // int firstRow = slotMachineNumbers[rand.Next(slotMachineNumbers.GetLength(0)), rand.Next(slotMachineNumbers.GetLength(1)), rand.Next(slotMachineNumbers.GetLength(2))];


            /*
            for (int i = 0; i < slotMachineNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < slotMachineNumbers.GetLength(1); j++)
                {
                    
                    Console.WriteLine(slotMachineNumbers[i, j, rand.Next(0, 9)]);
                }
                
            }
            */



            /*
            for (int i = 0; i < slotMachineNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < slotMachineNumbers.GetLength(1); j++)
                {
                    for (int k = 0; k < slotMachineNumbers.GetLength(2); k++)
                    {
                        int firstRow = rand.Next(0, slotMachineNumbers.Length);
                        
                        Console.WriteLine(slotMachineNumbers[i, j, k] + " ");

                    }
                    Console.WriteLine();
                }
                
            }
            */

        }
    }
}
