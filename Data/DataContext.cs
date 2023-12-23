using Core_BaseTemplate.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_BaseTemplate.Data
{
	public partial class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public virtual DbSet<UserProfile> UserProfile { get; set; }
	}
}
