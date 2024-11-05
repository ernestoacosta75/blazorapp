using BlazorApp1.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container (services registration).
// BlazorComponents registers the services for Blazor service and rendering of components
builder.Services.AddRazorComponents();

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

// This will search for all components in the assembly, and it will make sure
// that these can be addressed so that they can render HTML, which is then sent back to the client.
app.MapRazorComponents<App>();

app.Run();
