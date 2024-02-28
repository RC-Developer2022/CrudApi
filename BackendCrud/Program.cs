using BackendCrud.Data;
using BackendCrud.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => 
    options.UseNpgsql(builder.Configuration.GetConnectionString("Crud"))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/CreatePerson" , async ([FromServices]AppDbContext context, [FromBody] Pessoa pessoa) => 
{
    await context.Pessoas.AddAsync(pessoa);
    await context.SaveChangesAsync();

    var pessoaCriada =await context.Pessoas.Where(p => p.Id.Equals(pessoa.Id)).FirstOrDefaultAsync();

    return Results.Ok(pessoaCriada);
});

app.MapGet("/AllPersons", async ([FromServices] AppDbContext context) => 
{
    var person = await context.Pessoas.ToListAsync();
    return Results.Ok(person);
});


app.Run();


