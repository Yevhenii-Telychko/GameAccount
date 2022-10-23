using lab_1;

class Program
{
    public static void Main(string[] args)
    {
        GameAccount Ihor = new GameAccount("Ihor_Obnal");
        GameAccount Danila = new GameAccount("Danila_Glovo");
            
        BasicGame basicGame = new BasicGame();
        RankedGame rankedGame = new RankedGame();
        SafeGame safeGame = new SafeGame();

        basicGame.PlayGame(Ihor, Danila);
        rankedGame.PlayGame(Ihor, Danila);
        safeGame.PlayGame(Ihor, Danila);

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
