using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Cliente
    {
          public int Id { get; set; }
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Numero { get; set; }
           
            [EmailAddress(ErrorMessage = "Email inválido")]
            public string Email { get; set; }

            public virtual ICollection<Veiculo> Veiculo { get; set; }
            public  Endereco endereco { get; set; }
             public ICollection<Produto> Produtos { get; set; }
            
            
    }
}
