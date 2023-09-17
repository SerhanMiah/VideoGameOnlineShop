using VideoGameAppBackend.Models;
using VideoGameAppBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text.Json.Serialization;
using VideoGameAppBackend.Controllers;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Configuration for DbContext and Identity
builder.Services.AddControllersWithViews();

// Retrieve the PostgreSQL connection details from configuration
var host = configuration["PGHOST"];
var port = configuration["PGPORT"];
var database = configuration["PGDATABASE"];
var user = configuration["PGUSER"];
var password = configuration["PGPASSWORD"];

var connectionString = $"Host={host};Port={port};Database={database};Username={user};Password={password}";

// Use the PostgreSQL connection string to configure the DbContext
builder.Services.AddDbContext<GameDbContext>(options => 
    options.UseNpgsql(connectionString));


builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<GameDbContext>()
    .AddDefaultTokenProviders();

// Configuration for JWT Authentication
string? jwtKey = configuration["Jwt:Key"];
if (jwtKey == null)
{
    throw new Exception("Missing JWT key in configuration");
}
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = configuration["Jwt:Issuer"],
            ValidAudience = configuration["Jwt:Issuer"],
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtKey))
        };
    });

// JSON Serializer Options
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
    options.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
});

// Configuration for CORS
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
var allowedOrigins = configuration.GetSection("AllowedOrigins").Get<string[]>() ?? new string[0];
builder.Services.AddCors(options =>
{
    options.AddPolicy(name:MyAllowSpecificOrigins, builder =>
    {
        builder.WithOrigins(allowedOrigins.Length > 0 ? allowedOrigins : new[] { "YourDefaultOriginHere" })
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowedToAllowWildcardSubdomains();
    });
});

// Adding Application Part
builder.Services.AddControllers().AddApplicationPart(typeof(ShoppingCartController).Assembly);


// Build App
var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.Run();





