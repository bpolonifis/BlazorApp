using ADHD.Plugins.InMemory;
using ADHD.UseCases.ExecutiveFunction;
using ADHD.UseCases.ExecutiveFunction.Interfaces;
using ADHD.UseCases.PluginInterfaces;
using ADHD.WebApp.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

builder.Services.AddSingleton<IUserTasksRepository, UserTasksRepository >();
builder.Services.AddTransient<IViewUserTasksByDescriptionUseCase, ViewUserTasksByDescriptionUseCase>();
builder.Services.AddTransient<IAddUserTaskUseCase, AddUserTaskUseCase>();
builder.Services.AddTransient<IEditUserTaskUseCase, EditUserTaskUseCase>();
builder.Services.AddTransient<IViewUserTaskbyIdUseCase, ViewUserTaskbyIdUseCase>();
builder.Services.AddTransient<IDeleteUserTaskUseCase, DeleteUserTaskUseCase>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();
