namespace Week_2;
class Program
{
    static void Main(string[] args)
    {
        #region first_part
        /*Player player1 = new Player();
        player1.x = 1.0f; 
        player1.y = 2.0f;
        player1.z = 3.0f;

        Player player2 = new Player();
        player2.x = 2.0f;
        player2.y = 1.0f;
        player2.z = 5.0f;

        int x = 42;
        DefaultValues myDefaultValues = new DefaultValues();
        Console.WriteLine($"Default integer; {myDefaultValues.anInt}");
        Console.WriteLine($"Default float; {myDefaultValues.aFloat}");
        Console.WriteLine($"Default bool; {myDefaultValues.aBool}");
        Console.WriteLine($"Default string; {myDefaultValues.aString}");
        Console.WriteLine($"Int default {default(int)}");
        Console.WriteLine($"Char default {default(char)}");*/
        #endregion

        #region second_part
        /*Player player3 = new Player();
        Console.WriteLine($"player3 x: {player3.x}");
        Console.WriteLine($"player3 y: {player3.y}");
        Console.WriteLine($"player3 z: {player3.z}");

        Player player4 = new Player(1.0f, 2.0f, 3.0f);
        Console.WriteLine($"player4 x: {player4.x}");
        Console.WriteLine($"player4 y: {player4.y}");
        Console.WriteLine($"player4 z: {player4.z}");

        Player player5 = new Player(1.0f, 2.0f, 3.0f);
        player5.Report();

        float x = player5.GetX();
        float y = player5.GetY();*/
        #endregion

        //Static members

        Player player10 = new Player();
        Console.WriteLine($"Player quantity: {Player.playerQty}");
        Console.WriteLine("------");
        Player player11 = new Player();
        Console.WriteLine($"Player quantity: {Player.playerQty}");

        //Anonymous class
        var myAnonymousClass = new { name = "sueda", surname = "turgut" };
        Console.WriteLine($"Name: {myAnonymousClass.name}");
        Console.WriteLine($"Surname: {myAnonymousClass.surname}");

        Player player20 = new Player();
        Player player21 = new Player(1.0f, 2.0f);
        Player player22 = new Player(1.0f, 2.0f, 3.0f);
        Player player23 = new Player(1.0f, 2.0f, 3.0f, "Not used in the object");
        Console.ReadLine();
    }
}
