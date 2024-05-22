using System;
using System.Linq;

public class DadosDemograficosController
{
    private readonly AppDbContext _context;

    public DadosDemograficosController(AppDbContext context)
    {
        _context = context;
    }

    public void ListarDadosDemograficos()
    {
        var dadosDemograficos = _context.DadosDemograficos.ToList();

        foreach (var dados in dadosDemograficos)
        {
            Console.WriteLine($"ID: {dados.DadosDemograficosId}, Gênero: {dados.Genero}, Cor/Raça: {dados.CorRaca}");
        }
    }
}
