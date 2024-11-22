using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);  // Creates a WebApplication builder
var app = builder.Build();  // Builds the app

// Enable serving static files from wwwroot
app.UseStaticFiles();  // This will allow serving static files

// Map a simple GET route that returns "Hello, World!"
app.MapGet("/", () => "Hello, World!");

// Run the application
app.Run();
