using calculatriceDeSalaire.Controllers;
using calculatriceDeSalaire.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
//builder.Services.AddRazorPages();
//builder.Services.AddScoped<ISalaryCalculator, MonthlySalaryCalculator>();
builder.Services.AddScoped<ISalaryCalculator, QuarterlySalaryCalculator>();
//builder.Services.AddScoped<Interface, Implementation>();

var app = builder.Build();

app.MapControllers();
// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

app.MapGet("/", () => "Hello World!");
app.Run();
