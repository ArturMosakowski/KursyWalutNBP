using KursyWalutNBP.Data;
using KursyWalutNBP.Services;
using Microsoft.AspNetCore.Mvc;
using KursyWalutNBP.Helpers;

namespace KursyWalutNBP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExchangeRateService _exchangeRateService;

        private readonly IExchangeRateRepository _repository;

        public HomeController(
            ExchangeRateService exchangeRateService,
            IExchangeRateRepository repository)
        {
            _exchangeRateService = exchangeRateService;
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var vm = await _exchangeRateService.CallApi();

            return RedirectToAction("ShowData", vm);
        }

        public async Task<IActionResult> ShowData()
        {
            var vm = await _exchangeRateService.CallApi();

            return View(vm);
        }

        public async Task<IActionResult> SaveRates()
        {
            var vm = await _exchangeRateService.CallApi();

            var rates = Mapper.MapToModel(vm.Rates, vm.EffectiveDate);

            _repository.SaveRates(rates);
            _repository.SaveChanges();

            return View("ShowData", vm);
        }
    }
}
