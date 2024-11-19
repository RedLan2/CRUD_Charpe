using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class ClienteProduto
    {
        public int ClienteId { get; set; } 
        public Cliente Cliente { get; set; } 
        public int ProdutoId { get; set; } 
        public Produto Produto { get; set;}
    }
}