var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

builder.AddProject<Projects.Leadify_App>("leadify-app").WithReference(cache);

builder.Build().Run();
