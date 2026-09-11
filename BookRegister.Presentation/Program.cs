using BookRegister.Application;
using BookRegister.Infrastructure;
using BookRegister.Presentation.Dialogs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder();

builder.Services.AddInfrastructure();
builder.Services.AddApplication();

builder.Services.AddTransient<BookDialog>();

var app = builder.Build();

var bookDialog = app.Services.GetRequiredService<BookDialog>();

bookDialog.MainMenu();