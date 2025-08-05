using FFXIComp.Api;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Load config from appsettings and environment
builder.Configuration.AddEnvironmentVariables();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")?
    .Replace("{FFXICOMP_DB_PASSWORD}", Environment.GetEnvironmentVariable("FFXICOMP_DB_PASSWORD") ?? throw new Exception("FFXICOMP_DB_PASSWORD not set"));

// Register your DbContext with PostgreSQL + EF Core
builder.Services.AddDbContext<GearDbContext>(options => options.UseNpgsql(connectionString));

var app = builder.Build();

// Seed data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<GearDbContext>();
    context.Database.Migrate();
    GearDbContext.SeedInitialData(context);
}

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