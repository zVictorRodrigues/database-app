using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<AcessoTecnologia> AcessoTecnologias { get; set; }
    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<DadosDemograficos> DadosDemograficos { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<SituacaoAluno> SituacaoAlunos { get; set; }
    public DbSet<SituacaoProfissional> SituacaoProfissionais { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aluno>()
            .HasOne(a => a.curso)
            .WithMany()
            .HasForeignKey(a => a.CursoId);

        modelBuilder.Entity<Aluno>()
            .HasOne(a => a.endereco)
            .WithMany()
            .HasForeignKey(a => a.EnderecoId);

        modelBuilder.Entity<Aluno>()
            .HasOne(a => a.dadosDemograficos)
            .WithMany()
            .HasForeignKey(a => a.DadosDemograficosId);

        modelBuilder.Entity<Aluno>()
            .HasOne(a => a.situacaoProfissional)
            .WithMany()
            .HasForeignKey(a => a.SituacaoProfissionalId); 

        modelBuilder.Entity<Aluno>()
            .HasOne(a => a.acessoTecnologia)
            .WithMany()
            .HasForeignKey(a => a.AcessoTecnologiaId);

        modelBuilder.Entity<Aluno>()
            .HasOne(a => a.situacaoAluno)
            .WithMany()
            .HasForeignKey(a => a.SituacaoAlunoId);
    }
}
