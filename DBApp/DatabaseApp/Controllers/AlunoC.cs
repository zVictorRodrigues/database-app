using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class AlunoController
{
    private readonly AppDbContext _context;

    public AlunoController(AppDbContext context)
    {
        _context = context;
    }

    public void ListarAlunos()
    {
        var alunos = _context.Alunos
            .Include(a => a.curso)
            .Include(a => a.endereco)
            .Include(a => a.dadosDemograficos)
            .Include(a => a.situacaoProfissional)
            .Include(a => a.acessoTecnologia)
            .Include(a => a.situacaoAluno)
            .ToList();

        foreach (var aluno in alunos)
        {
            Console.WriteLine($"Matrícula: {aluno.Matricula}, Nome: {aluno.Nome}, Curso: {aluno.curso?.NomeCurso}, Endereço: {aluno.endereco?.Municipio}, Dados Demográficos: {aluno.dadosDemograficos?.Genero}");
        }
    }
}
