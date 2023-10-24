using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Cinemalist
    {
        List<Movie> films = new List<Movie>
        {
            new Movie(){MovieName = "Interstelar" , MovieGenre = "sci fi", MovieYear = 2004, MovieAuthor = "Christopher nolan"},
            new Movie(){MovieName = "Inception" , MovieGenre = "sci fi", MovieYear = 2010, MovieAuthor = "Christopher nolan"},
            new Movie(){MovieName = "Fast and furious 1-10" , MovieGenre = "Fantastic", MovieYear = 2003, MovieAuthor = "Pavle"},
            new Movie(){MovieName = "Love and other drugs" , MovieGenre = "Romance", MovieYear = 2006, MovieAuthor = "Tekla"},
            new Movie(){MovieName = "Pulp fiction" , MovieGenre = "Drama", MovieYear = 2008, MovieAuthor = "Quentin"},
        };

        public void SearchByGenre(string genre)
        {
            var found = films.FindAll(x => x.MovieGenre == genre);

            foreach(var item in found)
            {
                Console.WriteLine(item);
            }
        }

        public void SearchByName(string name)
        {
            var foundname = films.FindAll(x => x.MovieName == name);

            foreach (var item in foundname)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchByYear(int year)
        {
            var findyear = films.FindAll(x => x.MovieYear == year);

            foreach (var item in findyear)
            {
                Console.WriteLine(item);
            }
        }
        public void SearchByAuthor(string author)
        {
            var findauthor = films.FindAll(x => x.MovieAuthor == author);

            foreach (var item in author)
            {
                Console.WriteLine(item);
            }
        }


        public void Menu()
        {
            Console.WriteLine("1. Search Movie Genre");
            Console.WriteLine("2. Search Movie Name");
            Console.WriteLine("3. Search Movie Year");
            Console.WriteLine("4. Search Movie Author");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Search genre");
                    string input = Console.ReadLine();
                    SearchByGenre(input);
                    break;

                case 2:
                    Console.WriteLine("Search name");
                    string namefind = Console.ReadLine();
                    SearchByName(namefind);
                    break;
            }
        }
    }
}
