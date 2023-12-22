using Microsoft.EntityFrameworkCore;

namespace Core_BaseTemplate.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		// Add DbSets

	}
}
