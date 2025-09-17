using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Models.DTO;
using System;
using System.Windows.Forms;
using User_interface;
using User_interface; 

namespace User_interface
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    
                    services.AddHttpClient<IHttpServices<ProductsDTO>, HttpServices<ProductsDTO>>(client =>
                    {
                        client.BaseAddress = new Uri("https://localhost:7154/");
                    });

                    services.AddHttpClient<IHttpServices<CategoriesDTO>, HttpServices<CategoriesDTO>>(client =>
                    {
                        client.BaseAddress = new Uri("https://localhost:7154/");
                    });

                    services.AddSingleton<Form1>();
                })
                .Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                try
                {
                    var form1 = services.GetRequiredService<Form1>();
                    Application.Run(form1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Došlo je do greške: {ex.Message}");
                }
            }
        }
    }
}