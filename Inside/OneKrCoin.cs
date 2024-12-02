namespace Inside;

public class OneKrCoin : Wallet
{
    public override int Value { get; set; } = 1;

    public OneKrCoin(int count)
    {
        Count = count;
    }
}