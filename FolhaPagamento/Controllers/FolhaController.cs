using Microsoft.AspNetCore.Mvc;
using FolhaPagamento.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace FolhaPagamento.Controllers
{
    
     [ApiController]
     [Route("api/folha")]

   public class FolhaController : ControllerBase
    {

      private readonly DataContext _context;

   public FolhaController(DataContext context) => _context = context;
   

    private static List<Folha> folhas = new List<Folha>();


    [HttpGet]
    [Route("Listar")]
    public IActionResult Listar() => Ok(_context.Folhas.Include(Folhas => Folhas.Funcionario).ToList());

    [HttpPost]
    [Route("cadastrar")]
   public IActionResult Cadastrar([FromBody] Folha folha)
   {

    
     folha.salarioBruto = folha.quantidadeHoras * folha.valorhora;


     _context.Folhas.Add(folha);
     _context.SaveChanges();
     return Created("",folha);

   }

    [HttpGet]
    [Route("buscar/{cpf}{mes}{ano}")]
    public IActionResult Buscar([FromRoute] string cpf, string mes, string ano)
    {
      
      Folha folha = _context.Folhas.Include(Folhas => Folhas.Funcionario).FirstOrDefault(
      folhaCadastrado => folhaCadastrado.Funcionario.Cpf.Equals(cpf)
      );
     
     return folha != null ? Ok(folha) : NotFound();
     
    } 

   /* [HttpGet]
    [Route("filtrar/{cpf}{mes}{ano}")]
    public IActionResult Find([FromRoute] string cpf, string mes, string ano)
    {
      
      Folha folha = _context.Folhas.Include(Folhas => Folhas.Funcionario).Find(
      folhaCadastrado => folhaCadastrado.Funcionario.Cpf.Equals(cpf)
      );
     
     return folha != null ? Ok(folha) : NotFound();
     
    } */

    }
}