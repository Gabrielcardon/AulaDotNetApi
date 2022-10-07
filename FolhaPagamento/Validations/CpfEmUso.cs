using System.ComponentModel.DataAnnotations;
using FolhaPagamento.Models;
using System.Collections.Generic;
using System.Linq;

namespace FolhaPagamento.Validations

{

public class CpfEmUso : ValidationAttribute
{

 protected override ValidationResult IsValid(object value, ValidationContext validationContext )
 {

   string cpf = (string)value;

    DataContext context = (DataContext)validationContext.GetService(typeof(DataContext));

   Funcionario resultado = context.Funcionarios.FirstOrDefault( funcionarioCadastrado => funcionarioCadastrado.Cpf.Equals(cpf));

   if(resultado == null)
   {

     return ValidationResult.Success;
   }

    return new ValidationResult("Esse funcionario já existe!");
   
 }

}

}