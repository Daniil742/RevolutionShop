using Microsoft.AspNetCore.Identity;

namespace RevolutionData.Models.Entities
{
	/// <summary>
	/// Аккаунт.
	/// </summary>
	public class Account : IdentityUser
	{
		public List<Cart> Carts { get; set; }
	}
}
