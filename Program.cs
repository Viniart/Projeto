using Microsoft.EntityFrameworkCore;
using ProjetoAPI.Context;
using ProjetoAPI.Model;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var stringConexao = "Data Source=produtos.db";
builder.Services.AddSqlite<ProdutoDbContext>(stringConexao);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// async -> assincrono
app.MapGet("/produtos", async (ProdutoDbContext db) =>
{
    return await db.Produtos.ToListAsync();
});

// TODO CADASTRO - POST
app.MapPost("/produtos", async (Produto prod, ProdutoDbContext db) =>
{
    db.Produtos.Add(prod);
    // EF - SaveChanges
    await db.SaveChangesAsync();

    return Results.Created();
});

// GET - Listagem de Produtos - "/listarprodutos"
// POST - Cadastro de Produtos - "/cadastrarprodutos"

// Deletar e Editar

app.Run();