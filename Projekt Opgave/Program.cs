using Projekt_Opgave.Service;
using Projekt_Opgave.Service.Item_Service;
using Projekt_Opgave.Service.Customer_Service;
using Projekt_Opgave.Service.Order_Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddSingleton<ItemService, ItemService>();
builder.Services.AddSingleton<OrderService, OrderService>();
builder.Services.AddSingleton<CustomerService, CustomerService>();
builder.Services.AddTransient<JsonFileItemService>();
builder.Services.AddTransient<JsonFileCustomerService>();
builder.Services.AddTransient<JsonFileServiceOrder>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
