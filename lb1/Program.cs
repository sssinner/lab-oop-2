using System;
using System.Reflection;

namespace lb1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.Apartment = "bn";
            address.Street = "bn";
            address.House = "bn";
            address.City = "bn";
            address.Index = 1;

            foreach (PropertyInfo property in address.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(address, null));
            }

            Console.ReadLine();
        }
    }
}