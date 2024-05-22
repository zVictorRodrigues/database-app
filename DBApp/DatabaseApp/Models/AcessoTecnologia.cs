using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("acesso_tecnologia")]

public class AcessoTecnologia
{
    [Key]
   [Column("acesso_tec_id")]
        public int AcessoTecId { get; set; }
   [Required]
        [Column("acesso_internet")]
        public bool AcessoInternet { get; set; }

        [Column("possui_computador")]
    public bool PossuiComputador { get; set; }

    [Column("dificuldades_tecnologia")]
    public string DificuldadesTecnologia { get; set; }
}
