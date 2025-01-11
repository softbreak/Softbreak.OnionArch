using Softbreak.OnionArch.Persistence.DependencyResolvers;
using Softbreak.OnionArch.APPLICATION.DependencyResolvers;


WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRepositoryServices();
builder.Services.AddDbContextService();
builder.Services.AddControllers();
builder.Services.AddApplicationMapperService();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
