using LinkBilgisayarWeek3Task.Data.Entities;
using LinkBilgisayarWeek3Task.Data.Interfaces;
using LinkBilgisayarWeek3Task.Data.Repositories;
using LinkBilgisayarWeek3Task.Data.UnitOfWork;
using LinkBilgisayarWeek3Task.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<LinkDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"), action =>
    {
        action.MigrationsAssembly("LinkBilgisayarWeek3Task.Data");
    });
});

builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));






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
