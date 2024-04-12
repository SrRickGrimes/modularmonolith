using FastEndpoints;
using Server.Extensions;    

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();
builder.Services.AddAuthentication();

builder.Services.AddEndpointsApiExplorer()
    .AddSwaggerGen()
    .InstallModules()
    .ConfigureModules(builder.Configuration)
    .AddFastEndpoints();
    

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.UseFastEndpoints();
app.UseModules();

app.Run();
