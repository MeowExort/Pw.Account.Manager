using ElectronNET.API;
using ElectronNET.API.Entities;
using Pw.Account.Manager;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseElectron(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddElectron();
builder.Services.AddDomain();
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();

var menu = new MenuItem[] { };
Electron.Menu.SetApplicationMenu(menu);

await app.StartAsync();

// Open the Electron-Window here
await Electron.WindowManager.CreateWindowAsync();

app.WaitForShutdown();