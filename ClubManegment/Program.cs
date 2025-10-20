using ClubManegment.DB;
using ClubManegment.Repository;
using ClubManegment.Repository.CopetitionRepository;
using ClubManegment.Repository.PlayerReposi;
using ClubManegment.Repository.TeamReposito;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("conn")));
builder.Services.AddScoped(typeof(IGeneric<>), typeof(GenericRepo<>));
builder.Services.AddScoped<ITeam, TeamRepo>();
builder.Services.AddScoped<IPlayer, PlayerRepo>();
builder.Services.AddScoped<ICopetition, CopetitionRepo>();



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
