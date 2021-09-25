﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ofi.App.Persistencia;

namespace Ofi.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    [Migration("20210923003311_Entidades")]
    partial class Entidades
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ofi.App.Dominio.Gobernacion", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("oficinas")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("gobernaciones");
                });

            modelBuilder.Entity("Ofi.App.Dominio.Oficina", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("GobernadorYAsesorid")
                        .HasColumnType("int");

                    b.Property<int>("aforoMaximo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("GobernadorYAsesorid");

                    b.ToTable("oficinas");
                });

            modelBuilder.Entity("Ofi.App.Dominio.Persona", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<int>("estadoCovid")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Ofi.App.Dominio.ReporteCovid", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("fechaDiagnostico")
                        .HasColumnType("datetime2");

                    b.Property<int?>("personaid")
                        .HasColumnType("int");

                    b.Property<string>("sintomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("tiempoAistamiento")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personaid");

                    b.ToTable("reporte_covid");
                });

            modelBuilder.Entity("Ofi.App.Dominio.Secretaria", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("numeroOficinas")
                        .HasColumnType("int");

                    b.Property<int>("tipoSecretaria")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("secretarias");
                });

            modelBuilder.Entity("Ofi.App.Dominio.GobernadorYAsesor", b =>
                {
                    b.HasBaseType("Ofi.App.Dominio.Persona");

                    b.HasDiscriminator().HasValue("GobernadorYAsesor");
                });

            modelBuilder.Entity("Ofi.App.Dominio.PersonalDeAseo", b =>
                {
                    b.HasBaseType("Ofi.App.Dominio.Persona");

                    b.Property<int>("turno")
                        .HasColumnType("int");

                    b.Property<int?>("unidadServicioid")
                        .HasColumnType("int");

                    b.HasIndex("unidadServicioid");

                    b.HasDiscriminator().HasValue("PersonalDeAseo");
                });

            modelBuilder.Entity("Ofi.App.Dominio.ProveedoresDeServicio", b =>
                {
                    b.HasBaseType("Ofi.App.Dominio.Persona");

                    b.Property<string>("servicioRealizado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("unidadServicioid")
                        .HasColumnType("int")
                        .HasColumnName("ProveedoresDeServicio_unidadServicioid");

                    b.HasIndex("unidadServicioid");

                    b.HasDiscriminator().HasValue("ProveedoresDeServicio");
                });

            modelBuilder.Entity("Ofi.App.Dominio.SecretariosDeDespacho", b =>
                {
                    b.HasBaseType("Ofi.App.Dominio.Persona");

                    b.Property<int?>("despachoid")
                        .HasColumnType("int");

                    b.HasIndex("despachoid");

                    b.HasDiscriminator().HasValue("SecretariosDeDespacho");
                });

            modelBuilder.Entity("Ofi.App.Dominio.Oficina", b =>
                {
                    b.HasOne("Ofi.App.Dominio.GobernadorYAsesor", null)
                        .WithMany("oficinasVisitadas")
                        .HasForeignKey("GobernadorYAsesorid");
                });

            modelBuilder.Entity("Ofi.App.Dominio.ReporteCovid", b =>
                {
                    b.HasOne("Ofi.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaid");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("Ofi.App.Dominio.PersonalDeAseo", b =>
                {
                    b.HasOne("Ofi.App.Dominio.Secretaria", "unidadServicio")
                        .WithMany()
                        .HasForeignKey("unidadServicioid");

                    b.Navigation("unidadServicio");
                });

            modelBuilder.Entity("Ofi.App.Dominio.ProveedoresDeServicio", b =>
                {
                    b.HasOne("Ofi.App.Dominio.Secretaria", "unidadServicio")
                        .WithMany()
                        .HasForeignKey("unidadServicioid");

                    b.Navigation("unidadServicio");
                });

            modelBuilder.Entity("Ofi.App.Dominio.SecretariosDeDespacho", b =>
                {
                    b.HasOne("Ofi.App.Dominio.Oficina", "despacho")
                        .WithMany()
                        .HasForeignKey("despachoid");

                    b.Navigation("despacho");
                });

            modelBuilder.Entity("Ofi.App.Dominio.GobernadorYAsesor", b =>
                {
                    b.Navigation("oficinasVisitadas");
                });
#pragma warning restore 612, 618
        }
    }
}