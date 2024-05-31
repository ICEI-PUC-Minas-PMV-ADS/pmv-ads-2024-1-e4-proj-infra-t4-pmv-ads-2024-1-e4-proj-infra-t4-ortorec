
using APIPedidosRecomecar.Models;
using APIPedidosRecomecar.Services;

namespace APIPedidosRecomecar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Configuração do CORS
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll",
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                               .AllowAnyMethod()
                               .AllowAnyHeader();
                    });
            });

            // Configuração do CORS
            //builder.Services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowSpecificOrigin",
            //        builder =>
            //        {
            //            builder.WithOrigins("http://seufrontend.com:porta")
            //                   .AllowAnyMethod()
            //                   .AllowAnyHeader();
            //        });
            //});


            // Add services to the container.
            builder.Services.Configure<RecomecarDatabaseSettings>(
                builder.Configuration.GetSection("RecomecarDatabase"));
            builder.Services.AddSingleton<PedidoService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            // Configure o middleware CORS
            app.UseCors("AllowAll");


            app.MapControllers();

            app.Run();
        }
    }
}
