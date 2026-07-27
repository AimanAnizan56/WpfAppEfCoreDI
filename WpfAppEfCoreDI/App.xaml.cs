using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System.Data;
using System.Windows;
using WpfAppEfCoreDI.Appliciation.Services;
using WpfAppEfCoreDI.Domain.Repository;
using WpfAppEfCoreDI.Infrastructure.Data;
using WpfAppEfCoreDI.Infrastructure.Repository;
using WpfAppEfCoreDI.Presentation.ViewModels;
using WpfAppEfCoreDI.Presentation.Views;

namespace WpfAppEfCoreDI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost AppHost { get; private set; }
        private static void ApplyConfigService(HostBuilderContext hostContext, IServiceCollection services)
        {
            string dbPath = @"C:\Codes\test\test-efcore.accdb";
            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbPath}";
            services.AddDbContext<AppDbContext>(options =>
                options.UseJet(connectionString));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<CreateProductViewModel>();
            services.AddScoped<CreateProductPage>();
            services.AddScoped<ListProductsViewModel>();
            services.AddScoped<ListProductsPage>();
            services.AddScoped<MainViewModel>();
            services.AddScoped<MainWindow>();
        }
        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices(ApplyConfigService)
                .Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost.StartAsync();

            var mainWindow = AppHost.Services.GetRequiredService<MainWindow>();
            mainWindow.Show();
            base.OnStartup(e);
        }
    }

}
