using System.Runtime.ExceptionServices;

namespace AnaGrammer
{
    class Program
    {
        static void Main(string[]args)
        {
            //this variable ensures the while loop will continue to loop until its declared false
            bool continueProgram = true;

            //this ensures the foerground color of the outputs and inputs
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("WELCOME TO THE ANAGRAMMER");

            while(continueProgram)
            {
                //prompts user to accept two string values
                Console.WriteLine("==============================");
                Console.WriteLine("Enter your first word:");
                string firstWord = Console.ReadLine();

                Console.WriteLine("\nEnter your second word:");
                string secondWord = Console.ReadLine();
                Console.WriteLine("==============================\n");

                //declares a variable to hold the result to the method
                bool result = IsAnagram(firstWord, secondWord);

                //displays the results.... True or False
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The result is....{result}");

                //prompts user, whether they would like to continue with the program or not
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n Would you like to continue? (y/n)");
                string choice = Console.ReadLine().ToLower(); // converts to lowercase to prevent string error

                if (choice !="y" && choice!="yes")
                {//if the user enters n 
                    continueProgram = false;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Thank you for using ANAGRAMMER!!....Press any key");
                    Console.ReadKey();
                }
            }
          
           

        }

        static bool IsAnagram(string strOne, string strTwo)
        {
            //replaces the whitespaces/ empty spaces and convert to lowercase to work with one type of string value
            strOne = strOne.Replace(" ", "").ToLower();
            strTwo = strTwo.Replace(" ", "").ToLower();

            //checks if strings length match, if not return as false
            if (strOne.Length != strTwo.Length)
                return false;

            //converts to char Array to sort the words in the correct order
            char[] strCharOne = strOne.ToCharArray();
            char[] strCharTwo = strTwo.ToCharArray();
            Array.Sort(strCharOne);
            Array.Sort(strCharTwo);

            //return the new strings and checks if the letters match, if so returns true
            return new string(strCharOne) == new string(strCharTwo);
        }
    }
}