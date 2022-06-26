using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RevolutionData.Interfaces;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
using RevolutionShopWebApp.Helpers;
using System.Security.Claims;

namespace RevolutionShopWebApp.Controllers
{
	public class CartController : Controller
	{
		private readonly IUnitOfWork _unitOfWork;
		private readonly RevolutionShopDbContext _context;
		private readonly IHttpContextAccessor _contextAccessor;
		private readonly UserManager<Account> _userManager;

		public CartController(IUnitOfWork unitOfWork, RevolutionShopDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<Account> userManager)
		{
			_unitOfWork = unitOfWork;
			_context = context;
			_contextAccessor = httpContextAccessor;
			_userManager = userManager;
		}

		public IActionResult Index()
		{
			var cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
			//ViewBag.Cart = cart;

			return View(cart);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public IActionResult AddToCart(int id)
		{
			if (SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart") == null)
			{
				var cart = new List<CartItem>();
				cart.Add(new CartItem
				{
					Product = _context.Products.FirstOrDefault(x => x.Id == id),
					Quantity = 1 
				});
				SessionHelper.Set(HttpContext.Session, "cart", cart);
			}
			else
			{
				var cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
				var index = IsExist(id);

				if (index != -1)
				{
					cart[index].Quantity++;
				}
				else
				{
					cart.Add(new CartItem
					{
						Product = _context.Products.FirstOrDefault(x => x.Id == id),
						Quantity = 1
					});
				}

				SessionHelper.Set(HttpContext.Session, "cart", cart);
			}

			return RedirectToAction("Index");
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public IActionResult RemoveItem(int id)
		{
			var cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
			var index = IsExist(id);

			cart.RemoveAt(index);
			SessionHelper.Set(HttpContext.Session, "cart", cart);

			return RedirectToAction("Index");
		}

		public IActionResult CreateOrder()
		{
			return RedirectToAction("Index");
		}

		private int IsExist(int id)
		{
			List<CartItem> cart = SessionHelper.Get<List<CartItem>>(HttpContext.Session, "cart");
			for (var i = 0; i < cart.Count; i++)
			{
				if (cart[i].Product.Id.Equals(id))
				{
					return i;
				}
			}

			return -1;
		}
	}
}
