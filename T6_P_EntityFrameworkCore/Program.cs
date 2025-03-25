using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace T6_P_EntityFrameworkCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Configurar servicios
            var services = ConfigureServices();

            // Crear proveedor de servicios
            var serviceProvider = services.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            var mainForm = serviceProvider.GetRequiredService<Form1>();
            Application.Run(mainForm);
        }

        private static IServiceCollection ConfigureServices()
        {
            var services = new ServiceCollection();

            // Se registra el  DbContext
            services.AddDbContext<PanaderiaContext>(options =>
                options.UseSqlServer("Server=localhost;Database=Panaderia;Trusted_Conection=True;TrustServiceCertificate=True;"));

            // Registrar formularios
            services.AddTransient<Form1>();

            return services;
        }
    }
}