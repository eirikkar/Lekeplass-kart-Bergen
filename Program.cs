using Lekeplass_kart_Bergen.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
HttpGetFile httpGetFile = new();
Lekeplass lekeplass = new();
await httpGetFile.GetCsv();

var lekeplassList = lekeplass.GetLekeplasser();

foreach (Lekeplass lekeplasser in lekeplassList)
{
    Console.WriteLine(
        $"#{lekeplasser.Id}, {lekeplasser.Name}: {lekeplasser.Lat}, {lekeplasser.Long}"
    );
}
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
