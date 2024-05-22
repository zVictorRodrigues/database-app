using System;
using System.Linq;

public class CursoController
{
    private readonly AppDbContext _context;

    public CursoController(AppDbContext context)
    {
        _context = context;
    }

    public void ListarCursos()
    {
        var cursos = _context.Cursos.ToList();

        foreach (var curso in cursos)
        {
            Console.WriteLine($"ID: {curso.CursoId}, Nome do Curso: {curso.NomeCurso}");
        }
    }
}
