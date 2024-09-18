var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.cafefinder2>("cafefinder2");

builder.Build().Run();
