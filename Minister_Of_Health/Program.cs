using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Minister_Of_Time.Components;
using Minister_Of_Time.Components.Account;
using Minister_Of_Time.Data;
using Minister_Of_Time.Domain; // Ensure this matches your User class location

var builder = WebApplication.CreateBuilder(args);

// 1. Database Configuration
// Registers the DbContextFactory to handle multi-threaded access in Blazor Server.
builder.Services.AddDbContextFactory<Minister_Of_TimeContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Minister_Of_TimeContext") 
    ?? throw new InvalidOperationException("Connection string 'Minister_Of_TimeContext' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// 2. Razor Components and Interactive Server Mode
// Enables the Blazor framework for your UI.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// 3. Authentication & Identity Services
// Configures the cascading state so all pages know if a user is logged in.
builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

builder.Services.AddAuthentication(options =>
    {
        options.DefaultScheme = IdentityConstants.ApplicationScheme;
        options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
    })
    .AddIdentityCookies();

// IMPORTANT: This registers the UserManager<User> that your Life page is asking for.
// It links your custom 'User' domain model to your 'Minister_Of_TimeContext' database.
builder.Services.AddIdentityCore<User>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Minister_Of_TimeContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();

builder.Services.AddSingleton<IEmailSender<User>, IdentityNoOpEmailSender>();

var app = builder.Build();

// 4. HTTP Pipeline Configuration
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Protects your app from cross-site request forgery.
app.UseAntiforgery();

// 5. Mapping Routes
// Maps the Blazor components and sets the render mode to InteractiveServer.
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Maps the identity endpoints (login, logout, register).
app.MapAdditionalIdentityEndpoints();

app.Run();