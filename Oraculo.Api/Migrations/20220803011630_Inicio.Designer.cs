﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Oraculo.Api.Models;

#nullable disable

namespace Oraculo.Api.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220803011630_Inicio")]
    partial class Inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Oraculo.Api.Models.Theft", b =>
                {
                    b.Property<double>("NumeroBO")
                        .HasColumnType("double precision")
                        .HasColumnName("NumeroBO");

                    b.Property<int>("Ano_bo")
                        .HasColumnType("integer")
                        .HasColumnName("Ano_bo");

                    b.Property<int>("Ano_fabricacao")
                        .HasColumnType("integer")
                        .HasColumnName("Ano_fabricacao");

                    b.Property<int>("Ano_modelo")
                        .HasColumnType("integer")
                        .HasColumnName("Ano_modelo");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("Bairro");

                    b.Property<string>("Bo_autoria")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("Bo_autoria");

                    b.Property<DateTime>("Bo_emitido")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Bo_emitido");

                    b.Property<DateTime>("Bo_iniciado")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Bo_iniciado");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("Cidade");

                    b.Property<string>("Cidade_veiculo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Cidade_veiculo");

                    b.Property<string>("Corcutis")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Corcutis");

                    b.Property<DateTime>("Datacomunicacao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Datacomunicacao");

                    b.Property<DateTime>("Dataelaboracao")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Dataelaboracao");

                    b.Property<DateTime>("Datanascimento")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Datanascimento");

                    b.Property<DateTime>("Dataocorrencia")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("Dataocorrencia");

                    b.Property<string>("Delegacia_circunscricao")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("Delegacia_circunscricao");

                    b.Property<string>("Delegacia_nome")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("Delegacia_nome");

                    b.Property<string>("Descr_cor_veiculo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("Descr_cor_veiculo");

                    b.Property<string>("Descr_marca_veiculo")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("Descr_marca_veiculo");

                    b.Property<string>("Descr_tipo_veiculo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Descr_tipo_veiculo");

                    b.Property<string>("Descricaolocal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Descricaolocal");

                    b.Property<string>("Desdobramento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Desdobramento");

                    b.Property<string>("Especie")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Especie");

                    b.Property<string>("Estadocivil")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("Estadocivil");

                    b.Property<string>("Exame")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Exame");

                    b.Property<string>("Flagrante")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("Flagrante");

                    b.Property<string>("Grauinstrucao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("Grauinstrucao");

                    b.Property<string>("Horaocorrencia")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("Horaocorrencia");

                    b.Property<int>("Idade")
                        .HasColumnType("integer")
                        .HasColumnName("Idade");

                    b.Property<string>("Latitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Latitude");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("Logradouro");

                    b.Property<string>("Longitude")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Longitude");

                    b.Property<string>("Marca_celular")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Marca_celular");

                    b.Property<string>("Nacionalidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Nacionalidade");

                    b.Property<string>("Naturalidade")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Naturalidade");

                    b.Property<string>("Naturezavinculada")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Naturezavinculada");

                    b.Property<double>("Num_bo")
                        .HasColumnType("double precision")
                        .HasColumnName("Num_bo");

                    b.Property<double>("Numero")
                        .HasColumnType("double precision")
                        .HasColumnName("Numero");

                    b.Property<string>("Numero_boletim")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("Numero_boletim");

                    b.Property<string>("Numero_boletim_principal")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("character varying(40)")
                        .HasColumnName("Numero_boletim_principal");

                    b.Property<string>("Parentesco")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Parentesco");

                    b.Property<string>("Peridoocorrencia")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("Peridoocorrencia");

                    b.Property<string>("Placa_veiculo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("Placa_veiculo");

                    b.Property<string>("Profissao")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("Profissao");

                    b.Property<string>("Quant_celular")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("Quant_celular");

                    b.Property<string>("Relacionamento")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Relacionamento");

                    b.Property<string>("Rubrica")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("Rubrica");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasColumnName("Sexo");

                    b.Property<string>("Solucao")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)")
                        .HasColumnName("Solucao");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Status");

                    b.Property<string>("Tipopessoa")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Tipopessoa");

                    b.Property<string>("Tipovinculo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Tipovinculo");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("character varying(10)")
                        .HasColumnName("Type");

                    b.Property<string>("Uf")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("Uf");

                    b.Property<string>("Uf_veiculo")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("Uf_veiculo");

                    b.Property<string>("Vitimafatal")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("Vitimafatal");

                    b.HasKey("NumeroBO");

                    b.ToTable("Theft");
                });
#pragma warning restore 612, 618
        }
    }
}
