using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RevolutionData.Interfaces;
using RevolutionData.Models.DB;
using RevolutionData.Models.Entities;
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
			var account = _userManager.Users.FirstOrDefault(x => x.Id == _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var products = _context.Carts
				.Where(x => x.ProductId != 0 && x.Account.Id == account.Id)
				.ToList();
			//ViewBag.Cart = products;
			return View(products);
		}

		public IActionResult AddToCart(int id)
		{
			var account = _userManager.Users.FirstOrDefault(x => x.Id == _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var product = _context.Carts.FirstOrDefault(x => x.ProductId == id && x.Account.Id == account.Id);
			if (product != null)
			{
				product.Quantity += 1;
			}
			else
			{
				var cart = new Cart
				{
					ProductId = id,
					Quantity = 1,
					Account = account
				};
				_context.Carts.Add(cart);
			}
			_context.SaveChanges();

			return RedirectToAction("Index");
		}

		public IActionResult CreateOrder()
		{
			var account = _userManager.Users.FirstOrDefault(x => x.Id == _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);
			var products = _context.Carts
				.Where(x => x.Account.Id == account.Id)
				.ToList();
			for (var i = 0; i < products.Count; i++)
			{
				_context.Carts.Remove(products[i]);
			}
			_context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
