namespace Inside;

public class Wallet
{
    public virtual int Value { get; set; }
    public int Count { get; init; }

    public static int CalculateBalance(Wallet[] wallet)
    {
        return wallet?.Sum(coin => coin.Value * coin.Count) ?? 0;
    }

    public static void ShowTotalAmount(int value)
    {
        Console.WriteLine($"Totalt har du {value} kr 💰");
    }

    public static void ShowBalance(Wallet[] wallet)
    {
        if (wallet == null || wallet.Length == 0)
        {
            Console.WriteLine("Du har ingen penger, aka du er blakk 🙃");
            return;
        }

        Console.WriteLine("I pengeboka har du:");
        foreach (var coin in wallet)
        {
            Console.WriteLine($"{coin.Count} x {coin.Value}-kroninger 🪙");
        }
    }
}