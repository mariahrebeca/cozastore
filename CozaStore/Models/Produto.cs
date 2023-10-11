using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;
[Table("Produto")]

public class Produto
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required(ErrorMessage = "Informe o Nome")]
    [StringLength(60, ErrorMessage = "O Nome deve possuir no máximo 60 caracteres")]
    public string Nome { get; set; }

    [Display(Name = "Descrição Resumida")]
    [StringLength(60, ErrorMessage = "A descrição .")]
    public string DescricaoResumida { get; set; }

    [Display(Name = "Descrição Completa")]
    [StringLength(8000, ErrorMessage = "A descrição .")]
    public string DescricaoCompleta { get; set; }

    [StringLength(10, ErrorMessage = "O SKU deve possuir no máximo 10 caracteres.")]
    public string SKU { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o preço de venda.")]
    public decimal Preco { get; set; }

    [Display(Name = "Preço com Desconto.")]
    [Column(TypeName = "decimal(8,2)")]
    public string PrecoDesconto { get; set; }

    [Display(Name = "Produto em Destaque")]
    public bool Destaque { get; set; } = false;

    [Column(TypeName = "decimal(6,3)")]
    public decimal Peso { get; set; }

    [StringLength(30, ErrorMessage = "O material deve possuir no máximo 30 caracteres.")]
    public string Material { get; set; }

    [Display(Name = "Dimensões")]
    [StringLength(20, ErrorMessage = "A dimensão deve possuir no máximo 30 caracteres.")]
    public decimal Dimensao { get; set; }

}
