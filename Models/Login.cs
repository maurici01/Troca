using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Troca.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Digite seu Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Digite sua senha")]
        public string Senha { get; set; }
    }
}