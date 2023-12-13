﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Somativa.Data;

#nullable disable

namespace Somativa.Migrations
{
    [DbContext(typeof(SprintContext))]
    [Migration("20231212163207_Imagem")]
    partial class Imagem
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Somativa.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("tbCategorias", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.Cliente", b =>
                {
                    b.Property<Guid>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Nascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteId");

                    b.ToTable("tbClientes", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.Compra", b =>
                {
                    b.Property<Guid>("CompraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("CompraId");

                    b.ToTable("tbCompras", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.CompraItem", b =>
                {
                    b.Property<Guid>("CompraItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Unitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("CompraItemId");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("tbCompraItens", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.Fornecedor", b =>
                {
                    b.Property<Guid>("FornecedorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FornecedorId");

                    b.ToTable("tbFornecedores", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.Produto", b =>
                {
                    b.Property<Guid>("ProdutoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<Guid>("FornecedorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Imagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoId");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("tbProdutos", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.Venda", b =>
                {
                    b.Property<Guid>("VendaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("Nota")
                        .HasColumnType("int");

                    b.HasKey("VendaId");

                    b.HasIndex("ClienteId");

                    b.ToTable("tbVendas", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.VendaItem", b =>
                {
                    b.Property<Guid>("VendaItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Unitario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("VendaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("VendaItemId");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("tbVendaItens", (string)null);
                });

            modelBuilder.Entity("Somativa.Models.CompraItem", b =>
                {
                    b.HasOne("Somativa.Models.Compra", "Compra")
                        .WithMany("CompraItems")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Somativa.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Somativa.Models.Produto", b =>
                {
                    b.HasOne("Somativa.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Somativa.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Somativa.Models.Venda", b =>
                {
                    b.HasOne("Somativa.Models.Cliente", "Cliente")
                        .WithMany("Venda")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Somativa.Models.VendaItem", b =>
                {
                    b.HasOne("Somativa.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Somativa.Models.Venda", "Venda")
                        .WithMany("VendaItems")
                        .HasForeignKey("VendaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Somativa.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Somativa.Models.Cliente", b =>
                {
                    b.Navigation("Venda");
                });

            modelBuilder.Entity("Somativa.Models.Compra", b =>
                {
                    b.Navigation("CompraItems");
                });

            modelBuilder.Entity("Somativa.Models.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Somativa.Models.Venda", b =>
                {
                    b.Navigation("VendaItems");
                });
#pragma warning restore 612, 618
        }
    }
}
