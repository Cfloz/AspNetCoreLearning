var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.Run((HttpContext context) =>
{
    context.Response.StatusCode = 400;
})
;

app.Run();
