using EsamDB;
using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<EsamContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("EsamDB"))
);

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<EsamContext>();
    context.Database.Migrate();
}

string usercall = @"Data Source= DESKTOP-0LBFUNR\SQLEXPRESS;Initial Catalog=Pruebas;User ID=Miguel; trusted_connection=true;";

using (var db = new SqlConnection(usercall))
{
    var sql = "select * from Users";
    var lst = db.Query<User>(sql);
    foreach (var oElement in lst)
    {
        Console.WriteLine($"{oElement.Id} - {oElement.UserName}");
    }
}
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
