using BLL.Services;
using BLL.Services.Interfaces;
using DAL;
using Microsoft.EntityFrameworkCore;

namespace DynamicReportAPI
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
            builder.Services.AddDbContext<DynamicReportContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), 
                b => b.MigrationsAssembly("DynamicReportAPI")));
            builder.Services.AddScoped<IReportingDataService, ReportingDataService>();

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