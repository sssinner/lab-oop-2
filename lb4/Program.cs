using System;
using System.Reflection;

namespace lb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Surname = "mdma";
            user.Name = "mdma";
            user.Login = "mdma";
            user.Age = 33;

            foreach (PropertyInfo property in user.GetType().GetProperties())
            {
                Console.WriteLine(property.Name + " : " + property.GetValue(user, null));
            }

            Console.ReadLine();
        }
    }
}