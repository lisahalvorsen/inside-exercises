namespace Inside;

public class FiveKrCoin : Wallet
{
    public override int Value { get; set; } = 5;

    public FiveKrCoin(int count)
    {
        Count = count;
    }
}