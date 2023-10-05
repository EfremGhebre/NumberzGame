using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace NumberzGame
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true) // A loop that repeats code as long as the conitions are true 
            {
                Console.WriteLine("Hej och välkommen till spelet gissa numret! \n"); // Info text that greets the user  

                GuessNumber(); // An external method holding code for the number guessing game 

                Console.WriteLine("Vill du spela igen?"); // Info display that checks if the user wants to play again or exit the game 
                Console.WriteLine("Tryck Enter för att börja om spelet eller svara med nej för att avsluta spelet.\n");
                string answer = Console.ReadLine();

                if (answer == "nej") // An If condition 
                {
                    Console.WriteLine("Tack för att du spelade!\n\nHejdå!");
                    break; // Exits the game upon user's request
                }
                else
                {
                    Console.WriteLine("Va kul att du vill köra igen! :)\nTryck Enter för att fortsätta."); // Info display if the user wishes to play again
                    Console.ReadKey();
                    Console.Clear(); // Clears the console by deleting previous displays
                }
            }
        }
        public static void GuessNumber()
        {
            Console.WriteLine("Välj svårighets nivån genom att skriva siffran bredvid ditt val:\n");
            Console.WriteLine("1 för enkel\n2 för lagom\n3 för avancerad\n");

            string[] levels = { "enkel", "lagom", "avancerad" }; // An array holding 3 different level options
            string[] numRange = { "1 - 10:", "1 - 50:", "1 - 100:" }; // An array holding number ranges 
            
            try // Checks data input
            {
                var userInput = int.Parse(Console.ReadLine());
                userInput -= 1;
                Console.WriteLine(" ");

                Console.WriteLine($"Du valde {levels[userInput]} nivå. Du har 5 försök att gissa numret som är mellan {numRange[userInput]}\n");
                Console.WriteLine("Gissa vilken siffra som jag tänker på? ");

                Random random = new Random(); // Creats a list with random numbers
                int number1 = random.Next(1, 11); // Level 1, number range b/n 1 and 10
                int number2 = random.Next(1, 51); // Level 2, number range b/n 1 and 50
                int number3 = random.Next(1, 101); // Level 3, number range b/n 1 and 100
                int[] allRandomNumbers = { number1, number2, number3 }; // AN array holding all the generated random numbers 
                int maxAttempts = 5; // Maximum allowed attempts

                for (int attempts = 1; attempts <= maxAttempts; attempts++) // A For -loop that checks the guessed number as well as the maximum allowed attempts 
                {
                    Console.WriteLine("Försök # {0}", attempts);
                    int guessedNumber = int.Parse(Console.ReadLine());

                    if (guessedNumber + 1 == allRandomNumbers[userInput] || guessedNumber - 1 == allRandomNumbers[userInput]) // Checks user input and displays relevant info
                    {
                        Console.WriteLine("Väldigt nära! Kom igen nu!");
                    }
                    else if (guessedNumber < allRandomNumbers[userInput])
                    {
                        Console.WriteLine("Tyvärr för lågt, gissa igen.");
                    }
                    else if (guessedNumber > allRandomNumbers[userInput])
                    {
                        Console.WriteLine("Tyvärr för högt, gissa igen.");
                    }
                    else
                    {
                        Console.WriteLine("Bra jobbat!! Du gissade rätt!\n");// Exits to home page if guessed number is correct
                        break;
                    }
                    if (attempts == maxAttempts) // Exits to home page if maximum allowed trials are reached 
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ojdå! Du har inga försök kvar.\n");
                        break;
                    }
                }
            }
            catch // Catches incorrect formated input
            {
                Console.WriteLine("Hoppsan! Fel inmatning. Tryck Enter för att fortsätta. \n"); // Info display during an incorrect input 
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

    

            
            
    



        
    

    






