using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.IO;
using System;
using System.Reflection;
using WebApiSgsElavon.DataTTOSD;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

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

builder.Services.AddDbContext<GetnetContext>(o => o.UseSqlServer(configuration.GetConnectionString("Db")));
builder.Services.AddControllers();
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
