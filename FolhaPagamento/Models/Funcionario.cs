using System;
using System.ComponentModel.DataAnnotations;
using FolhaPagamento.Validations;

namespace FolhaPagamento.Models

{
 public class Funcionario
 {
   
   
     public Funcionario() => CriadoEm = DateTime.Now;

     public int Id {get; set; }

     [Required(ErrorMessage = "O campo nome é obrigatório!")]
     public string Nome{get;set;}
    
     [Required(ErrorMessage = "O campo cpf é obrigatório!")]
     [StringLength(11, 
     MinimumLength = 11,
     ErrorMessage = "O cpf deve conter 11 caracteres!")]
     [CpfEmUso]
     public string Cpf{get;set;}

     [EmailAddress(ErrorMessage = "Este e-mail é inválido")]
     public string Email{get;set;}

     [Range(0, 1000, ErrorMessage = "O salário deve ser até 1.000 reais")]
     public int Salario{get; set;}

     public DateTime DataNascimento{get;set;}

     public DateTime CriadoEm{get;set;}

 }
}
