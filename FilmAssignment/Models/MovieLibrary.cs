using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmAssignment.Models
{
    class MovieLibrary : Movie
    {
        public MovieLibrary() { }

        List<Movie> allMovies = Movie.GenerateListOfMovies();
        //Add new films
        public void AddMovie()
        {
            Console.WriteLine("What is the title of the movie you would like to add?");
            string title = Console.ReadLine();
            Console.WriteLine($"What category is {title}? \n1. Horror\n2. Action\n3. Comedy\n4. Drama\n5. Documentary");
            int choice = int.Parse(Console.ReadLine());
            string category = "";
            switch (choice)
            {
                case 1:
                    category = "Horror";
                    break;

                case 2:
                    category = "Action";
                    break;

                case 3:
                    category = "Comedy";
                    break;

                case 4:
                    category = "Drama";
                    break;

                case 5:
                    category = "Documentary";
                    break;


                default:
                    Console.WriteLine("Not a valid category");
                    break;
            }

            Console.WriteLine($"When was {title} released?");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine($"Who is the lead actor for {title}");
            string actor = Console.ReadLine();

            Console.WriteLine($"Who is the lead actress for {title}");
            string actress = Console.ReadLine();
            allMovies.Add(new Movie { Category = category, Title = title, ReleaseDate = year, LeadActor = actor, LeadActress = actress });
        }

        public void SearchMovie()
        {
            var allMovies = Movie.GenerateListOfMovies();
            Console.WriteLine(" Choose what to search by:\n1. Category\n2. Title\n3. Leading Actor/Actress");
            int searchOption = int.Parse(Console.ReadLine());

            switch (searchOption)
            {
                case 1:
                    Console.WriteLine($"Categories:\nHorror Drama Action Comedy Documentary");
                    Console.WriteLine("Please enter which category you want to search");

                    string category = Console.ReadLine();
                    var movieByCategory = this.allMovies.Where(m => m.Category == category);
                    if (movieByCategory.Any())
                    {
                        Console.WriteLine($"Category: {category}\n");
                        foreach (Movie m in movieByCategory)
                        {
                            Console.WriteLine($"Title:{m.Title} Release Year: {m.ReleaseDate} Starring: {m.LeadActor} {m.LeadActress}\n");
                        }
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine($"No such category");
                    }
                    break;


                case 2:
                    Console.WriteLine("Please enter which title you want to find");
                    string title = Console.ReadLine();
                    var movieByTitle = this.allMovies.Where(m => m.Title == title);
                    if (movieByTitle.Any())
                    {
                        Console.WriteLine($"Title: {title}\n");
                        foreach (Movie m in movieByTitle)
                        {
                            Console.WriteLine($"Category: {m.Category} Release Year: {m.ReleaseDate} Starring:{m.LeadActor} {m.LeadActress}\n");
                        }
                        Console.ReadKey();
                    }

                    else
                    {
                        Console.WriteLine($"No such a title");
                        Console.WriteLine($"Do you want to add {title} (y/n)");
                        string answer = Console.ReadLine();
                        if (answer == "y")
                        {
                            AddMovie();
                        }
                    }
                    break;

                case 3:

                        Console.WriteLine("What is the name of the leading actor/actress you would like to find?");

                        string actor = Console.ReadLine();
                        var movieByActor = this.allMovies.Where(m => m.LeadActor == actor || m.LeadActress == actor);
                        if (movieByActor.Any())
                        {
                            Console.WriteLine($"Films played by {actor}:\n");
                            foreach (Movie m in movieByActor)
                            {
                                Console.WriteLine($"Title: {m.Title} Category: {m.Category} Release Year: {m.ReleaseDate}\n");
                            }
                            Console.ReadKey();
                        }

                        else
                        {
                            Console.WriteLine($"{actor} does not exist");
                        }

                    break;

                default:
                    break;
            }
        }
    }
}