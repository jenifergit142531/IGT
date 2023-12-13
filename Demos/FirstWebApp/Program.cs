using System.Diagnostics;
using NuGet.Common;

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

app.Use(async (context,next) =>
{
    Console.WriteLine($"Request :{context.Request.Method} {context.Request.Path}");
    await next.Invoke();
    Console.WriteLine($"Response :{context.Response.StatusCode}");

});

app.UseRouting();

app.UseAuthorization();



/*app.UseEndpoints(Endpoint=>
{
    Endpoint.MapControllers();
});*/

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

   /* app.MapControllerRoute(
    name: "Fera",
    pattern: "{controller=Property}/{action=Welcome}/{id?}");*/

app.Run();
