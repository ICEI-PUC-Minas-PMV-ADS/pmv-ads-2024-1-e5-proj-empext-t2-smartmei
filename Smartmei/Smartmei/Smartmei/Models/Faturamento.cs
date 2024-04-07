using Smartmei.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartMei.Models
{
    [Table("Faturamento")]
    public class Faturamento
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Mês")]
        [Required(ErrorMessage = "Por favor, informe o mês do faturamento.")]
        public int Mes { get; set; }

        [Required(ErrorMessage = "Por favor, informe o ano do faturamento.")]
        public int Ano { get; set; }

        [DisplayName("Valor bruto recebido (R$)")]
        [Required(ErrorMessage = "Por favor, informe o valor bruto (R$) recebido.")]
        public decimal ValorBruto { get; set; }

        [DisplayName("Custo mensal (R$)")]
        [Required(ErrorMessage = "Por favor, informe o custo (R$) gasto com projetos durante o mês deste faturamento.")]
        public decimal CustoMensal { get; set; }

        [DisplayName("Valor líquido recebido (R$)")]
        [Required(ErrorMessage = "Por favor, informe o valor líquido (R$) recebido.")]
        public decimal ValorLiquidoMensal { get; set; }

        [DisplayName("Profissional")]
        public int MeiId { get; set; }

        [ForeignKey("MeiId")]
        public Mei Mei { get; set; }
    }
}


