using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Jackie
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. feladat
            List<DataRow> dataRows = new List<DataRow>();
            foreach (var row in File.ReadAllLines("jackie.txt").Skip(1))
            {
                dataRows.Add(new DataRow(row));
            }

            //3.
            Console.WriteLine($"3. feladat: {dataRows.Count}");

            //4.
            Console.WriteLine($"4. feladat: {dataRows.OrderBy(x => x.Races).Last().Year}");

            //5.
            Console.WriteLine($"5. feladat: ");
            dataRows
                .GroupBy(x => x.Decade)
                .Select(gr => new { Decade = gr.Key, Wins = gr.Sum(x => x.Wins) })
                .ToList()
                .ForEach(x => Console.WriteLine($"\t{x.Decade}-es évek: {x.Wins} megnyert verseny"));

            //6.
            Console.WriteLine($"6. feladat: jackie.html");
            StreamWriter sw = new StreamWriter("jackie.html");
            sw.WriteLine("<!DOCTYPE html>");
            sw.WriteLine("<html>");
            sw.WriteLine("<head></head>");
            sw.WriteLine("<body>");
            sw.WriteLine("<style>td { border: 1px solid black; }</style>");
            sw.WriteLine("<h1>Jackie Stewart</h1>");
            sw.WriteLine("<table>");
            sw.WriteLine($"<tr><td>Year</td><td>Races</td><td>Wins</td></tr>");

            dataRows
                .ForEach(x => sw.WriteLine($"<tr><td>{x.Year}</td><td>{x.Races}</td><td>{x.Wins}</td></tr>"));

            sw.WriteLine("</table>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");

            sw.Close();
        }
    }
}
