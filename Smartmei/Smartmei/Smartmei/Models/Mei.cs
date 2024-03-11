using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smartmei.Models
{
    [Table("Mei")]
    public class Mei
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "Por favor, informe o nome.")]
        public string Nome { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Por favor, informe o email.")]
        public string Email { get; set; }

        [DisplayName("Senha")]
        [Required(ErrorMessage = "Por favor, informe a senha.")]
        public string Senha { get; set; }
    }
}
