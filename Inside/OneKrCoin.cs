namespace Inside;

public class OneKrCoin : Wallet
{
    public override int Value => 1;

    public OneKrCoin(int count)
    {
        Count = count;
    }
}