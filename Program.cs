using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using TCU_FleaMarket.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDbContext<UserDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("UserConnection"));
});
builder.Services.AddScoped<UserService>();

builder.Services.AddDbContext<ExhibitDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("exhibitConnection"));
});
builder.Services.AddScoped<ExhibitService>();

builder.Services.AddSignalR(e =>
{
    e.MaximumReceiveMessageSize = (long)1.024e8;
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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
