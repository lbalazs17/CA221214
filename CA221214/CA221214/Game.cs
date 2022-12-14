using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA221214
{
    internal class Game
    {
        public int ReleaseYear { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }
        public string[] Platforms { get; set; }

        public Game(string row)
        {
            string[] v = row.Split(';');
            ReleaseYear = int.Parse(v[0]);
            Title = v[1];
            Genre = v[2];
            Publisher = v[3];
            Platforms = v[4].Split(", ");
        }
    }
}
