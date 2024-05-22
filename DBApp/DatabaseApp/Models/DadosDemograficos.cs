using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("dados_demograficos")]

public class DadosDemograficos
{
    [Key]
    [Column("dados_demograficos_id")]
        public int DadosDemograficosId { get; set; }

        [Required]
        [Column("faixa_etaria")]
        public string FaixaEtaria { get; set; }

        [Required]
        [Column("cor_raca")]
        public string CorRaca { get; set; }

        [Required]
        [Column("genero")]
        public string Genero { get; set; }  

        [Column("quantidade_filhos")]  
        public int QuantidadeFilhos { get; set; }

        [Column("quantidade_pessoas")]
    public int QuantidadePessoas { get; set; }

    [Column("escolaridade")]
    public string Escolaridade { get; set; }

    [Column("graduacao")]
    public string Graduacao { get; set; }

[Column("deficiencia")]
        public string Deficiencia { get; set; } 
    public string locomocao { get; set; }
    
   [Required]
        [Column("alimentacao_fmp")] 
        public string AlimentacaoFmp { get; set; }

        [Required]
        [Column("conclusao_enmedio")]
        public string ConclusaoEnmedio { get; set; }

        [Column("pratica_ativifisica")]
    public string PraticaAtivifisica { get; set; }

     [Column("dificuldades_frequentar")] 
        public string DificuldadesFrequentar { get; set; }

        [Column("redes_socias")]
    public string RedesSocias { get; set; }

    [Column("faixa_renda")]
    public string FaixaRenda { get; set; }

    [Column("renda_familiar")]
    public string RendaFamiliar { get; set; }

    [Column("situacao_de_moradia")]
    public string SituacaoDeMoradia { get; set; }
}