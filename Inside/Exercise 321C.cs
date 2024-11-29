namespace Inside;

public class Exercise321C : IExercise
{
    public void Run()
    {
        var wallet = new[]
        {
            new Wallet(1, 7),
            new Wallet(5, 3),
            new Wallet(10, 2),
            new Wallet(20, 11),
        };

        var wallet2 = new Wallet();

        wallet2.ShowBalance(wallet);
        wallet2.CalculateBalance(wallet);
        Console.WriteLine($"Totalt har du xxx kr 💰");
    }
}