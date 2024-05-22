using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("curso")]

public class Curso
{
    [Key]
     [Column("curso_id")]
        public int CursoId { get; set; }

        [Required]
        [Column("nome_curso")]
        public string NomeCurso { get; set; }
    }
