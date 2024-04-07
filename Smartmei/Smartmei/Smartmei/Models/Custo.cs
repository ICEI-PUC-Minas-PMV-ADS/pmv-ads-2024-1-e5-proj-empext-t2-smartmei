using Smartmei.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartMei.Models
{
    [Table("Custos")]
    public class Custo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Passagem aérea (R$)")]
        [Required(ErrorMessage = "Por favor, informe o valor total (R$) gasto com passagens aéreas.")]
        public decimal PassagemAerea { get; set; }

        [DisplayName("Hospedagem (R$)")]
        [Required(ErrorMessage = "Por favor, informe o valor total (R$) gasto com hospedagens.")]
        public decimal Hospedagem { get; set; }

        [DisplayName("Deslocamento (R$)")]
        [Required(ErrorMessage = "Por favor, informe o valor total (R$) gasto com deslocamentos.")]
        public decimal Deslocamento { get; set; }

        [DisplayName("Alimentação (R$)")]
        [Required(ErrorMessage = "Por favor, informe o valor total (R$) gasto com alimentação.")]
        public decimal Alimentacao { get; set; }

        [DisplayName("Custo total (R$)")]
        [Required(ErrorMessage = "Por favor, informe o valor total (R$) dos custos do projeto.")]
        public decimal CustoTotal { get; set; }

        [DisplayName("Projeto")]
        public int ProjetoId { get; set; }

        [ForeignKey("ProjetoId")]
        public Projeto Projeto { get; set; }
    }
}
