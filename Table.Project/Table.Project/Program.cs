using Microsoft.EntityFrameworkCore;
using Table.Project.Data;
using Table.Project.Repository;
using Table.Project.Repository.IRepository;

var builder = WebApplication.CreateBuilder(args);

var MyAllowSpecificOrigins = "AllowAllOrigins";
// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy(MyAllowSpecificOrigins,
        policy =>
        {
            policy.AllowAnyOrigin() // Allow requests from any origin
                  .AllowAnyHeader()  // Allow any headers
                  .AllowAnyMethod(); // Allow any HTTP method (GET, POST, etc.)
        });
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ISoccererRepository, SoccererRepository>();
var app = builder.Build();
app.UseCors(MyAllowSpecificOrigins);

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
