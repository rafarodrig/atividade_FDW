using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concesionaria.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "A marca é obrigatória.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "A marca deve ter entre 2 e 50 caracteres.")]
        public string Marca { get; set; } = string.Empty;

        [Display(Name = "Modelo")]
        [Required(ErrorMessage = "O modelo é obrigatório.")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O modelo deve ter entre 1 e 50 caracteres.")]
        public string Modelo { get; set; } = string.Empty;

        [Display(Name = "Ano de Fabricação")]
        [Required(ErrorMessage = "O ano de fabricação é obrigatório.")]
        [Range(1900, 2100, ErrorMessage = "Ano de fabricação inválido.")]
        public int AnoFabricacao { get; set; }

        [Display(Name = "Ano do Modelo")]
        [Required(ErrorMessage = "O ano do modelo é obrigatório.")]
        [Range(1900, 2100, ErrorMessage = "Ano do modelo inválido.")]
        public int AnoModelo { get; set; }

        [Display(Name = "Chassi")]
        [Required(ErrorMessage = "O número do chassi é obrigatório.")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "O chassi deve ter exatamente 17 caracteres.")]
        public string Chassi { get; set; } = string.Empty;

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Preço inválido.")]
        public decimal Preco { get; set; }

    }
}