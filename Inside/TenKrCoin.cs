namespace Inside;

public class TenKrCoin : Wallet
{
    public override int Value { get; set; } = 10;

    public TenKrCoin(int count)
    {
        Count = count;
    }
}