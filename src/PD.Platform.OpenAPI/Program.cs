
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);
//NLogBuilder.ConfigureNLog("XmlConfig/nlog.config").GetCurrentClassLogger();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//×¢ÈëÈÕÖ¾
//builder.Services.AddLogging(r =>
//{                                                                        
//    r.AddNLogWeb();
//});
builder.Logging.AddConsole().AddNLog("XmlConfig/nlog.config");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

