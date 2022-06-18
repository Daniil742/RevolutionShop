﻿using Microsoft.AspNetCore.Mvc;
using RevolutionData.Interfaces;
using RevolutionData.Models.Entities;
using RevolutionData.Models.Repositories;

namespace RevolutionShopWebApp.Controllers
{
	public class ShopController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;

		public ShopController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		/// <summary>
		/// Футболки.
		/// </summary>
		/// <returns> Страница с товарами категории "Футболки". </returns>
		public IActionResult TShirtPage()
		{
			var tShirts = _unitOfWork.TShirts.GetAll();
			ViewBag.TShirts = tShirts;
			return View();
		}

		/// <summary>
		/// Лонгсливы.
		/// </summary>
		/// <returns> Страница с товарами категории "Лонгсливы". </returns>
		public IActionResult LongsleevePage()
		{
			return View();
		}

		/// <summary>
		/// Худи.
		/// </summary>
		/// <returns> Страница с товарами категории "Худи". </returns>
		public IActionResult HoodiePage()
		{
			return View();
		}

		/// <summary>
		/// Головные уборы.
		/// </summary>
		/// <returns> Страница с товарами категории "Головные уборы". </returns>
		public IActionResult HeaddressPage()
		{
			return View();
		}

		/// <summary>
		/// Штаны и шорты.
		/// </summary>
		/// <returns> Страница с товарами категории "Брюки и шорты". </returns>
		public IActionResult PantAndShortPage()
		{
			return View();
		}

		/// <summary>
		/// Шопперы.
		/// </summary>
		/// <returns> Страница с товарами категории "Шопперы". </returns>
		public IActionResult ShopperPage()
		{
			var shoppers = _unitOfWork.Shoppers.GetAll();
			ViewBag.Shoppers = shoppers;
			return View();
		}

		/// <summary>
		/// Конкретная футболка.
		/// </summary>
		/// <returns> Страница с подробной инфомацией о футболке. </returns>
		public IActionResult TShirtDetailPage(int id)
		{
			var product = _unitOfWork.TShirts.Get(id);
			ViewBag.TShirt = product;
			return View();
		}

		/// <summary>
		/// Конкретный шоппер.
		/// </summary>
		/// <returns> Страница с подробной инфомацией о шоппере. </returns>
		public IActionResult ShopperDetailPage(int id)
		{
			var product = _unitOfWork.Shoppers.Get(id);
			ViewBag.Shopper = product;
			return View();
		}
	}
}
