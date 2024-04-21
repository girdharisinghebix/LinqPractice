using CoreProject.Controller;
using CoreProject.DataAccessLayer;
using CoreProject.DataAccessLayer.Models;
using CoreProject.ImplementBLL;
using CoreProject.ImplementInterfaceRepsitory;
using CoreProject.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//builder.Services.AddDbContext<BlogDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("BlogDBConnection")));

builder.Services.AddDbContext<BlogDbContext>
    (options => options.UseSqlServer(builder.Configuration.GetConnectionString("BlogDBConnection")));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<CustomerDataLayer>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseExceptionHandler(new ExceptionHandlerOptions
{
    ExceptionHandler = new JsonExceptionMiddleware().Invoke
});
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
