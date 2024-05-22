using System;
using System.Linq;

public class AcessoTecnologiaController
{
    private readonly AppDbContext _context;

    public AcessoTecnologiaController(AppDbContext context)
    {
        _context = context;
    }

    public void ListarAcessoTecnologias()
    {
        var acessosTecnologia = _context.AcessoTecnologias.ToList();

        foreach (var acesso in acessosTecnologia)
        {
            Console.WriteLine($"ID: {acesso.AcessoTecId}, Acesso à Internet: {acesso.AcessoInternet}, Possui Computador: {acesso.PossuiComputador}, Dificuldades: {acesso.DificuldadesTecnologia}");
        }
    }
}
