using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class ClienteModelView
    {
        public List<Cliente> Clientes { get; set; }

         public int Total { get; set; }
    public int PageNumber { get; set; }
    public int PageQuantity { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)Total / PageQuantity);
    }
}