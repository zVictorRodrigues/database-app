using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("situacao_profissional")]

public class SituacaoProfissional
{
    [Key]
[Column("situacao_profissional_id")]
        public int SituacaoProfissionalId { get; set; }

        [Required]
        [Column("trabalhando")]
        public bool Trabalhando { get; set; }

        [Column("trabalha_area_curso")]
    public bool TrabalhaAreaCurso { get; set; }

    [Column("principal_atividade")]
    public string PrincipalAtividade { get; set; }

    [Column("jornada_trabalho")]
    public int JornadaTrabalho { get; set; }
}
