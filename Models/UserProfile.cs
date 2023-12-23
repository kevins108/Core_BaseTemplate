using System.ComponentModel.DataAnnotations;

namespace Core_BaseTemplate.Models
{
	public class UserProfile
	{
		[Key]
		public int ProfileID { get; set; }
		public Guid UserGuid { get; set; }
		[MaxLength(50)]
		public string? FirstName { get; set; }
		[MaxLength(50)]
		public string? LastName { get; set; }
		[MaxLength(50)]
		public string? EmailAddress { get; set; }
		public DateTime? CreateDate { get; set; }
		public bool Active { get; set; }
		[MaxLength(200)]
		public string? ProfileUrl { get; set; }
	}
}
