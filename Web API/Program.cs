using BLL;
using DAL;
using DAL.model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<CustomerBll>();
builder.Services.AddTransient<CustomerDal>();
builder.Services.AddDbContext<ClothSellingBusinessContext>();

builder.Services.AddTransient<EmployeeBll>();
builder.Services.AddTransient<EmployeeDal>();
builder.Services.AddTransient<OrderBll>();
builder.Services.AddTransient<OrderDal>(); 
builder.Services.AddTransient<ProductBll>();
builder.Services.AddTransient<ProductDal>();
builder.Services.AddTransient<ProductionBll>();
builder.Services.AddTransient<ProductionDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
if (!app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
