using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAssignment.Models
{
    class StartMenu
    {
        public static void StartProgram()
        {
            MovieLibrary library = new MovieLibrary();
            int userAction = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to our movie library");

                Console.WriteLine("1. Find movie");
                Console.WriteLine("2. Add movie");
                Console.WriteLine("3. Quit");
                userAction = int.Parse(Console.ReadLine());

                switch (userAction)
                {
                    case 1:
                        library.SearchMovie();
                        break;
                    case 2:
                        library.AddMovie();

                        break;
                    case 3:
                        Console.WriteLine("Have a nice day!");
                        break;
                    default:
                        break;
                }

            } while (userAction != 3);
        }
    }
}
