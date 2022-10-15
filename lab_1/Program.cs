using lab_1;

class Program
{
    public static void Main(string[] args)
    {
        GameAccount Ihor = new GameAccount("Skam");
        GameAccount Danila = new GameAccount("Support");

        Game game = new Game();

        game.PlayGame(Ihor, Danila);
        game.PlayGame(Ihor, Danila);
        game.PlayGame(Ihor, Danila);
        game.PlayGame(Ihor, Danila);
        game.PlayGame(Ihor, Danila);

        Console.Write("Ihor's rating:");
        Console.WriteLine(Ihor.CurrentRating);
        Console.WriteLine("Ihor's Stats:");
        Console.WriteLine(Ihor.GetStats());

        Console.Write("Danila's rating:");
        Console.WriteLine(Danila.CurrentRating);
        Console.WriteLine("Danila's stats:");
        Console.WriteLine(Danila.GetStats());
    }
}
