using System.Text;
using FFXIComp.Api;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "FFXIComp API", Version = "v1" });

    // Add JWT bearer auth to Swagger
    c.AddSecurityDefinition("Bearer", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
    {
        Name = "Authorization",
        Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        In = Microsoft.OpenApi.Models.ParameterLocation.Header,
        Description = "Enter your valid JWT token.\n\nExample: Bearer eyJhbGciOiJIUzI1NiIs..."
    });

    c.AddSecurityRequirement(new Microsoft.OpenApi.Models.OpenApiSecurityRequirement
    {
        {
            new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Reference = new Microsoft.OpenApi.Models.OpenApiReference
                {
                    Type = Microsoft.OpenApi.Models.ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

// Load config from appsettings and environment
builder.Configuration.AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")?
    .Replace("{FFXICOMP_DB_PASSWORD}", Environment.GetEnvironmentVariable("FFXICOMP_DB_PASSWORD") ?? throw new Exception("FFXICOMP_DB_PASSWORD not set"));

// Register your DbContext with PostgreSQL + EF Core
builder.Services.AddDbContext<GearDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<GearDbContext>()
    .AddDefaultTokenProviders();

var jwtKey = Environment.GetEnvironmentVariable("FFXICOMP_JWT_KEY")
    ?? throw new Exception("FFXICOMP_JWT_KEY not set");
var jwtIssuer = Environment.GetEnvironmentVariable("FFXICOMP_JWT_ISSUER")
    ?? throw new Exception("FFXICOMP_JWT_ISSUER not set");

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = true;
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidIssuer = jwtIssuer,
        ValidateAudience = false,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtKey))
    };
});

builder.Services.AddAuthorization();

// Add HttpClient for external URL fetching
builder.Services.AddHttpClient();

var app = builder.Build();

// Seed data
using (var scope = app.Services.CreateScope())
{
    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

    string[] roles = ["Admin", "User"];

    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }
}

// using (var scope = app.Services.CreateScope())
// {
//     var context = scope.ServiceProvider.GetRequiredService<GearDbContext>();
//     context.Database.Migrate();
//     GearDbContext.SeedInitialData(context);
// }

// ✅ Serve static files from wwwroot
app.UseDefaultFiles(); // optional, but helps serve index.html
app.UseStaticFiles();

app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Fallback route to serve React index.html for SPA routing
app.MapFallbackToFile("index.html");

app.Run();