using MovieDatabase;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

// list of movies categories: animated, drama, horror, scifi
List<Movie> movieList = new List<Movie>()
{
    new Movie("Toy Story", "animated"),
    new Movie("Up", "animated"),
    new Movie("Shrek", "animated"),
    new Movie("No Country for Old Men", "drama"),
    new Movie("There Will Be Blood", "drama"),
    new Movie("The Departed", "drama"),
    new Movie("Hereditary", "horror"),
    new Movie("28 Days Later", "horror"),
    new Movie("Bladerunner", "scifi"),
    new Movie("Edge of Tomorrow", "scifi")

};

Console.WriteLine("Welcome to the Movie List Application!");

Console.WriteLine($"There are {movieList.Count} movies in this list.");

bool runProgram = true;
while (runProgram)
{
    do
    {

        Console.WriteLine("What category are you interested in?");
        string input = Console.ReadLine().ToLower().Trim();
        if (movieList.Any(x => x.Category == input))
        {

            foreach (Movie m in movieList.Where(m => m.Category == input))
            {
                Console.WriteLine($"{m.Title}");
            }
            break;
        }
        else
        {
            Console.WriteLine("Invalid genre");
            continue;
        }
    } while (true);
    while (true)
    {

        Console.WriteLine("Would you like to search again? y/n");
        string choice = Console.ReadLine().Trim().ToLower();
        if (choice == "y")
        {
            runProgram = true;
            break;
        }
        else if (choice == "n")
        {
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
    Console.WriteLine("Thank you for using the movie database!");
}