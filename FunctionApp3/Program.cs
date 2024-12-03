using FunctionApp1.Services.Abstracts;
using FunctionApp1.Services.Concretes;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();
var connectionString = "";
builder.Services.AddSingleton<IQueueService>(sp => new QueueService(connectionString, "timerqueue"));

builder.Build().Run();
