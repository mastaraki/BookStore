using BookStore.Core.Domain.Contracts;
using BookStore.Infrastructures.DataAccess.Repositories;
using BookStore.Services.ApplicationServices;
using CourseStore.Infrastructures.DataAccess.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

builder.Services.AddDbContext<BookStoreContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("BookStore")));

builder.Services.AddScoped<ICourseRepository, CourseRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<CustomerService, CustomerService>();
builder.Services.AddScoped<CourseService, CourseService>();

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
