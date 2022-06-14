using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Troca.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Phone(ErrorMessage = "O número de telefone informado não é valido")]
        public string Telefone {get; set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é valido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Senha { get; set; }
        
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cep {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Estado {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Bairro {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeRua {get;set;}

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int? NumeroCasa {get;set;}


        public bool SenhaValida(string senha)
        {
            return Senha == senha;
        }
    }
}