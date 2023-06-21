using System.ComponentModel.DataAnnotations;

namespace FinalMVC.Models
{
	public class RegisterViewModel
	{
		[Required]
		public string Username { get; set; }

		[Required]
		public string Email { get; set; }

		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
