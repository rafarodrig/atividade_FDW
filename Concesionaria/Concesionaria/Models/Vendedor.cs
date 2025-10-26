using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concesionaria.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Data de Admissão")]
        [Required(ErrorMessage = "A data de admissão é obrigatória.")]
        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }

        [Display(Name = "Matrícula")]
        [Required(ErrorMessage = "A matrícula é obrigatória.")]
        [StringLength(20, ErrorMessage = "A matrícula deve ter até 20 caracteres.")]
        public string Matricula { get; set; } = string.Empty;

        [Display(Name = "Salário")]
        [Required(ErrorMessage = "O salário é obrigatório.")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 9999999999999999.99, ErrorMessage = "Salário inválido.")]
        public decimal Salario { get; set; }

        // Um vendedor pode emitir várias notas
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();


    }
}