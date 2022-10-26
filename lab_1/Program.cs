using lab_1;

class Program
{
    public static void Main(string[] args)
    {
        UpgradedGameAccount Ihor = new UpgradedGameAccount("Ihor_Obnal");
        PremiumGameAccount Danila = new PremiumGameAccount("Danila_Glovo");

        GameController gameController = new GameController();

        List<Game> games = new List<Game> { gameController.getBasicGame(), gameController.getRankedGame(), gameController.getSafeGame() };

        foreach (var game in games)
        {
            game.PlayGame(Danila, Ihor);
        }

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
