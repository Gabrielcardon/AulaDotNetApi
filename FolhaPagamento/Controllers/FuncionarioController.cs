using Microsoft.AspNetCore.Mvc;
using FolhaPagamento.Models;
using System.Collections.Generic;
using System.Linq;



namespace FolhaPagamento.Controllers
{
    
     [ApiController]
     [Route("api/funcionario")]

   public class FuncionarioController : ControllerBase
    {

      private readonly DataContext _context;

   public FuncionarioController(DataContext context) => _context = context;
   

    private static List<Funcionario> funcionarios = new List<Funcionario>();


    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar() => Ok(_context.Funcionarios.ToList());

    [HttpPost]
    [Route("cadastrar")]
   public IActionResult Cadastrar([FromBody] Funcionario funcionario)
   {

     _context.Funcionarios.Add(funcionario);
     _context.SaveChanges();
     return Created("",funcionario);

   }

    [HttpGet]
    [Route("buscar/{cpf}")]
    public IActionResult Buscar([FromRoute] string cpf)
    {
      
      Funcionario funcionario = _context.Funcionarios.FirstOrDefault(
      funcionarioCadastrado => funcionarioCadastrado.Cpf.Equals(cpf)
      );
     
     return funcionario != null ? Ok(funcionario) : NotFound();

   /*  if(funcionario != null)
     {
      return  Ok(funcionario);
     }

         return NotFound();*/

        /*foreach (Funcionario funcionarioCadastrado in funcionarios)
        {
           if(funcionarioCadastrado.Cpf.Equals(cpf))
            {
                return Ok(funcionarioCadastrado);
            } 
        }*/
     
    } 

    [HttpDelete]
    [Route("deletar/{id}")]
    public IActionResult deletar([FromRoute] int id)
    {
      
     
    //  Funcionario funcionario = _context.Funcionarios.FirstOrDefault(funcionarioCadastrado => funcionarioCadastrado.Id == id);

      Funcionario funcionario = _context.Funcionarios.Find(id);

      if(funcionario != null)
      {
        _context.Funcionarios.Remove(funcionario);
        _context.SaveChanges();
        return Ok(funcionario);
      }
      return NotFound();
     
    } 

     [HttpPatch]
    [Route("alterar")]
    public IActionResult Alterar([FromBody] Funcionario funcionario)
    //{
      
      /*Funcionario funcionarioBuscado = funcionarios.FirstOrDefault(
        funcionarioCadastrado => funcionarioCadastrado.Cpf.Equals(funcionario.Cpf));
      if(funcionarioBuscado != null)*/
      {
      //  funcionarioBuscado.Nome = funcionario.Nome;

       _context.Funcionarios.Update(funcionario);
        _context.SaveChanges();
        return Ok(funcionario);
      }
   //   return NotFound();
     
    //} 

  /*  [HttpPut]
    [Route("editar/{nome}")]
    public IActionResult Editar([FromRoute] string nome)
   {
   
   using (var funcionario = new Funcionario())
        {

            if (funcionario != null)
            {
                nome = funcionario.nome;

                funcionario.Add();
            }
            else
            {
                return NotFound();
            }
        }
   }  */
    }
}