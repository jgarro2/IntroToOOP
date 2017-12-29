using System;
using IntroToOOP;
using PointsAndLines;

class EntryPoint
{
    static void Main()
    {
        User user = new User("abcd",Race.Earthling);
        User secondUser = new User();
        User thirdUser = new User();

        Utilities.ColorfulWriteLine(user.Username, ConsoleColor.DarkRed);

        Console.WriteLine(user.ID);
        Console.WriteLine(secondUser.ID);
        Console.WriteLine(thirdUser.ID);

        Console.ReadLine();
    }
}

