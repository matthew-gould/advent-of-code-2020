using System;
using System.Collections.Generic;
using System.IO;

namespace AdventCode
{
    class Day2_2
    {
        static void Main(string[] args)
        {
            var passwords = File.ReadAllLines("../../../Input2_1.txt");
            var passwordList = new List<string>(passwords);

            var total = 0;

            foreach (var pass in passwordList)
            {
                int lowerBound;
                int upperBound;
                char character;
                char[] password;

                var stringArray = pass.Replace("-", " ").Replace(":", "").Split(" ");

                lowerBound = Int32.Parse(stringArray[0]);
                upperBound = Int32.Parse(stringArray[1]);
                character = char.Parse(stringArray[2]);
                password = stringArray[3].ToCharArray();

                var firstIndexFound = password[lowerBound-1] == character;
                var secondIndexFound = password[upperBound-1] == character;

                if ((firstIndexFound && !secondIndexFound) || (!firstIndexFound && secondIndexFound))
                {
                    total++;
                }
            }
            Console.WriteLine(total.ToString());
            Console.ReadLine();
        }
    }
}
