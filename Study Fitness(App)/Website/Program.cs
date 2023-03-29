using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add code for using session
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromSeconds(40);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
}
);

// Add these lines
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = new PathString("/Login");
    options.AccessDeniedPath = new PathString("/AccessDenied");
}
);

// policy for only admin access
builder.Services.AddAuthorization(options =>
{
	options.AddPolicy("OnlyAdminAccess", policy => policy.RequireClaim(ClaimTypes.AuthorizationDecision, "admin"));
});

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
// Add code to use sessions
app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
