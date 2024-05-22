using System;
using System.Linq;

public class SituacaoProfissionalController
{
    private readonly AppDbContext _context;

    public SituacaoProfissionalController(AppDbContext context)
    {
        _context = context;
    }

    public void ListarSituacoesProfissionais()
    {
        var situacoesProfissionais = _context.SituacaoProfissionais.ToList();

        foreach (var situacao in situacoesProfissionais)
        {
            Console.WriteLine($"ID: {situacao.SituacaoProfissionalId}, Trabalhando: {situacao.Trabalhando}, Trabalha na Área do Curso: {situacao.TrabalhaAreaCurso}");
        }
    }
}
