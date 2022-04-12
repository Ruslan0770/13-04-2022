using System;
using System.Collections.Generic;

namespace _13_04_2022.models
{ 

    class Program
    {
        static void Main(string[] args)
        {
        Product avg = new Product("notebook");


            avg.count = 10;
            avg.price = 2000;

            avg.sell();
            avg.sell();


            Console.WriteLine($"{avg.count} {avg.Totalincome}");

        }
    }
}
