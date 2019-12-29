using System;
using System.Collections.Generic;
using FundamentalTryout.PrimitiveTypes;

namespace FundamentalTryout
{
    class Program
    {
        static void Main(string[] args)
        {
            //NumbersTryout.IntTypeTryout();
            //NumbersTryout.DoubleTypeTryout();
            //NumbersTryout.DecimalTypeTryout();
            var books = new Dictionary<string, string>()
            {
                ["Doyle, Arthur Conan"] = "Hound of the Baskervilles, The",
                ["London, Jack"] = "Call of the Wild, The",
                ["Shakespeare, William"] = "Tempest, The"
            };

            Console.WriteLine("Author and Title List");
            Console.WriteLine();
            Console.WriteLine($"|{"Author", -25}|{"Title", -30}");
            foreach (var book in books)
            {
                Console.WriteLine($"|{book.Key, -25}|{book.Value, -30}");
            }
        }
    }
}
