using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class Endereco
{
    public int EnderecoId { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }

    // Chave estrangeira e propriedade de navegação
    public int ClienteId { get; set; }
    public Cliente cliente { get; set; }
}

}