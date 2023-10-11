using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CozaStore.Models;
[Table("ProdutoEstoque")]

public class ProdutoEstoque
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto

    [Required(ErrorMessage = "Informe o Tamanho")]
    public byte TamanhoId { get; set; }
    [ForeignKey("TamanhoId")]
    public Tamanho Tamanho { get; set; }

    [Required(ErrorMessage = "Informe a Cor")]
    public byte CorId { get; set; }
    [ForeignKey(" CorId")]
    
    [Display(Name = "Qtde em Estoque")]
    [Required(ErrorMessage = "Informe a quantidade em estoque.")]
    public int QtdeEstoque { get; set; }

    [Display(Name = "Preço")]
    [Column(TypeName = "decimal(8,2)")]
    [Required(ErrorMessage = "Informe o preço de venda.")]
    public decimal Preco { get; set; }

    [Display(Name = "Preço com Desconto.")]
    [Column(TypeName = "decimal(8,2)")]
    public string PrecoDesconto { get; set; }
}
