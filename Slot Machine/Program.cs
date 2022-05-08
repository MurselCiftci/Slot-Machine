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

            var firstRowList = new List<int>();
            gameGrid.Add(firstRowList);
            for (int i = 0; i < 3; i++)
            {
                gameGrid[0].Add(0);
            }

            var secondRowList = new List<int>();
            gameGrid.Add(secondRowList);
            for (int i = 0; i < 3; i++)
            {
                gameGrid[1].Add(rand.Next(0, 9));
            }


            var thirdRowList = new List<int>();
            gameGrid.Add(thirdRowList);

            for (int i = 0; i < 3; i++)
            {
                gameGrid[2].Add(rand.Next(0, 9));
            }

            /*       
            gameGrid[0][0] = 5;
            */

            Console.WriteLine();
            Console.WriteLine(string.Join(" ", firstRowList));
            Console.WriteLine(string.Join(" ", secondRowList));
            Console.WriteLine(string.Join(" ", thirdRowList));
            
            // here are the if statements for the horizontal lines of the slot machine to check whether they match
            if (gameGrid[0][0] == gameGrid[0][1] && gameGrid[0][1] == gameGrid[0][2])
            {
                Console.WriteLine("Lucky Bastard");
            }

            if (gameGrid[1][0] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[1][2])
            {
                Console.WriteLine("Second line lucky bastard");
            }

            if(gameGrid[2][0] == gameGrid[2][1] && gameGrid[2][1] == gameGrid[2][2])
            {
                Console.WriteLine("Second line lucky bastard");
            }

            // here are the vertical lines of the slot machine to check whether they match
            if (gameGrid[0][0] == gameGrid[1][0] && gameGrid[1][0] == gameGrid[2][0])
            {
                Console.WriteLine("Lucky Bastard");
            }

            if (gameGrid[0][1] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[2][1])
            {
                Console.WriteLine("Second line lucky bastard");
            }

            if (gameGrid[0][2] == gameGrid[1][2] && gameGrid[2][1] == gameGrid[2][2])
            {
                Console.WriteLine("Second line lucky bastard");
            }

            // here are the horizontal lines
            if (gameGrid[0][0] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[2][2])
            {
                Console.WriteLine("Lucky Bastard");
            }

            if (gameGrid[0][2] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[2][0])
            {
                Console.WriteLine("Second line lucky bastard");
            }

            

        }
    }
}
