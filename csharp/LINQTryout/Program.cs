using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Country> countries = new List<Country>()
            {
                new Country(){ Name = "USA", Population = 54_000_000},
                new Country(){ Name = "Canada", Population = 4_500_000 },
                new Country(){ Name = "China", Population = 1_400_000_000 }
            };

            var query = from c in countries
                        group c by c.Name[0];

            var ret = query.ToList();

            foreach (var cg in ret)
            {
                Console.WriteLine($"Group {cg.Key}:");
                foreach (var c in cg)
                {
                    Console.WriteLine(c.Name);
                }
            }

            var queryP = from c in countries
                         let per = (int) c.Population / 10_000_000
                         group c by per into cg
                         where cg.Key >= 2
                         orderby cg.Key
                         select cg;
            
            foreach (var g in queryP)
            {
                Console.WriteLine(g.Key);
                foreach (var c in g)
                {
                    Console.WriteLine($"{c.Name}: {c.Population}");
                }
            }
        }
    }

    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
    }
}
