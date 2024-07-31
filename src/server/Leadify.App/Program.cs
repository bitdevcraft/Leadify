using Leadify.App;
using Leadify.App.Middlewares;
using Leadify.Application;
using Leadify.Infrastructure;
using Leadify.Persistence;
using Leadify.Presentation;
using Scrutor;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Dependency Injection of Layers
{
    builder
        .Services.AddAppServices()
        .AddPersistenceService(builder.Configuration)
        .AddApplicationServices()
        .AddInfrastructureServices(builder.Configuration)
        .AddPresentationServices();
}

builder.Services.Scan(selector =>
    selector
        .FromAssemblies(
            Leadify.Infrastructure.AssemblyReference.Assembly,
            Leadify.Persistence.AssemblyReference.Assembly
        )
        .AddClasses(false)
        .UsingRegistrationStrategy(RegistrationStrategy.Skip)
        .AsImplementedInterfaces()
        .WithScopedLifetime()
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseAuthentication();

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

app.Run();
