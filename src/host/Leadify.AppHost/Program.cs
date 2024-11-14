IDistributedApplicationBuilder builder = DistributedApplication.CreateBuilder(args);

IResourceBuilder<RedisResource> cache = builder.AddRedis("cache");

builder.AddProject<Projects.Leadify_App>("leadify-app")
    .WithReference(cache);

builder.Build().Run();