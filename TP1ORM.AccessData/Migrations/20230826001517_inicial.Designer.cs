﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP1ORM.AccessData;

namespace TP1ORM.AccessData.Migrations
{
    [DbContext(typeof(CineContext))]
    [Migration("20230826001517_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TP1ORM.Domain.Entities.Funciones", b =>
                {
                    b.Property<int>("FuncionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("FuncionId");

                    b.HasIndex("PeliculaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Peliculas", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PeliculaId");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Poster = "https://bit.ly/3u3wJIn",
                            Sinopsis = "https://bit.ly/2VXsVMj",
                            Titulo = "Rapido y Furioso",
                            Trailer = "https://bit.ly/2XrPglr"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Poster = "https://bit.ly/3At1JnE",
                            Sinopsis = "https://bit.ly/3zrETvp",
                            Titulo = "En busca de la felicidad",
                            Trailer = "https://bit.ly/3zpfp1x"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Poster = "https://bit.ly/2XygzdK",
                            Sinopsis = "https://bit.ly/3lNVPrc",
                            Titulo = "Mision Imposible",
                            Trailer = "https://bit.ly/3EAIlYo"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Poster = "https://bit.ly/3nQWyub",
                            Sinopsis = "https://bit.ly/3nV2wtZ",
                            Titulo = "Celular",
                            Trailer = "https://bit.ly/3EATp7z"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Poster = "https://bit.ly/3nSbhFk",
                            Sinopsis = "https://bit.ly/3lLgE6e",
                            Titulo = "Bastardos sin gloria ",
                            Trailer = "https://bit.ly/3EDUyLA"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Poster = "https://bit.ly/2XAxjSl",
                            Sinopsis = "https://bit.ly/2ZktTnf",
                            Titulo = "Busqueda Implacable",
                            Trailer = "https://bit.ly/2XygPcI"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Poster = "https://bit.ly/3u03Z39",
                            Sinopsis = "https://bit.ly/3CuWqVj",
                            Titulo = "Harry Potter Prisionero de Azkaban",
                            Trailer = "https://bit.ly/2XIIdVZ"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Poster = "https://bit.ly/3nRE90c",
                            Sinopsis = "https://bit.ly/39tpCiN",
                            Titulo = "Invicto 3",
                            Trailer = "https://bit.ly/3lEU2od"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Poster = "https://bit.ly/3u3xv8f",
                            Sinopsis = "https://bit.ly/3Cy6qwP",
                            Titulo = "Nueve Reinas",
                            Trailer = "https://bit.ly/3krQypO"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Poster = "https://bit.ly/2XKIhof",
                            Sinopsis = "https://bit.ly/39npiCg",
                            Titulo = "Atrapame si puedes",
                            Trailer = "https://bit.ly/2VWI7ZX"
                        });
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Sala", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.HasKey("SalaId");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            SalaId = 1,
                            Capacidad = 5
                        },
                        new
                        {
                            SalaId = 2,
                            Capacidad = 15
                        },
                        new
                        {
                            SalaId = 3,
                            Capacidad = 35
                        });
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Tickets", b =>
                {
                    b.Property<Guid>("TicketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FuncionId")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TicketId", "FuncionId");

                    b.HasIndex("FuncionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Funciones", b =>
                {
                    b.HasOne("TP1ORM.Domain.Entities.Peliculas", "Peliculas")
                        .WithMany("FuncionesNavigator")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP1ORM.Domain.Entities.Sala", "Sala")
                        .WithMany("FuncionesNavigator")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Peliculas");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Tickets", b =>
                {
                    b.HasOne("TP1ORM.Domain.Entities.Funciones", "Funciones")
                        .WithMany("TicketsNavigator")
                        .HasForeignKey("FuncionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Funciones", b =>
                {
                    b.Navigation("TicketsNavigator");
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Peliculas", b =>
                {
                    b.Navigation("FuncionesNavigator");
                });

            modelBuilder.Entity("TP1ORM.Domain.Entities.Sala", b =>
                {
                    b.Navigation("FuncionesNavigator");
                });
#pragma warning restore 612, 618
        }
    }
}
