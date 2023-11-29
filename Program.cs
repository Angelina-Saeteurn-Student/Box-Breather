using System.Threading;


public class Program

{
    public static void Main(string[] args)
    {

        Console.WriteLine(PickName());
    }
    public static String PickName(){

            Random rand = new Random();
           
            string[] names = {"Tyler 'TK' Kerkstra", "Ashley Berna", "Max Baykowski", "Hayden Flick", "Jacob Daniel", "Blair Ciolk", "Raymond Meara-Klinge", "Joshua Burgenmeyer",
                            "Nick Fultz", "Ashley 'AJ' Haltenhoff", "Dakota McDaniel", "Kamren Moomey", "Keegan Ohlman", "Eli Robinson", "Jay V.", "Alec Tackitt", "Maximilian Wallace",
                            "Keagan Ziemann-Bell", "Nick Johnson", "Ethan Witter", "Gavin Loucks", "Aedan Vongsouthi" , "Brandon Olsen", "Dylan Walters", "Angelina Saeteurn", "Mr. Martinez", 
                            "Mr.Luyk"};
            int num = rand.Next(0, names.Length);
            string chosen = names[num];
            Console.Write("Selcting the Box Breather");
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(". ");
            Thread.Sleep(1000);

        return chosen;
    }
}


