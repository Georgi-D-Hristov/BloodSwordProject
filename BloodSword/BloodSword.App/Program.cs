namespace BloodSword.App
{
    using Microsoft.AspNetCore.Components.Web;
    using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

    using BloodSword.Domain.Repositories;
    using BloodSword.Services.Repositories;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddSingleton<IHeroRepository, InMemoryHeroRepository>();
            builder.Services.AddSingleton<IMonsterRepository, InMemoryMonsterRepository>();

            await builder.Build().RunAsync();
        }
    }
}
