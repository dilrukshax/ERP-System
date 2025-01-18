using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using System;

var builder = WebApplication.CreateBuilder(args);

// Configure CORS to allow requests from the frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("https://localhost:7071", "http://localhost:5063") // Frontend URLs
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add services to the container
builder.Services.AddControllers();

// Configure Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Define the Swagger document
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "ERP System API",
        Version = "v1",
        Description = "API for ERP System Web Application",
        Contact = new OpenApiContact
        {
            Name = "Dilan Dilruksha",
            Email = "dilandilruksha0gmail.com",
            Url = new Uri("https://yourwebsite.com")
        }
    });

    // Add JWT Authentication to Swagger
    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter JWT Bearer token **_only_**",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT",
        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    c.AddSecurityDefinition(securityScheme.Reference.Id, securityScheme);
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { securityScheme, Array.Empty<string>() }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "ERP-System V1");
        c.RoutePrefix = string.Empty; // Set Swagger UI at the app's root
    });
}

app.UseHttpsRedirection();

app.UseCors("AllowFrontend"); // Apply the CORS policy

app.UseAuthorization();

app.MapControllers();

app.Run();
