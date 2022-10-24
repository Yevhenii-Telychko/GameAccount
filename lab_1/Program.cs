using lab_1;

class Program
{
    public static void Main(string[] args)
    {
        UpgradedGameAccount Ihor = new UpgradedGameAccount("Ihor_Obnal");
        PremiumGameAccount Danila = new PremiumGameAccount("Danila_Glovo");

        BasicGame BasicGame = new BasicGame();
        RankedGame RankedGame = new RankedGame();
        SafeGame SafeGame = new SafeGame();

        BasicGame.PlayGame(Ihor, Danila);
        RankedGame.PlayGame(Ihor, Danila);
        SafeGame.PlayGame(Ihor, Danila);

        Console.Write("Ihor_Obnal's rating:");
        Console.WriteLine(Ihor.CurrentRating);
        Console.WriteLine("Ihor_Obnal's Stats:");
        Console.WriteLine(Ihor.GetStats());

        Console.Write("Danila_Glovo's rating:");
        Console.WriteLine(Danila.CurrentRating);
        Console.WriteLine("Danila_Glovo's stats:");
        Console.WriteLine(Danila.GetStats());

        Console.ReadKey();
    }
}
