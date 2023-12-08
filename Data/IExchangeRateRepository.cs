using KursyWalutNBP.Models;

namespace KursyWalutNBP.Data
{
    public interface IExchangeRateRepository
    {
        bool SaveChanges();

        void SaveRates(RateModel rate);
    }
}
