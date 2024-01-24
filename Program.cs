using System.Threading;

public class Program

{
    public static void Main(string[] args)
    {
        //TODO: ensure that no person can be chosen twice...
        string name = PickName();
        Console.WriteLine(name);
        if (name == "Robot")
        {
            RobotBreathing();
        }
    }
    public static String PickName()
    {

        Random rand = new Random();

        string[] names = {"Tyler 'TK' Kerkstra", "Ashley Berna", "Max Baykowski", "Hayden Flick", "Jacob Daniel", "Blair Ciolk", "Raymond Meara-Klinge", "Joshua Burgenmeyer",
                            "Nick Fultz", "Ashley 'AJ' Haltenhoff", "Dakota McDaniel", "Kamren Moomey", "Keegan Ohlman", "Eli Robinson", "Jay V.", "Alec Tackitt", "Maximilian Wallace",
                            "Keagan Ziemann-Bell", "Nick Johnson", "Ethan Witter", "Gavin Loucks", "Aedan Vongsouthi" , "Brandon Olsen", "Dylan Walters", "Angelina Saeteurn", "Mr. Martinez",
                            "Mr.Luyk", "Robot"};
        int num = rand.Next(0, names.Length);
        string chosen = names[num];
        num = rand.Next(5, 20);
        Console.Write("Selecting the Box Breather");
        for (int i = num; i >= 0; i--)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        
        Console.WriteLine("");
        return chosen;
    }
    public static void RobotBreathing()
    {
        Console.WriteLine("Alright my turn");
        Wait4();
        Console.WriteLine("Inhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Exhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Inhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Exhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Inhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Exhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Inhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Exhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Inhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
        Console.WriteLine("Exhale");
        Wait4();
        Console.WriteLine("Hold it");
        Wait4();
    }
    public static void Wait4()
    {
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Thread.Sleep(1000);
    }
}


