using System;
using System.Collections.Generic;

namespace Slot_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Warning, seek medical help from a psychologist when becoming addicted to gambling.");

            int gamblerBalance = 5;
            int gambleAmountWon = 0; 

            Console.WriteLine($"Your balance is {gamblerBalance}, for how much do you want to play?");
            int playingAmount = int.Parse(Console.ReadLine());

            Console.WriteLine("How do you want to play the slot machine?");
            Console.WriteLine("For all horizontal lines enter 1");
            Console.WriteLine("For all vertical lines enter 2");
            Console.WriteLine("For all diagonal lines enter 3");
            int playingMethod = int.Parse(Console.ReadLine());



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
                gameGrid[1].Add(0);
            }

            // gameGrid[1].Add(rand.Next(0, 9));


            var thirdRowList = new List<int>();
            gameGrid.Add(thirdRowList);

            for (int i = 0; i < 3; i++)
            {
                gameGrid[2].Add(0);
            }

            /*       
            gameGrid[0][0] = 5;
            */

            Console.WriteLine();
            Console.WriteLine(string.Join(" ", firstRowList));
            Console.WriteLine(string.Join(" ", secondRowList));
            Console.WriteLine(string.Join(" ", thirdRowList));
            
            // here are the if statements for the horizontal lines of the slot machine to check whether they match

            
            if (playingMethod == 1)
            {
                // first row horizontal line check
                if (gameGrid[0][0] == gameGrid[0][1] && gameGrid[0][1] == gameGrid[0][2])
                {
                    Console.WriteLine("Lucky Bastard");
                }

                // second row horizontal line check
                if (gameGrid[1][0] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[1][2])
                {
                    Console.WriteLine("Second line lucky bastard");
                }

                // third row horizontal line check
                if (gameGrid[2][0] == gameGrid[2][1] && gameGrid[2][1] == gameGrid[2][2])
                {
                    Console.WriteLine("Second line lucky bastard");
                }
            }

            // here are the vertical lines of the slot machine to check whether they match
            if (playingMethod == 2)
            {
                // first vertical line check
                if (gameGrid[0][0] == gameGrid[1][0] && gameGrid[1][0] == gameGrid[2][0])
                {
                    Console.WriteLine("Lucky Bastard");
                }

                // second vertical line check
                if (gameGrid[0][1] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[2][1])
                {
                    Console.WriteLine("Second line lucky bastard");
                }

                // third vertical line check
                if (gameGrid[0][2] == gameGrid[1][2] && gameGrid[2][1] == gameGrid[2][2])
                {
                    Console.WriteLine("Second line lucky bastard");
                }
            }

            // here are the horizontal lines
            if (playingMethod == 3)
            {
                // diagonal line check top left to bottom right 
                if (gameGrid[0][0] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[2][2])
                {
                    Console.WriteLine("Lucky Bastard");
                }

                // diagonal line check top right to bottom left
                if (gameGrid[0][2] == gameGrid[1][1] && gameGrid[1][1] == gameGrid[2][0])
                {
                    Console.WriteLine("Second line lucky bastard");
                }
            }

            

        }
    }
}
