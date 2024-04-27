using SmartMei.Models;
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
        [DataType(DataType.Password)]   
        public string Senha { get; set; }

        [NotMapped] // Essa propriedade não será mapeada para o banco de dados
        [DisplayName("Confirmar Senha")]
        [Required(ErrorMessage = "Por favor, confirme a senha.")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação de senha não correspondem.")]
        public string ConfirmarSenha { get; set; }
        public ICollection<Projeto> Projetos { get; set; }

        public ICollection<Faturamento> Faturamentos { get; set; }

    }
}
