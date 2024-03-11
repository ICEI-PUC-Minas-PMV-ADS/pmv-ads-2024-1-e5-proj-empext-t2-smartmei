using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Smartmei.Models
{
    [Table("Eventos")]
    public class Evento

    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Projeto")]
        [Required(ErrorMessage = "Por favor, informe o nome do projeto.")]
        public int ProjetoId { get; set; }

        [ForeignKey("ProjetoId")]
        public Projeto Projeto { get; set; }

        [DisplayName("Por favor, informe a data de início do evento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataEventoInicio { get; set; }

        [DisplayName("Por favor, informe a data final do evento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataEventoFim { get; set; }

        [DisplayName("Valor da diária (R$)")]
        public decimal ValorDiaria { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar o estado")]
        public Estado Estado { get; set; }

    }


}
