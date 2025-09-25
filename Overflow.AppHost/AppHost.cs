var builder = DistributedApplication.CreateBuilder(args);

var keyclock = builder.AddKeycloak("keyclock", 6001)
    .WithDataVolume("keyclock-data");

builder.Build().Run();
