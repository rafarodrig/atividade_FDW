using System.ComponentModel.DataAnnotations;

namespace Concesionaria.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "E-mail inválido.")]
        [StringLength(100, MinimumLength = 7, ErrorMessage = "O e-mail deve ter entre 7 e 100 caracteres.")]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [Phone(ErrorMessage = "Telefone inválido.")]
        [StringLength(20, ErrorMessage = "O telefone deve ter até 20 caracteres.")]
        public string Telefone { get; set; } = string.Empty;

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "O endereço deve ter entre 5 e 200 caracteres.")]
        public string Endereco { get; set; } = string.Empty;

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O CPF é obrigatório.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter 11 dígitos numéricos.")]
        public string Cpf { get; set; } = string.Empty;

        // 🔗 Associação 1:N — um cliente pode ter várias notas
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }
}

