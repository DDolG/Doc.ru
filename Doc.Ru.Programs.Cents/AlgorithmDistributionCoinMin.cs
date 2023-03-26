
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Doc.Ru.Programs.Cents;

public class AlgorithmDistributionCoinMin : IDistributor
{
    public Vallet DistributeMoneyToCoins(uint cents)
    {
        var vallet = new Vallet();
        var coins = typeof(Vallet).GetProperties()
            .ToDictionary(p=>p.Name, p=> ((NumberOfCentsAttribute)p.GetCustomAttribute(typeof(NumberOfCentsAttribute))).Cents);
        coins.OrderByDescending(y => y.Value).Select(x => x.Key).ToList().ForEach(c =>
        {
            uint countCoin = cents / coins[c];
            var prop = vallet.GetType().GetProperty(c);
            prop?.SetValue(vallet, countCoin, null);
            cents -= countCoin * coins[c];
        });
        return vallet;
    }
}
