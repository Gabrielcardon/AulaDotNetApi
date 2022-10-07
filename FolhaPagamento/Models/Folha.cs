using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FolhaPagamento.Models

{
 public class Folha
 
 {

   
    public int FolhaId{get; set;}


   [ForeignKey("Id")] 
   [Column("Id")]
    public int FuncionarioId{get; set;}

    public virtual Funcionario Funcionario {get; set;}
    
    public int valorhora{get; set;}

    public int quantidadeHoras{get; set;}

    public int salarioBruto{get; set;}

    public int impostoRenda{get; set;}

    public int impostoInss{get; set;}

    public int impostoFgts{get; set;}

    public int salarioLiquido{get; set;}
 }
}