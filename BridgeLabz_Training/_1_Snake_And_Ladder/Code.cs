using System;
using System.Collections.Generic;
using System.Threading;
namespace BridgeLabz_Training._1_Snake_And_Ladder
{
    class Code
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Snake and Ladder Game!");
            Console.WriteLine("You are at position 0. Reach 100 to win.\n");

            int position = 0;
            Random random = new Random();

            // Define snakes and ladders
            Dictionary<int, int> snakes = new Dictionary<int, int>()
            {
                { 99, 54 }, { 70, 55 }, { 52, 42 }, { 25, 2 }, { 95, 72 }
            };

            Dictionary<int, int> ladders = new Dictionary<int, int>()
            {
                { 6, 25 }, { 11, 40 }, { 60, 85 }, { 46, 90 }, { 17, 69 }
            };

            while (position < 100)
            {
                Console.WriteLine("\nPress any key to roll the dice...");
                Console.ReadKey();

                int dice = random.Next(1, 7); // Dice generates 1 to 6
                Console.WriteLine($"\n🎲 You rolled a {dice}!");

                if (position + dice <= 100)
                    position += dice;

                Console.WriteLine($"➡ You moved to position {position}");

                // Check for ladders
                if (ladders.ContainsKey(position))
                {
                    Console.WriteLine($"🪜 Wow! You found a ladder at {position}. Climb up to {ladders[position]}!");
                    position = ladders[position];
                }

                // Check for snakes
                else if (snakes.ContainsKey(position))
                {
                    Console.WriteLine($"🐍 Oh no! You got bitten by a snake at {position}. Slide down to {snakes[position]}!");
                    position = snakes[position];
                }

                Console.WriteLine($"📍 Current position: {position}");

                Thread.Sleep(500); // Small delay for readability
            }

            Console.WriteLine("\n🎉 Congratulations! You reached 100 and won the game!");
        }
    }
}