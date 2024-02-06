using System;
using MidtermProject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermCOnsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = MidtermBasicFunctions.GetAllBooks();
            var oh = new outputhelper();

            //oh.WriteToConsole(b);


            // user decision defined in console properties-> general=
            var _args = Environment.GetCommandLineArgs();
            var choice = _args[1].ToString(); //subzero is file back


            if (choice == "consoleAllBooks")
            {
                oh.ConsoleDisplayAllBooks(b);
            }else if(choice == "consoleByTitle")
            {
                oh.ConsoleBooksByTitle("The Travels of Marco Polo");
            }else if(choice == "consoleByLN")
            {
                oh.ConsoleBooksByAuthorLN("Polo");
            }
            else if (choice == "writeAllBooks")
            {
                oh.WriteBooksToCSV(b);
            }
            else if (choice == "writeByLN")
            {
                oh.WriteBooksByAuthLN("Polo");
            } else if (choice == "writeByTitle")
            {
                oh.WriteBooksByTitle("The Travels of Marco Polo");
            }
            else
            {
                Console.WriteLine("Incorrect paramter.");
            }

        }


        // Originally wrote midterm with console input arguments... Required cmd line.

        /* s
        var oh = new outputhelper();

        Console.WriteLine("Type your output choice; 'csv' or 'console':");
            var outputChoice = Console.ReadLine().ToLower(); // standardize the input

            if (outputChoice == "console")
            {
                Console.WriteLine("Output to Console:");
                // pass it to console function
                HandleConsoleOutput(oh);
    }
            else if (outputChoice == "csv")
            {
                Console.WriteLine("Output to CSV:");
                // pass it to csv function
                HandleCSVOutput(oh);
}
            else
{
    Console.WriteLine("You only have two options...");
    return;
}
static void HandleConsoleOutput(outputhelper oh)
        {
            Console.WriteLine("Enter function choice for CONSOLE; 'ConsoleBooksByAuthorLN', 'ConsoleBooksByTitle', 'ConsoleDisplayAllBooks':");
            var functionChoice = Console.ReadLine();

            switch (functionChoice)
            {
                case "ConsoleBooksByAuthorLN":
                    Console.WriteLine("Enter author last name:");
                    var lastName = Console.ReadLine();
                    oh.ConsoleBooksByAuthorLN(lastName);
                    break;
                case "ConsoleBooksByTitle":
                    Console.WriteLine("Enter book title:");
                    var title = Console.ReadLine();
                    oh.ConsoleBooksByTitle(title);
                    break;
                case "ConsoleDisplayAllBooks":
                    var books = MidtermBasicFunctions.GetAllBooks();
                    oh.ConsoleDisplayAllBooks(books);
                    break;
                default:
                    Console.WriteLine("Choose a function from the list that was given. >:(");
                    break;
            }
        }

        static void HandleCSVOutput(outputhelper oh)
        {
            Console.WriteLine("Enter function choice for CSV ('WriteBooksByAuthorLN', 'WriteBooksByTitle', 'WriteBooksToCSV'):");
            var functionChoice = Console.ReadLine();

            switch (functionChoice)
            {
                case "WriteBooksByAuthorLN":
                    Console.WriteLine("Enter author last name:");
                    var lastName = Console.ReadLine();
                    oh.WriteBooksByAuthLN(lastName);
                    break;
                case "WriteBooksByTitle":
                    Console.WriteLine("Enter book title:");
                    var title = Console.ReadLine();
                    oh.WriteBooksByTitle(title);
                    break;
                case "WriteBooksToCSV":
                    var books = MidtermBasicFunctions.GetAllBooks();
                    oh.WriteBooksToCSV(books);
                    break;
                default:
                    Console.WriteLine("Choose a function from the list that was provided. >:(");
                    break;
            }
        }
        */
    }
}