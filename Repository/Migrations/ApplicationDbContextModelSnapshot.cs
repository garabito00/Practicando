// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository.Context;

namespace Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Models.BolantePago", b =>
                {
                    b.Property<int>("Bolante_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("AFP")
                        .HasColumnName("afp")
                        .HasColumnType("double");

                    b.Property<bool>("Bonificacion_Asistencia")
                        .HasColumnName("bonificacion_asistencia")
                        .HasColumnType("boolean");

                    b.Property<double>("Bono_Extra")
                        .HasColumnName("bono_extra")
                        .HasColumnType("double");

                    b.Property<int>("Empleado_Id")
                        .HasColumnName("empleado_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnName("Fecha")
                        .HasColumnType("datetime");

                    b.Property<double>("Horas_Extra")
                        .HasColumnName("horas_extra")
                        .HasColumnType("double");

                    b.Property<double>("Horas_Normales")
                        .HasColumnName("horas_normales")
                        .HasColumnType("double");

                    b.Property<double>("Pagos_Horas_Extras")
                        .HasColumnName("pagos_horas_extra")
                        .HasColumnType("double");

                    b.Property<double>("Pagos_Horas_Normales")
                        .HasColumnName("pagos_horas_normales")
                        .HasColumnType("double");

                    b.Property<double>("Seguro_Salud")
                        .HasColumnName("seguro_salud")
                        .HasColumnType("double");

                    b.Property<double>("Total_Periodo")
                        .HasColumnName("total_periodo")
                        .HasColumnType("double");

                    b.HasKey("Bolante_Id");

                    b.HasIndex("Empleado_Id");

                    b.ToTable("bolantePago");
                });

            modelBuilder.Entity("Models.CuentaBanco", b =>
                {
                    b.Property<int>("Cuenta_Banco_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasColumnName("banco")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Empleado_Id")
                        .HasColumnType("int");

                    b.Property<int>("Numero_Cuenta")
                        .HasColumnName("numero_cuenta")
                        .HasColumnType("int");

                    b.Property<string>("Tipo_Cuenta")
                        .HasColumnName("tipo_cuenta")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.HasKey("Cuenta_Banco_Id");

                    b.HasIndex("Empleado_Id");

                    b.ToTable("CuentaBanco");
                });

            modelBuilder.Entity("Models.Empleado", b =>
                {
                    b.Property<int>("Empleado_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnName("apellido")
                        .HasColumnType("VARCHAR(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnName("cedula")
                        .HasColumnType("VARCHAR(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("VARCHAR(25)")
                        .HasMaxLength(25);

                    b.Property<int>("Posicion_id")
                        .HasColumnName("posicion_id")
                        .HasColumnType("int");

                    b.Property<double>("Salario_x_hora")
                        .HasColumnName("salario_hora")
                        .HasColumnType("double");

                    b.Property<string>("Tipo_Empleado")
                        .IsRequired()
                        .HasColumnName("tipo_empleado")
                        .HasColumnType("VARCHAR(25)")
                        .HasMaxLength(25);

                    b.Property<int>("Ubicacion_Id")
                        .HasColumnName("ubicacion_id")
                        .HasColumnType("int");

                    b.HasKey("Empleado_Id");

                    b.HasIndex("Posicion_id");

                    b.HasIndex("Ubicacion_Id");

                    b.ToTable("empelados");
                });

            modelBuilder.Entity("Models.Posicion", b =>
                {
                    b.Property<int>("Posicion_Id")
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Proyecto_Id")
                        .HasColumnName("proyecto_id")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnName("titulo")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.HasKey("Posicion_Id");

                    b.ToTable("Posicion");
                });

            modelBuilder.Entity("Models.Proyecto", b =>
                {
                    b.Property<int>("Proyecto_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Compania")
                        .IsRequired()
                        .HasColumnName("compania")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.HasKey("Proyecto_Id");

                    b.ToTable("Proyecto");
                });

            modelBuilder.Entity("Models.Ubicacion", b =>
                {
                    b.Property<int>("Ubicacion_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnName("lugar")
                        .HasColumnType("VARCHAR(50)")
                        .HasMaxLength(50);

                    b.HasKey("Ubicacion_Id");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("Models.BolantePago", b =>
                {
                    b.HasOne("Models.Empleado", "Empleado")
                        .WithMany("BolantePagos")
                        .HasForeignKey("Empleado_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.CuentaBanco", b =>
                {
                    b.HasOne("Models.Empleado", "Empleado")
                        .WithMany("CuentaBancos")
                        .HasForeignKey("Empleado_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Empleado", b =>
                {
                    b.HasOne("Models.Posicion", "Posicion")
                        .WithMany("Empleados")
                        .HasForeignKey("Posicion_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Ubicacion", "Ubicacion")
                        .WithMany("Empleados")
                        .HasForeignKey("Ubicacion_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Posicion", b =>
                {
                    b.HasOne("Models.Proyecto", "Proyecto")
                        .WithMany("Posiciones")
                        .HasForeignKey("Posicion_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
