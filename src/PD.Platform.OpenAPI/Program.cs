

using Microsoft.Extensions.Options;
using NLog.Web;
using Org.BouncyCastle.Crypto.Prng;
using PD.Platform.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<TestConfig>(builder.Configuration.GetSection("TestConfig"));

//SysConfig.getconfig(builder.Configuration.GetSection("TestConfig"));

// Add services to the container.
builder.Services.AddControllers();
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

