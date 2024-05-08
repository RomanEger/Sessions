using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using Repository.Contracts;
using Repository.Entities;
using Repository.Repo;

namespace Session1
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<App>();
                    services.AddSingleton<MainWindow>();
                    services.AddScoped<ApplicationDbContext>();
                    services.AddScoped<IRepository<Client>, GenericRepository<Client>>();
                    services.AddScoped<IRepository<Diagnoze>, GenericRepository<Diagnoze>>();
                    services.AddScoped<IRepository<Doctor>, GenericRepository<Doctor>>();
                    services.AddScoped<IRepository<EventType>, GenericRepository<EventType>>();
                    services.AddScoped<IRepository<Gender>, GenericRepository<Gender>>();
                    services.AddScoped<IRepository<MedicineCard>, GenericRepository<MedicineCard>>();
                    services.AddScoped<IRepository<MedicineEvents>, GenericRepository<MedicineEvents>>();
                    services.AddScoped<IRepository<MedicineHistory>, GenericRepository<MedicineHistory>>();
                    services.AddScoped<IRepository<Polis>, GenericRepository<Polis>>();
                })
                .Build();
            var app = host.Services.GetRequiredService<App>();
            app.Run();
        }
    }
}
