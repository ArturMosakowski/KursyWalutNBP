using KursyWalutNBP.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace KursyWalutNBP.Data
{
    public class SqlExchangeRateRepository : IExchangeRateRepository
    {
        private readonly ExchangeRateContext _context;

        public SqlExchangeRateRepository(ExchangeRateContext context)
        {
            _context = context;
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void SaveRates(RateModel rate)
        {
            if (rate == null)
            {
                throw new ArgumentNullException(nameof(rate));
            }
            _context.Rates.Add(rate);
        }
    }
}
