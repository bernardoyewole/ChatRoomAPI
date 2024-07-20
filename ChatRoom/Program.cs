
using Entities.Context;
using Entities.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using DAL;

namespace ChatRoom
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

            builder.Services.AddDbContext<ChatRoomContext>(
                options => options.UseSqlServer(@"Server=(LocalDb)\MSSQLLocalDB;Database=ChatRoomDb;Trusted_Connection=True;TrustServerCertificate=True;"));
            builder.Services.AddAuthorization();
            builder.Services.AddIdentityApiEndpoints<ApplicationUser>()
                .AddEntityFrameworkStores<ChatRoomContext>();

            builder.Services.AddScoped<IChatRoomContext, ChatRoomContext>();
            builder.Services.AddScoped<IGenericRepository<ApplicationUser>, GenericRepository<ApplicationUser>>();

            builder.Services.AddCors();

            var app = builder.Build();

            app.MapIdentityApi<ApplicationUser>();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapPost("/logout", async (SignInManager<ApplicationUser> signInManager,
                [FromBody] object empty) =>
                        {
                            if (empty != null)
                            {
                                await signInManager.SignOutAsync();
                                return Results.Ok();
                            }
                            return Results.Unauthorized();
                        })
            .WithOpenApi()
            .RequireAuthorization();

            app.UseCors(
                options => options.WithOrigins("http://localhost:3000").AllowAnyMethod()
             );

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
