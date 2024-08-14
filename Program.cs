using System.Security.Cryptography;

namespace DiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunProgram();
        }


        static void RunProgram()
        {
            
            bool isRunning = true;

            while (isRunning)
            {
                
                Console.WriteLine("Welcome to the dice game.");
                Console.WriteLine("How many sides does your dice have?");
                
                string? diceSides = Console.ReadLine();
                int cleanDiceSides;

                while (!int.TryParse(diceSides, out cleanDiceSides)) // Check for valid input
                {
                    Console.WriteLine("Please enter a numerical value");
                    diceSides = Console.ReadLine();
                }

                Dice dice = new Dice().ChangeDefaultDiceSize(cleanDiceSides);
                


                Console.WriteLine("Please enter the amount of dice you wish to throw.");

                string? diceAmount = Console.ReadLine();
                int cleanDiceAmount;
            
                while (!int.TryParse(diceAmount, out cleanDiceAmount)) // Check for valid input
                {
                    Console.WriteLine("Please enter a numerical value");
                    diceAmount = Console.ReadLine();
                }

                int[] diceStrokes = new int[cleanDiceAmount];
                int diceStrokesArrayLength = diceStrokes.Length;
                int attemptsCounter = 0;
                int sixesCounter = 0;
                bool onlySixesInArray = false;
                int target = dice.Sides;


                Console.WriteLine("\nRolling Dice.\n");

                  
                while (!onlySixesInArray)
                {
                    for (int i = 0; i < diceStrokesArrayLength; i++)
                    {
                        diceStrokes[i] = dice.Roll();
                        attemptsCounter++;
                        
                        if (diceStrokes[i] == target)
                        {
                            sixesCounter++;
                        }
                        if (sixesCounter == diceStrokesArrayLength)
                        {
                            onlySixesInArray = true;
                        }
                        //Console.Write($"\rCurrently rolling attempt {attemptsCounter}, with {cleanDiceAmount} dice.");
                    }

                    sixesCounter = 0;
                }

                Console.WriteLine($"It took {attemptsCounter} attempts to hit only sixes with {cleanDiceAmount} dice.\n");
                Console.WriteLine("To continue press any key, or to end the program press x.");

                if(Console.ReadLine() == "x")
                {
                    isRunning = false;
                }
            }

        }
    }
}
