using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Veiculo
    {
       
        public int Id { get; set; }
        
        public string placa {get; set;}
        public int clienteId { get; set; }
        [NotMapped]
        public virtual Cliente? cliente{get;set;}
    }
}