using Microsoft.EntityFrameworkCore;
using opleiding.api;
using opleiding.api.Repositories;
using Opleiding.api.DataLayer;
using Opleiding.api.Entitties;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//DB configuration
builder.Services.AddDbContext<OpleidingContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("OpleidingContext")).UseLazyLoadingProxies());

//identitity configuration
builder.Services.AddIdentity<Persoon, Rol>().AddEntityFrameworkStores<OpleidingContext>();

builder.Services.AddScoped<IOpoRepository, OpoRepository>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

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
