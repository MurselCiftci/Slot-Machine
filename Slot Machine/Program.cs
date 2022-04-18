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



        }
    }
}
