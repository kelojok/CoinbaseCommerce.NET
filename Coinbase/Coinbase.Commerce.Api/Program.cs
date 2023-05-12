using Coinbase.Commerce.Clients.Extensions;
using Coinbase.Commerce.Clients.Handlers;
using Coinbase.Commerce.Clients.Interfaces.Charges;
using Coinbase.Commerce.Clients.Interfaces.Checkouts;
using Coinbase.Commerce.Clients.Interfaces.Events;
using Coinbase.Commerce.Clients.Interfaces.Invoices;
using Refit;

namespace Coinbase.Commerce.Api
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddCoinbaseCommerceClients(builder.Configuration.GetSection("CoinbaseCommerceSettings"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}