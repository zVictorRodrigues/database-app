using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


[Table("aluno")] 
public class Aluno
{
    [Key]
   [Column("matricula")]
        public int Matricula { get; set; }

        [Column("nome")]
        public string Nome { get; set; }

        [Column("ano_ingresso")]
        public int AnoIngresso { get; set; }

        [Column("curso_id")]
        public int CursoId { get; set; }

        [Column("endereco_id")]
        public int EnderecoId { get; set; }

        [Column("dados_demograficos_id")]
        public int DadosDemograficosId { get; set; }

        [Column("situacao_profissional_id")]
        public int? SituacaoProfissionalId { get; set; }

        [Column("acesso_tecnologia_id")]
        public int? AcessoTecnologiaId { get; set; }

        [Column("situacao_aluno_id")]
        public int SituacaoAlunoId { get; set; }

        [Column("semestre_ingresso")]
        public int SemestreIngresso { get; set; }

        public Curso curso { get; set; }
        public Endereco endereco { get; set; }
        public DadosDemograficos dadosDemograficos { get; set; }
        public SituacaoProfissional situacaoProfissional { get; set; }
        public AcessoTecnologia acessoTecnologia { get; set; }
        public SituacaoAluno situacaoAluno { get; set; }
    }