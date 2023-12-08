using KursyWalutNBP.Models;

namespace KursyWalutNBP.Helpers
{
    public static class Mapper
    {
        public static RateModel MapToModel(List<Rate> rates, string date)
        {
            var result = new RateModel { Date = DateTime.Parse(date) };
            result.Thb = (decimal)rates[0].Mid;
            result.Usd = (decimal)rates[1].Mid;
            result.Aud = (decimal)rates[2].Mid;
            result.Hkd = (decimal)rates[3].Mid;
            result.Cad = (decimal)rates[4].Mid;
            result.Nzd = (decimal)rates[5].Mid;
            result.Sgd = (decimal)rates[6].Mid;
            result.Eur = (decimal)rates[7].Mid;
            result.Huf = (decimal)rates[8].Mid;
            result.Chf = (decimal)rates[9].Mid;
            result.Gbp = (decimal)rates[10].Mid;
            result.Uah = (decimal)rates[11].Mid;
            result.Jpy = (decimal)rates[12].Mid;
            result.Czk = (decimal)rates[13].Mid;
            result.Dkk = (decimal)rates[14].Mid;
            result.Isk = (decimal)rates[15].Mid;
            result.Nok = (decimal)rates[16].Mid;
            result.Sek = (decimal)rates[17].Mid;
            result.Ron = (decimal)rates[18].Mid;
            result.Bgn = (decimal)rates[19].Mid;
            result.Try = (decimal)rates[20].Mid;
            result.Ils = (decimal)rates[21].Mid;
            result.Clp = (decimal)rates[22].Mid;
            result.Php = (decimal)rates[23].Mid;
            result.Mxn = (decimal)rates[24].Mid;
            result.Brl = (decimal)rates[25].Mid;
            result.Myr = (decimal)rates[26].Mid;
            result.Idr = (decimal)rates[27].Mid;
            result.Inr = (decimal)rates[28].Mid;
            result.Krw = (decimal)rates[29].Mid;
            result.Cny = (decimal)rates[30].Mid;
            result.Xdr = (decimal)rates[31].Mid;

            return result;
        }
    }
}
