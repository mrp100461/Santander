using Microsoft.AspNetCore.Http.Timeouts;
using Santander.Endpoints;
using Santander.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();
builder.Services.AddSingleton<IStoriesService, StoriesService>();
builder.Services.AddRequestTimeouts(options =>
{
    options.DefaultPolicy = new RequestTimeoutPolicy
    {
        Timeout = TimeSpan.FromSeconds(30)
    };
});
builder.Services.AddHttpClient(
    "hackernews",
    client =>
    {
        client.BaseAddress = new Uri("https://hacker-news.firebaseio.com/v0/");
        client.DefaultRequestHeaders.Add("Accept", "application/json");
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}
app.UseRequestTimeouts();
app.UseHttpsRedirection();

app.MapStoriesEndpoints();

app.Run();

