using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; } 
        public string NomeProduto { get; set; } 
        public decimal Preco { get; set; } 
        public string Descricao { get; set; } 
       public ICollection<Cliente> Clientes { get; set; }
    }
}