﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.BasketDtos;
using MultiShop.WebUI.Services.BasketServices;
using MultiShop.WebUI.Services.CatalogServices.ProductServices;
using MultiShop.WebUI.Services.DiscountServices;
using MultiShop.WebUI.Services.Interfaces;

namespace MultiShop.WebUI.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductService _productService;
        private readonly IBasketService _basketService;
        private readonly IUserService _userService;


        public ShoppingCartController(IProductService productService, IBasketService basketService, IUserService userService)
        {
            _productService = productService;
            _basketService = basketService;
            _userService = userService;
        }

        public async Task<IActionResult> Index(int discountRateValue, string code)
        {
            ViewBag.discountRateValue = discountRateValue;
            ViewBag.code = code;
            var valueUser = _userService.GetUserInfo();
            var userId = valueUser.Id.ToString();
            var values = await _basketService.GetByUserIdBasket(userId);

            if (values != null)
            {
                ViewBag.total = values.TotalPrice.ToString("N2");
            }
            else
            {
                ViewBag.total = "0"; // Ya da uygun bir varsayılan değer
            }
            // total price and tax
            var taxPrice = values.TotalPrice / 100 * 20;
            var totalPriceWithTax = values.TotalPrice + taxPrice;

            ViewBag.totalPriceWithTax = totalPriceWithTax.ToString("N2");
            ViewBag.taxPrice = taxPrice.ToString("N2");

            // discount rate
            if (discountRateValue > 0)
            {
                var discountAmount = totalPriceWithTax / 100 * discountRateValue;
                var finalPriceAfterDiscount = totalPriceWithTax - discountAmount;

                ViewBag.finalPriceAfterDiscount = finalPriceAfterDiscount.ToString("N2");
                ViewBag.discountAmount = discountAmount.ToString("N2");
            }
            else
            {
                // if there is no discount, the final price will be the same as the total price.
                ViewBag.finalPriceAfterDiscount = totalPriceWithTax.ToString("N2");
                ViewBag.discountAmount = "0";
            }

            return View(values);
        }

        public async Task<IActionResult> AddBasketItem(string id)
        {
            var values = await _productService.GetByIdProductAsync(id);
            var items = new BasketItemDto
            {
                ProductId = values.ProductId,
                ProductName = values.ProductName,
                Price = values.ProductPrice,
                Quantity = 1,
                ProductImageUrl = values.ProductImageUrl,

            };
            await _basketService.AddBasketItem(items);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> RemoveBasketItem(string id)
        {
            await _basketService.RemoveBasketItem(id);
            return RedirectToAction("Index");
        }
    }
}
