using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTaFeito.ControleDeUsuario.Models
{
    public class Prestador
    {   
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(50,ErrorMessage = "O máximo de caracteres é {0}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O máximo de caracteres é {0}")]
        public string SobreNome { get; set; }

        [EmailAddress(ErrorMessage = "Digite um e-mail válido")]
        [MaxLength(50, ErrorMessage = "O máximo de caracteres é {0}")]
        public string Email { get; set; }

        [Display (Name = "Telefone")]
        public string TelefoneFixo { get; set; }

        [Display(Name = "Celular")]
        public string TelefoneCelular { get; set; }
       
        public DateTime DataAtendimentoInicio { get; set; }
        public DateTime DataAtendimentoFinal { get; set; }
    }
}
