using System;
using System.Collections.Generic;
using System.IO;

namespace AdventCode
{
    class Day2_1
    {
        //static void Main(string[] args)
        //{
        //    var passwords = File.ReadAllLines("../../../Input2_1.txt");
        //    var passwordList = new List<string>(passwords);

        //    var total = 0;

        //    foreach(var pass in passwordList)
        //    {
        //        int lowerBound;
        //        int upperBound;
        //        char character;
        //        string password;
        //        var count = 0;

        //        var stringArray = pass.Replace("-", " ").Replace(":", "").Split(" ");

        //        lowerBound = Int32.Parse(stringArray[0]);
        //        upperBound = Int32.Parse(stringArray[1]);
        //        character = char.Parse(stringArray[2]);
        //        password = stringArray[3];

        //        foreach(char c in password)
        //        {
        //           if (c == character) count++;
        //        }
        //        if (count >= lowerBound && count <= upperBound) total++;
        //    }
        //    Console.WriteLine(total.ToString());
        //    Console.ReadLine();
        //}
    }
}
