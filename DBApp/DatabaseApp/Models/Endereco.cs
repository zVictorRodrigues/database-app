using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("endereco")]

public class Endereco
{
    [Key]
     [Column("endereco_id")]
        public int EnderecoId { get; set; }

        [Required]
        [Column("municipio")]
        public string Municipio { get; set; }

        [Required]
        [Column("bairro")]
        public string Bairro { get; set; }

    }
