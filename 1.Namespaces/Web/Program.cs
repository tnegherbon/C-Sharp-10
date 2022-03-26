using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Web.Mappers;


namespace Web
{
	public class Program
	{
		public static async Task Main(string[] args)
		{
			var builder = WebAssemblyHostBuilder.CreateDefault(args);
			builder.RootComponents.Add<App>("#app");

			builder.Services.AddScoped(
				sp => new HttpClient { BaseAddress = new Uri("https://localhost:5002") });
			builder.Services.AddSingleton<EventMapper>();

			await builder.Build().RunAsync();
		}
	}
}