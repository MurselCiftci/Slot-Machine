using System;

namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
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

            Random rand = new Random();

            for (int i = 0; i < slotMachineNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < slotMachineNumbers.GetLength(1); j++)
                {
                    for (int k = 0; k < slotMachineNumbers.GetLength(2); k++)
                    {
                        Console.WriteLine(slotMachineNumbers[i, j, k]);
                    }
                }
            }

        }
    }
}
