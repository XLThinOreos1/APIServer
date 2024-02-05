using APIServer;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
WebApplication app = builder.Build();

TeacherCollection collection = new();

// app.MapGet("/", () => "Hello World!");
app.MapGet("/", GetHello);
app.MapGet("/hello", () => "Goodbye");

app.MapGet("/teachers/{number}", collection.GetTeacher);


app.Run();


static string GetHello()
{
    return "Hello TE21B!";
}