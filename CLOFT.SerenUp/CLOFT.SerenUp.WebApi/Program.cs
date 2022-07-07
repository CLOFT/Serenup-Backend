using System.Reflection;
using CLOFT.SerenUp.AppCore.Interfaces.Repositories;
using CLOFT.SerenUp.AppCore.Interfaces.Services;
using CLOFT.SerenUp.AppCore.Services;
using CLOFT.SerenUp.Infrastructure.Repositories;

RepoDb.PostgreSqlBootstrap.Initialize();

var builder = WebApplication.CreateBuilder(args);

//builder.Configuration.AddUserSecrets(Assembly.GetExecutingAssembly(), true);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Config singleton
builder.Services.AddSingleton<IBraceletsRepository, BraceletsRepository>();
builder.Services.AddSingleton<IBraceletsService, BraceletsService>();
builder.Services.AddSingleton<IAlarmsRepository, AlarmsRepository>();
builder.Services.AddSingleton<IAlarmsService, AlarmsService>();
builder.Services.AddSingleton<ICognitoUsersRepository, CognitoUsersRepository>();
builder.Services.AddSingleton<ICognitoUsersService, CognitoUsersService>();

// Add AWS Lambda Hosting
builder.Services.AddAWSLambdaHosting(LambdaEventSource.HttpApi);

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