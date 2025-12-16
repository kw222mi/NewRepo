var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}
// Daniel was here welcome
// Daniel was here and Therese was here
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


// Daniel was here too
