namespace Core_BaseTemplate.Data
{
	public class SampleClass
	{
		private readonly IConfiguration configs;
		private readonly DataContext context;

		public SampleClass(IConfiguration configs, DataContext context)
		{
			this.configs = configs;
			this.context = context;
		}

		public string GetKeyValue()
		{
			// Get Key value from Azure
			var key = configs["ApplicationSettings:KEY"];
			if (key != null) return key;
			return string.Empty;
		}


	}
}
