namespace Inside;

public class TwentyKrCoin : Wallet
{
    public override int Value { get; set; } = 20;

    public TwentyKrCoin(int count)
    {
        Count = count;
    }
}