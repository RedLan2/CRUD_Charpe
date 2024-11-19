using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Contexto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUD.Models;

namespace CRUD.Controllers
{
    [Route("[controller]")]
    public class ClienteController : Controller
    {
        private readonly ClienteContexto _context;
         public ClienteController(ClienteContexto context)
        {
            _context = context;
        }
        [HttpGet]
          public IActionResult Index()
            {
                return View();
            }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
        }
        [HttpPost("produto")]
        public IActionResult CreateProduto(Produto produto){
            _context.Produto.Add(produto);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("veiculo")]
        public IActionResult CreateVeiculo(Veiculo veiculo)
        {
                _context.Veiculo.Add(veiculo);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
        }

      /*  [HttpPost("endereco")]
        public IActionResult Endereco(Endereco endereco)
        {
            if (ModelState.IsValid)
            {
                _context.Endereco.Add(endereco);
                _context.SaveChanges();
                return RedirectToAction(nameof(Endereco));
            }
            return View(endereco);
        }*/

    [HttpPost("endereco")]
     public IActionResult Endereco(EnderecoDTO enderecoDTO) {

            var endereco=new Endereco{
                CEP=enderecoDTO.CEP,
                Numero=enderecoDTO.Numero,
                Cidade=enderecoDTO.Cidade,
                Rua=enderecoDTO.Rua,
                Estado=enderecoDTO.Estado,
                ClienteId=enderecoDTO.ClienteId

            };
            _context.Add(endereco);
           _context.SaveChanges();
           return Ok(enderecoDTO);
     }

        [HttpGet("cadastro-endereco")] 
        public IActionResult Endereco() 
        { 
            return View(); 
        } 
        
        [HttpGet("listagem")]
        public IActionResult Listagem(int pageNumber = 1, int pageQuantity = 3)
    {
        var clientes = _context.Cliente
            .Skip((pageNumber - 1) * pageQuantity)
            .Take(pageQuantity)
            .ToList();

        var total = _context.Cliente.Count();

        var model = new ClienteModelView
        {
            Clientes = clientes,
            Total = total,
            PageNumber = pageNumber,
            PageQuantity = pageQuantity
        };

        return View(model);
    }
     [HttpPost("deletar/{id}")]
        public IActionResult Deletar(Cliente cliente)
        {
            var contatoCliente = _context.Cliente.Find(cliente.Id);
            _context.Cliente.Remove(contatoCliente);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
         [HttpGet("editar")]
        public IActionResult Editar(int id)
        {
            var cliente = _context.Cliente.Find(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost("editar")]
        public IActionResult Editar(Cliente cliente)
        {
            var clienteBanco = _context.Cliente.Find(cliente.Id);

                clienteBanco.Nome = cliente.Nome;
                clienteBanco.Numero = cliente.Numero;
                clienteBanco.Email = cliente.Email;

                _context.Cliente.Update(clienteBanco);
                _context.SaveChanges();
            
            return RedirectToAction(nameof(Index));
        }

        }
}