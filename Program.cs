var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseStaticWebAssets();  // Optional for dev, but helpful

var app = builder.Build();
app.UseStaticFiles();  // This serves files from wwwroot

app.MapGet("/", () => "Hello World!");

app.Run();
