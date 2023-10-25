using System.ComponentModel.DataAnnotations;

namespace CozaStore.ViewModels.Account;

public class LoginVM
{

    [Display(Name = "Email ou Nome de Usuário", Prompt = "Informe seu Email ou Nome de Usuário")]
    [Required(ErrorMessage = "Por favor, informe seu Email ou Nome de Usuário")]
    public string Email { get; set; }

    [Display(Name = "Senha de Acesso", Prompt = "**********")]
    [Required(ErrorMessage = "Por favor, informe sua Senha")]
    [DataType(DataType.Password)]
    public string Senha { get; set; }

    [Display(Name = "Manter Conectado?")]
    public bool Lembrar { get; set; }

    
    public string UrlRetorno { get; set; }
}