using System;

namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Harirak";
            var lastName = "Sritham";
            var fullName = firstName + " " + lastName;
            var myFullName = string.Format($"My name is {firstName} {lastName}");
            Console.WriteLine(fullName);

            var names = new string[3] {"Noon","Jane","Bow"};
            Console.WriteLine(names[0]);
            var formattedName = string.Join(", ", names);
            Console.WriteLine(formattedName);

            var text = @"Hi John
Look into the following paths
c:\folder\subfolder";
            Console.WriteLine(text);
        }

    }
}
