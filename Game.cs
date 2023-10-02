using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_Stretch_Zachory
{
    class Game
    {

        //Creates the references to be able to use the title, rating, and genre of games.
        public string Title { get; }

        public char Esrb { get; }

        public string Genre { get; }
        
        public Game(string titleParam, char esrbParam, string genreParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
            Genre = genreParam;
        }
    }
}
