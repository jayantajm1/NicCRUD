using Microsoft.EntityFrameworkCore;
using NicCRUDAPI.BAL.IServices;
using NicCRUDAPI.BAL.Services;
using NicCRUDAPI.DAL.DBContext;
using NicCRUDAPI.DAL.IRepository;
using NicCRUDAPI.DAL.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<blogContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("SMCon")));

// Add services to the container.
// Add Automapper
builder.Services.AddAutoMapper(typeof(Program));

// Repositories
builder.Services.AddTransient<IUserRepository, UserRepository>();

// Service
builder.Services.AddTransient<IUserService, UserService>();
//ilder.Services.AddTransient<IPostService, PostService>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
