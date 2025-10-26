using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concesionaria.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Número da Nota")]
        [Required(ErrorMessage = "O número da nota é obrigatório.")]
        public int Numero { get; set; }

        [Display(Name = "Data de Emissão")]
        [Required(ErrorMessage = "A data de emissão é obrigatória.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataEmissao { get; set; }

        [Display(Name = "Garantia até")]
        [Required(ErrorMessage = "A data de garantia é obrigatória.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Garantia { get; set; }

        [Display(Name = "Valor de Venda (R$)")]
        [Required(ErrorMessage = "O valor da venda é obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Preço inválido.")]
        public decimal ValorVenda { get; set; }

        // RELACIONAMENTOS (Foreign Keys)

        [Display(Name = "Cliente Comprador")]
        [Required(ErrorMessage = "O cliente é obrigatório.")]
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        [Display(Name = "Vendedor Responsável")]
        [Required(ErrorMessage = "O vendedor é obrigatório.")]
        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; } = null!;

        [Display(Name = "Carro Vendido")]
        [Required(ErrorMessage = "O carro é obrigatório.")]
        public int CarroId { get; set; }
        public Carro Carro { get; set; } = null!;
    }
}
