using System;
using System.Linq;

public class SituacaoAlunoController
{
    private readonly AppDbContext _context;

    public SituacaoAlunoController(AppDbContext context)
    {
        _context = context;
    }

    public void ListarSituacoesAlunos()
    {
        var situacoesAluno = _context.SituacaoAlunos.ToList();

        foreach (var situacao in situacoesAluno)
        {
            Console.WriteLine($"ID: {situacao.SituacaoAlunoId}, Descrição: {situacao.SituacaoAlunoDescricao}");
        }
    }
}
