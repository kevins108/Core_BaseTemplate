using Core_BaseTemplate.Data;
using Core_BaseTemplate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.FeatureManagement;

namespace Core_BaseTemplate.Repository
{
	public class UserRepository
	{
		private readonly DataContext context;
		public ApplicationSettings settings { get; }
		private readonly IFeatureManager featureManager;

		public UserRepository(DataContext context, IOptionsSnapshot<ApplicationSettings> settings, IFeatureManager featureManager)
		{
			this.context = context;
			this.settings = settings.Value;
			this.featureManager = featureManager;
		}

		public async Task<UserProfile?> GetUserInformation()
		{
			var key = settings.KEY;
			var actite = await featureManager.IsEnabledAsync("IsActive");
			var userProfile = new UserProfile();
			try
			{
				userProfile = await context.UserProfile.Where(u => u.Active == true).FirstOrDefaultAsync();
			}
			catch (Exception)
			{
				throw;
			}

			return userProfile;
		}
	}
}
