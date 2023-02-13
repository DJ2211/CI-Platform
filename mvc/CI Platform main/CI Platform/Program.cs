using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Login}/{id?}"
    );


app.MapControllerRoute(
    name: "ForgotPassword",
    pattern: "{controller=Home}/{action=ForgotPassword}/{id?}"
    );

app.MapControllerRoute(
    name: "ResetPassword",
    pattern: "{controller=Home}/{action=ResetPassword}/{id?}"
    );

app.MapControllerRoute(
    name: "RegistrationPassword",
    pattern: "{controller=Home}/{action=RegistrationPage}/{id?}"
    );

app.Run();
