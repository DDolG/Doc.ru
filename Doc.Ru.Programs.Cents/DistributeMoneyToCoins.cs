namespace Doc.Ru.Programs.Cents;

public interface IDistributor
{
    public Vallet DistributeMoneyToCoins(uint cents);
}
