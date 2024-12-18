﻿// <auto-generated />
using CRUD.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRUD.Migrations
{
    [DbContext(typeof(ClienteContexto))]
    [Migration("20241119095821_AddClienteAndProduto")]
    partial class AddClienteAndProduto
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClienteProduto", b =>
                {
                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.HasKey("ClienteId", "ProdutoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("ClienteProduto");
                });

            modelBuilder.Entity("CRUD.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("CRUD.Models.Endereco", b =>
                {
                    b.Property<int>("EnderecoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("EnderecoId");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.ToTable("Endereco");
                });

            modelBuilder.Entity("CRUD.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ProdutoId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("CRUD.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("placa")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("clienteId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("ClienteProduto", b =>
                {
                    b.HasOne("CRUD.Models.Cliente", null)
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CRUD.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CRUD.Models.Endereco", b =>
                {
                    b.HasOne("CRUD.Models.Cliente", "cliente")
                        .WithOne("endereco")
                        .HasForeignKey("CRUD.Models.Endereco", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("CRUD.Models.Veiculo", b =>
                {
                    b.HasOne("CRUD.Models.Cliente", "cliente")
                        .WithMany("Veiculo")
                        .HasForeignKey("clienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("cliente");
                });

            modelBuilder.Entity("CRUD.Models.Cliente", b =>
                {
                    b.Navigation("Veiculo");

                    b.Navigation("endereco")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
