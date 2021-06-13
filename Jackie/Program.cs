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

        }
    }
}
