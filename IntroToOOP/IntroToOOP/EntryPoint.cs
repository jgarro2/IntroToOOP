using PointsAndLines;

class EntryPoint
{
    static void Main()
    {
        User user = new User();

        user.Username = "abcd";
        user.Password = 7;
        System.Console.WriteLine(user.Username);
        System.Console.WriteLine(user.Password);

        System.Console.ReadLine();
    }
}

