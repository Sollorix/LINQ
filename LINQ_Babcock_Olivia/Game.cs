using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Babcock_Olivia
{
    internal class Game
    {
        // Creates string properties and defines get value.
        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }

        // Creates and sets string parameters.
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            // Assigns each parameter to the corresponding property.
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }
    }
}
