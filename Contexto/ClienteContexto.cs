using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Contexto
{
    public class ClienteContexto: DbContext
    {
          public ClienteContexto(DbContextOptions<ClienteContexto> options) : base(options)
        {
            
        }
         public DbSet<Cliente> Cliente { get; set; }
         public DbSet<Veiculo> Veiculo{get; set;}
         public DbSet<Endereco> Endereco { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração da relação 1:N
       modelBuilder.Entity<Veiculo>()
           .HasOne(v=>v.cliente)
           .WithMany(c=>c.Veiculo)
           .HasForeignKey(c=>c.clienteId);

           modelBuilder.Entity<Cliente>() 
           .HasOne(c => c.endereco) 
           .WithOne(e => e.cliente) 
           .HasForeignKey<Endereco>(e => e.ClienteId);

    }

}
}