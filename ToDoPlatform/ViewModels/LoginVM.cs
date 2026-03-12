using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Pqc.Crypto.Picnic;

namespace ToDoPlatform.ViewModels;

    public class LoginVM
    {
        [Display(Name = "E-mail", Prompt = "seu@email.com")]
        [Required(ErrorMessage = " O e-mail de acesso é obrigatorio!")]
        [EmailAddress(ErrorMessage = "Informe um e-mail válido")]
       public string Email  { get; set; }

       [DataType(DataType.Password)]
       [Display(Name ="Senha", Prompt = "*******")]
       [Required(ErrorMessage = " A senha de acesso é obrigatoria!")]

       public string Password  { get; set; }

       [Display(Name = "Manter conectado?")]

       public bool RememberMe  { get; set; }

       [HiddenInput]
       public string ReturnUrl  { get; set; }
    }
