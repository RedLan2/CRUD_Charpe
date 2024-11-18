using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models
{
    public class EnderecoDTO
    {
    public int EnderecoId { get; set; }
    public string Rua { get; set; }
    public string Numero { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string CEP { get; set; }
    public int ClienteId { get; set; }

    public EnderecoDTO ConvertToDTO(Endereco endereco){
        return new EnderecoDTO{
            EnderecoId= endereco.EnderecoId,
            CEP=endereco.CEP,
            Cidade=endereco.Cidade,
            Estado=endereco.Estado,
            Numero=endereco.Numero,
            Rua=endereco.Rua,
            ClienteId=endereco.ClienteId

        };
    }
    }
}