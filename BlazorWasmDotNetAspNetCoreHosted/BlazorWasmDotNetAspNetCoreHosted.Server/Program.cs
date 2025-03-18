var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();//--remove
builder.Services.AddControllersWithViews();//--add
builder.Services.AddRazorPages();//--add



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseWebAssemblyDebugging();//--add
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();//--add
app.UseStaticFiles();//--add

app.UseAuthorization();

//app.MapControllers();//--remove
app.MapRazorPages();//--add
app.MapControllers();//--add
app.MapFallbackToFile("index.html");//--add

app.Run();
