using SmartMei.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Smartmei.Models
{
    [Table("Projetos")]
    public class Projeto
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Por favor, informe o título do projeto.")]
        public string Nome { get; set; }

        [DisplayName("Cliente")]
        [Required(ErrorMessage = "Por favor, informe o nome do cliente.")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente Cliente { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data de início do projeto")]
        public DateTime DataInicioProjeto { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data final do projeto")]
        public DateTime DataFimProjeto { get; set; }

        [DisplayName("Quantidade de telas")]
        public int QuantidadeTelas { get; set; }

        [DisplayName("Valor da tela (R$)")]
        public decimal ValorTela { get; set; }

        [DisplayName("Valor do projeto (R$)")]
        public decimal ValorTotalProjeto { get; set; }

        [DisplayName("Prazo para pagamento (dias)")]
        public string PrazoPagamento { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data de emissão da NF")]
        public DateTime DataEmissaoNF { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DisplayName("Data de pagamento da NF")]
        public DateTime DataPagamentoNF { get; set; }

        [Display(Name = "Acompanhamento")]
        [Required(ErrorMessage = "Por favor, informe se haverá acompanhamento no evento.")]
        public Acompanhamento Acompanhamento { get; set; }

        [DisplayName("Link do Drive")]
        public string LinkDrive { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }

        [DisplayName("Profissional")]
        public int MeiId { get; set; }

        [ForeignKey("MeiId")]
        public Mei Mei { get; set; }

        public ICollection<Custo> Custos { get; set; }
        public ICollection<Evento> Eventos { get; set; }
    }

    public enum Acompanhamento
    {
        Sim,
        Não
    }
}
