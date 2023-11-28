public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine(PickName());
    }
    public static String PickName(){

            Random rand = new Random();
            int num = rand.Next(0,25);
            string[] names = {"Tyler 'TK' Kerkstra", "Ashley Berna", "Max Baykowski", "Hayden Flick", "Jacob Daniel", "Blair Ciolk", "Raymond Meara-Klinge", "Joshua Burgenmeyer",
                            "Nick Fultz", "Ashley 'AJ' Haltenhoff", "Dakota McDaniel", "Kamren Moomey", "Keegan Ohlman", "Eli Robinson", "Jay V.", "Alec Tackitt", "Maximilian Wallace",
                            "Keagan Ziemann-Bell", "Nick Johnson", "Ethan Witter", "Gavin Loocks", "Aedan Vonysouthi" , "Brandon Olsen", "Dylan Walters", "Angelina Saeteurn"};
            string chosen= names[num];
        return chosen;
    }
}


