using System;
using System.Collections.Generic;
using System.Text;

namespace _13_04_2022.models
{
    class Product
    {
        public string Name { get; set; }
        public double price { get; set; }

        public int count { get; set; }
        public double Totalincome { get; set; }

        public Product(string name)
        {
            Name = name;
            Console.WriteLine(name);


        }

        public void sell()
        {

            if (count > 0)
            {
                count--;
                Totalincome += price;



            }
            else
            {
                Console.WriteLine("mehsul bitib");
            }


        }

    }
}
