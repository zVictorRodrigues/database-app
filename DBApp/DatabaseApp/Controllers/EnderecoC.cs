using System;
using System.Linq;

public class EnderecoController
{
    private readonly AppDbContext _context;

    public EnderecoController(AppDbContext context)
    {
        _context = context;
    }

    public void ListarEnderecos()
    {
        var enderecos = _context.Enderecos.ToList();

        foreach (var endereco in enderecos)
        {
            Console.WriteLine($"ID: {endereco.EnderecoId}, Município: {endereco.Municipio}, Bairro: {endereco.Bairro}");
        }
    }
}
