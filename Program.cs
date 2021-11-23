var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers()
    .AddXmlSerializerFormatters();


builder.Services.AddMvc(opt =>
{
    opt.ReturnHttpNotAcceptable = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
