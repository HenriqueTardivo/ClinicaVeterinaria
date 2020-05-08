﻿// <auto-generated />
using System;
using ClinicaVeterinaria.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClinicaVeterinaria.Migrations
{
    [DbContext(typeof(ClinicaVeterinariaContext))]
    [Migration("20200507214835_First")]
    partial class First
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ClinicaVeterinaria.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Idade");

                    b.Property<string>("Nome");

                    b.Property<string>("Observacoes");

                    b.Property<string>("Raca");

                    b.Property<string>("TipoAnimal");

                    b.Property<int?>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Consulta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AnimalId");

                    b.Property<float>("Preco");

                    b.Property<string>("Resumo");

                    b.HasKey("Id");

                    b.HasIndex("AnimalId");

                    b.ToTable("Consulta");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Exame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ConsultaId");

                    b.Property<string>("Descricao");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaId");

                    b.ToTable("Exame");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Mediacamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ConsultaId");

                    b.Property<string>("Descricao");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.HasIndex("ConsultaId");

                    b.ToTable("Mediacamento");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cidade");

                    b.Property<string>("Endereco");

                    b.Property<string>("Nome");

                    b.Property<string>("Telefone");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Animal", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Usuario", "Usuario")
                        .WithMany("Animals")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Consulta", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Animal", "Animal")
                        .WithMany()
                        .HasForeignKey("AnimalId");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Exame", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Consulta")
                        .WithMany("exames")
                        .HasForeignKey("ConsultaId");
                });

            modelBuilder.Entity("ClinicaVeterinaria.Models.Mediacamento", b =>
                {
                    b.HasOne("ClinicaVeterinaria.Models.Consulta")
                        .WithMany("mediacamentos")
                        .HasForeignKey("ConsultaId");
                });
#pragma warning restore 612, 618
        }
    }
}