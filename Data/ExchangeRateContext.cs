using KursyWalutNBP.Models;
using Microsoft.EntityFrameworkCore;

namespace KursyWalutNBP.Data
{
    public class ExchangeRateContext : DbContext
    {
        public ExchangeRateContext(DbContextOptions<ExchangeRateContext> opt) : base(opt)
        {

        }

        public DbSet<RateModel> Rates { get; set; }
    }
}
