using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.LoginDtos;
using MultiShop.WebUI.Services.Interfaces;

namespace MultiShop.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        private readonly IIdentityService _identityService;
        public LoginController(IHttpClientFactory httpClientFactory, IIdentityService identityService)
        {
            _httpClientFactory = httpClientFactory;

            _identityService = identityService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(SignInDto signInDto)
        {
            var result = await _identityService.SignIn(signInDto);

            if (result == true)
            {
                HttpContext.Session.SetString("IsLoggedIn", "true");

                return RedirectToAction("Index", "Default");
            }

            return View(signInDto);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IsLoggedIn"); // Giriş bilgilerini sil
            return RedirectToAction("Index", "Default");
        }

        public async Task<IActionResult> SignIn(SignInDto signUpDto)
        {
            await _identityService.SignIn(signUpDto);
            return RedirectToAction("Index", "User");
        }
    }
}
