using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Movie
    {
        public string MovieName { get; set; }
        public string MovieGenre { get; set; }
        public int MovieYear { get; set; }
        public string MovieAuthor { get; set; }

        public override string ToString()
        {
            return $"{MovieName} {MovieGenre} {MovieYear} {MovieAuthor}";
        }
    }
}
