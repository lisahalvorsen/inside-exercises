namespace Inside;

public class Wallet
{
    private int Value { get; set; }
    private int Count { get; set; }

    public Wallet(int value, int count)
    {
        Value = value;
        Count = count;
    }

    public Wallet()
    {
    }

    public int CalculateBalance(Wallet[] wallet)
    {
        return wallet?.Sum(coin => coin.Value * coin.Count) ?? 0;
    }

    public void ShowBalance(Wallet[] wallet)
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