using Jyro.Infra.Context;
using Jyro.WEB.Middleware;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddRouting(opt => opt.LowercaseUrls = true);
builder.Services.AddLogging(configure =>
{
    configure.AddConsole();
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JWt:Issuer"],
            ValidAudience = builder.Configuration["JWt:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWt:Secret"]))
        };
    });

var app = builder.Build();

app.UseMiddleware<JwtMiddleware>();
app.UseAuthentication();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    using (var context = services.GetService<AppDbContext>())
    {
        context.Database.EnsureCreated();
    }
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
