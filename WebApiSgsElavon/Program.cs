using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.IO;
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApiSgsElavon.Services;
using WebApiSgsElavon.Data;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;

builder.Services.AddAntiforgery(o =>
{
    o.FormFieldName = "AntiforgeryFieldname";
    o.HeaderName = "X-CSRF-TOKEN-HEADERNAME";
    o.SuppressXFrameOptionsHeader = false;
});

builder.Services.AddCors(o => {
    o.AddPolicy("CorsPolicy",
        builder =>
        builder
        .AllowAnyMethod()
        .AllowAnyHeader()
        .SetIsOriginAllowed(_ => true)
        .AllowCredentials());
});

builder.Services.AddDbContext<GetnetContext>(o => o.UseSqlServer(configuration.GetConnectionString("Db"), i=>i.UseCompatibilityLevel(100)));
builder.Services.AddControllers();
builder.Services.AddScoped<ICatalogosServices, CatalogosServices>();
builder.Services.AddScoped<INegocioService, NegocioService>();
builder.Services.AddScoped<IOdtService, OdtServices>();
builder.Services.AddScoped<IUnidadService, UnidadService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddHttpClient();
builder.Services.AddSwaggerGen(doc =>
{
    doc.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SgsGetnet.Mobile.API",
        Version = "v1"
    });
    var xmlPath = Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml");
    doc.IncludeXmlComments(xmlPath);
});

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SgsGetnet.Mobile.API v1"));
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("CorsPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
