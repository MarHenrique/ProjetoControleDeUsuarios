using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjetoTaFeito.ControleDeUsuario.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Codigo")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Lembrar neste navegador?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [Display(Name = "Lembre-me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O máximo de caracteres é {0}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Sobrenome é obrigatório")]
        [MaxLength(50, ErrorMessage = "O máximo de caracteres é {0}")]
        public string SobreNome { get; set; }


        [DataType(DataType.PhoneNumber, ErrorMessage = "Numero invalido")]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$", ErrorMessage = "Numero invalido")]
        [Display(Name = "Telefone")]
        public string TelefoneFixo { get; set; }

        [DataType(DataType.PhoneNumber)]
        //[DisplayFormat(DataFormatString = "{0:(##)####-####}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$", ErrorMessage = "Celular invalido")]
        [Display(Name = "Celular")]
        public string TelefoneCelular { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} precisa de no minimo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Password", ErrorMessage = "A senha não está compativel.")]
        public string ConfirmPassword { get; set; }

        public EnumTipoUsuario TipoUsuario { get; set; }
    }

    public enum EnumTipoUsuario
    {
        Prestador, Cliente
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} precisa de no minimo {2} caracteres.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar senha")]
        [Compare("Password", ErrorMessage = "A senha não está compativel.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Codigo")]
        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
