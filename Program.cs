using System;

namespace numberGuesser{
    class numberGuesser{
        static void Main(string[] args){
            
            // Game Introduction Display  
            Console.WriteLine("");
            Console.WriteLine("-- NUMBER GUESSER GAME --");
            Console.WriteLine("");
            Console.WriteLine("How to Play?");
            Console.WriteLine("1. Guess a number between 1 to 100.");
            Console.WriteLine("2. The program will tell you if the number is greater or smaller.");
            Console.WriteLine("3. Enter new guess. You will have 10 chances to guess it right.");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("");

            // Generating a Random Number between 1 to 100
            Random rnd = new Random(); // Creating a new rnd object from Random class
            int answer = rnd.Next(1,101); 
            
            // Taking User's Guess as an Integer
            Console.WriteLine("Guess a Number:");
            var guess = Convert.ToInt32(Console.ReadLine()); // As the ReadLine reads the input as string, converting it into int
            
            // Checking Higher or Lower and Returning a Message
            int trial = 0; // Counter for total timees 
            while(guess != answer && trial < 9){
                if(answer > guess){
                    Console.WriteLine("Guess a GREATER number");
                    Console.WriteLine("You have {0} chances remaining.", 9-trial);
                    Console.Write("New Guess :: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else if(answer < guess){
                    Console.WriteLine("Guess a SMALLER number");
                    Console.WriteLine("You have {0} chances remaining.", 9-trial);
                    Console.Write("New Guess :: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                trial++;
            }

            // Printing Win or Lose Message
            if(guess == answer){
                Console.WriteLine("");
                Console.WriteLine("RIGHT GUESS");
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("");
            }
            else {
                Console.WriteLine("");
                Console.WriteLine("OUT OF CHANCES");
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine("");
            }
        }
    }
}