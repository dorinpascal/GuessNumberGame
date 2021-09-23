using System;


//Namespace name
namespace GuessNumberGame
{
    //Main class
    class Program
    {

        //Entry Point Method
        static void Main(string[] args)
        {
            //Run getAppInfo function to get app info 
            getAppInfo();



            //Greet the user
            greetUser();


            while (true)
            {
                //Create a random number
                Random random = new Random();


                //Init the right answer
                int correct = random.Next(1, 10);

                //Init guess var
                int guess = 0;

                //Ask user for the numebr
                Console.WriteLine("Guess the number between 1 and 10");

                //While loop for guessing the number
                while (guess != correct)
                {
                    //Get users input
                    string inputNumber = Console.ReadLine();

                    //Handle the wrong input exception
                    if (!int.TryParse(inputNumber, out guess))
                    {

                        //Print the error message
                        printColorMessage(ConsoleColor.Red, "Please input a number!");

                        //Keep going
                        continue;
                    }

                    //Casting the string to int
                    guess = Int32.Parse(inputNumber);


                    //Match guess to correct number
                    if (guess != correct)
                    {
                       
                        //Print the error message
                        printColorMessage(ConsoleColor.Red, "Wrong number.Try again!");

                    }






                }
                //Output success message
                printColorMessage(ConsoleColor.Yellow, "You are correct");

                //Ask to play again
                Console.WriteLine("Do you want to start over  [Y or N]?");

                //Get the answer
                string answer = Console.ReadLine().ToUpper();

                if (answer=="Y")
                {
                    continue;
                }
               else if(answer == "N")
                {
                    return;
                }
                else
                {
                    //Ask to play again
                    Console.WriteLine("Do you want to start over  [Y or N]?");

                    //Get the answer
                     answer = Console.ReadLine().ToUpper();
                }

            }
        }
        //get and display app info
        static void getAppInfo()
        {
            //Set application vars

            string appName = "Number Guesser";
            string appAuthor = "Dorin Pascal";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;


            //App info
            Console.WriteLine("{0} : by {1}", appName, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        //ask name and greet
        static void greetUser()
        {
            //Ask for users name
            Console.WriteLine("What is your name?");

            //Get users input

            string inputName = Console.ReadLine();

            //Starting game brief
            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        //Print color message
        static void printColorMessage(ConsoleColor color,string message)
        {
            //Change text color
            Console.ForegroundColor = color;


            //Tell user the message
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}
