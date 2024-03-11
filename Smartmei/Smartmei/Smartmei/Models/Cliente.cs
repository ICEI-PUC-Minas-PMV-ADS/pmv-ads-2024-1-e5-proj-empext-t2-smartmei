﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Smartmei.Models
{
    [Table("Clientes")]
    public class Cliente
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("Nome completo")]
        [Required(ErrorMessage = "Obrigatório informar o nome do cliente")]
        public string Nome { get; set; }

        [StringLength(18, MinimumLength = 18, ErrorMessage = "Este campo precisa ter 18 caracteres!")]
        [Required(ErrorMessage = "Por favor, informe o CNPJ do cliente/empresa.")]
        public int CNPJ { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o telefone")]
        [RegularExpression(@"^\(?\d{2}\)?[-.\s]?\d{4,5}[-.\s]?\d{4}$", ErrorMessage = "Formato de telefone inválido")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress(ErrorMessage = "Este não é um formato válido de e-mail!")]
        [Required(ErrorMessage = "Por favor, informe o e-mail do cliente/empresa.")]
        public int Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Obrigatório selecionar o estado")]
        public Estado Estado { get; set; }

        [DisplayName("Product Owner")]
        [Required(ErrorMessage = "Por favor, informe o nome do Product Owner do cliente/empresa.")]
        public string ProductOwner { get; set; }

        [DisplayName("Observação")]
        [StringLength(50, ErrorMessage = "Este campo precisa ter no máximo 50 caracteres.")]
        public string Observacao { get; set; }


    }

    public enum Estado
    {
        AC,
        AL,
        AP,
        AM,
        BA,
        CE,
        DF,
        ES,
        GO,
        MA,
        MT,
        MS,
        MG,
        PA,
        PB,
        PR,
        PE,
        PI,
        RJ,
        RN,
        RS,
        RO,
        RR,
        SC,
        SP,
        SE,
        TO

    }
}



