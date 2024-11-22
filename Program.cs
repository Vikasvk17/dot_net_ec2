using System;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello, World!");  // This sets up a simple route that responds with "Hello, World!"

app.Run();  // Starts the web server and listens for HTTP requests
