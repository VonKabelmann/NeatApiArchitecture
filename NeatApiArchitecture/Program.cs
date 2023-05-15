using Microsoft.EntityFrameworkCore;
using NeatApiArchitecture.BusinessLogic.Services;
using NeatApiArchitecture.DataAccess.Context;
using NeatApiArchitecture.DomainCommons.Enteties;
using NeatApiArchitecture.DomainCommons.Interfaces;
using NeatApiArchitecture.Presentation.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PeopleContext>(options => 
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
	);

builder.Services.AddScoped<IRepository<Person>, PeopleRepository>();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.AddEndpoints();
app.UseHttpsRedirection();

app.Run();
