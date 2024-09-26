using AutoRepairShop.Components;
using AutoRepairShop.Components.Account;
using AutoRepairShop.Components.Pages.Shared;
using AutoRepairShop.Components.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddRazorPages();
 builder.Services.AddAuthentication( options => 
     {
         options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
         options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
     }).AddCookie();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AutoRepairDataContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddDbContext<AutoRepairDataContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped<ClientService>();    
builder.Services.AddScoped<VehicleService>();    
builder.Services.AddScoped<ProductService>(); 
builder.Services.AddScoped<ServiceOrderService>();  
builder.Services.AddScoped<UserService>();  
builder.Services.AddScoped<RoleService>();  
builder.Services.AddScoped<LoginService>(); 
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => {  options.DetailedErrors = true; });  
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseAuthentication();
app.UseAuthorization();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AllowAnonymous();
//app.MapAdditionalIdentityEndpoints();

app.Run();

