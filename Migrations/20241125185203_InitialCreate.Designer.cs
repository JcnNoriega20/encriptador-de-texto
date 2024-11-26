﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SistGestNotas.Data;

#nullable disable

namespace SistGestNotas.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241125185203_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SistGestNotas.Models.Actividad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AsignaturaId")
                        .HasColumnType("int");

                    b.Property<string>("NombreActividad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NotaActividad")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("AsignaturaId");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("SistGestNotas.Models.Acudiente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("FechaIngreso")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Acudiente");
                });

            modelBuilder.Entity("SistGestNotas.Models.Asignatura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BoletinId")
                        .HasColumnType("int");

                    b.Property<int?>("GradoId")
                        .HasColumnType("int");

                    b.Property<string>("NombreAsignatura")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoletinId");

                    b.HasIndex("GradoId");

                    b.ToTable("Asignaturas");
                });

            modelBuilder.Entity("SistGestNotas.Models.Boletin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("EstudianteId")
                        .HasColumnType("int");

                    b.Property<int?>("LogroAsignadoId")
                        .HasColumnType("int");

                    b.Property<int?>("PeriodoAcademicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstudianteId");

                    b.HasIndex("LogroAsignadoId");

                    b.HasIndex("PeriodoAcademicoId");

                    b.ToTable("Boletines");
                });

            modelBuilder.Entity("SistGestNotas.Models.Docente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("FechaIngreso")
                        .HasColumnType("date");

                    b.Property<int?>("GradoAsignadoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GradoAsignadoId");

                    b.ToTable("Docentes");
                });

            modelBuilder.Entity("SistGestNotas.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AcudienteId")
                        .HasColumnType("int");

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateOnly>("FechaIngreso")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<int>("GradoActualId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RolUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AcudienteId");

                    b.HasIndex("GradoActualId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("SistGestNotas.Models.Grado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("nombreGrado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Grados");
                });

            modelBuilder.Entity("SistGestNotas.Models.Logros", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DetalleLogro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreLogro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Logros");
                });

            modelBuilder.Entity("SistGestNotas.Models.PeriodoAcademico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<string>("NombrePeriodo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PeriodoAcademico");
                });

            modelBuilder.Entity("SistGestNotas.Models.Actividad", b =>
                {
                    b.HasOne("SistGestNotas.Models.Asignatura", null)
                        .WithMany("Actividades")
                        .HasForeignKey("AsignaturaId");
                });

            modelBuilder.Entity("SistGestNotas.Models.Asignatura", b =>
                {
                    b.HasOne("SistGestNotas.Models.Boletin", null)
                        .WithMany("Asignaturas")
                        .HasForeignKey("BoletinId");

                    b.HasOne("SistGestNotas.Models.Grado", null)
                        .WithMany("Asignaturas")
                        .HasForeignKey("GradoId");
                });

            modelBuilder.Entity("SistGestNotas.Models.Boletin", b =>
                {
                    b.HasOne("SistGestNotas.Models.Estudiante", "Estudiante")
                        .WithMany()
                        .HasForeignKey("EstudianteId");

                    b.HasOne("SistGestNotas.Models.Logros", "LogroAsignado")
                        .WithMany()
                        .HasForeignKey("LogroAsignadoId");

                    b.HasOne("SistGestNotas.Models.PeriodoAcademico", "PeriodoAcademico")
                        .WithMany()
                        .HasForeignKey("PeriodoAcademicoId");

                    b.Navigation("Estudiante");

                    b.Navigation("LogroAsignado");

                    b.Navigation("PeriodoAcademico");
                });

            modelBuilder.Entity("SistGestNotas.Models.Docente", b =>
                {
                    b.HasOne("SistGestNotas.Models.Grado", "GradoAsignado")
                        .WithMany()
                        .HasForeignKey("GradoAsignadoId");

                    b.Navigation("GradoAsignado");
                });

            modelBuilder.Entity("SistGestNotas.Models.Estudiante", b =>
                {
                    b.HasOne("SistGestNotas.Models.Acudiente", "Acudiente")
                        .WithMany()
                        .HasForeignKey("AcudienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SistGestNotas.Models.Grado", "GradoActual")
                        .WithMany()
                        .HasForeignKey("GradoActualId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acudiente");

                    b.Navigation("GradoActual");
                });

            modelBuilder.Entity("SistGestNotas.Models.Asignatura", b =>
                {
                    b.Navigation("Actividades");
                });

            modelBuilder.Entity("SistGestNotas.Models.Boletin", b =>
                {
                    b.Navigation("Asignaturas");
                });

            modelBuilder.Entity("SistGestNotas.Models.Grado", b =>
                {
                    b.Navigation("Asignaturas");
                });
#pragma warning restore 612, 618
        }
    }
}
