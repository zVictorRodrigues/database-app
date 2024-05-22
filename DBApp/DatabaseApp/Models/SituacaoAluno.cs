using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("situacao_aluno")]

public class SituacaoAluno
{
    [Key]
      [Column("situacao_aluno_id")]
        public int SituacaoAlunoId { get; set; }

        [Required]
        [Column("situacao_aluno")]
        public string SituacaoAlunoDescricao { get; set; }
}
