var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Api>("api");

builder.AddProject<Projects.Web_Host>("web");

builder.Build().Run();
