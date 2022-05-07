using System;
using System.Collections.Generic;

namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warning, seek medical help from a psychologist when becoming addicted to gambling.");

            Random rand = new Random();

            List<List<int>> gameGrid = new List<List<int>>();

            gameGrid.Add(firstRowList);
            gameGrid.Add(secondRowList);
            gameGrid[0][0] = 5;

            var thirdRowList = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                gameGrid[0].Add(rand.Next(0, 9));
            }

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
            //var slotMachineNumbers = new int[3, 3]
            //{
            //    {0,0,0},
            //    {
            //        0,0,0
            //    },
            //    {
            //        0,0,0
            //    },
            //};

            //slotMachineNumbers[0,0] =


            /* old
            var firstRowList = new List<int>();
            firstRowList.Add(rand.Next(0, 9));
            firstRowList.Add(rand.Next(0, 9));
            firstRowList.Add(rand.Next(0, 9));
            firstRowList.Add(5);
            */

            /* old
            var secondRowList = new List<int>();
            secondRowList.Add(rand.Next(0, 9));
            secondRowList.Add(rand.Next(0, 9));
            secondRowList.Add(rand.Next(0, 9));
            */


            /*
            thirdRowList.Add(rand.Next(0, 9));
            thirdRowList.Add(rand.Next(0, 9));
            thirdRowList.Add(rand.Next(0, 9));
            */


            Console.WriteLine(string.Join(" ", firstRowList));
            Console.WriteLine(string.Join(" ", secondRowList));
            Console.WriteLine(string.Join(" ", thirdRowList));




            /*
            bool checkHorizontalLines()
            {
                if (firstRowList[0] == firstRowList[1] && firstRowList[1] == firstRowList[2])
                {
                    bool firstRowListMatches = true;
                    return firstRowListMatches;
                }
                if (secondRowList[0] == secondRowList[1] && secondRowList[1] == secondRowList[2])
                {
                    bool secondRowListMatches = true;
                    return secondRowListMatches;
                }
                if (thirdRowList[0] == thirdRowList[1] && thirdRowList[1] == thirdRowList[2])
                {
                    bool thirdRowListMatches = true;
                    return thirdRowListMatches;
                }
                else
                {
                    Console.WriteLine("No luck this time around!");
                    return false;
                }
            }
            */





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
