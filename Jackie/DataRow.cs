using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jackie
{
    class DataRow
    {
        public int Year { get; set; }
        public int Races { get; set; }
        public int Wins { get; set; }
        public int Podiums { get; set; }
        public int Poles { get; set; }
        public int Fastests { get; set; }
        public int Decade { get => Year / 10 * 10 - 1900; }

        public DataRow(string row)
        {
            string[] r = row.Split('\t');
            Year = int.Parse(r[0]);
            Races = int.Parse(r[1]);
            Wins = int.Parse(r[2]);
            Podiums = int.Parse(r[3]);
            Poles = int.Parse(r[4]);
            Fastests = int.Parse(r[5]);
        }
    }
}
