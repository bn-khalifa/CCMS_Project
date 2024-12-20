﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ccms.Data;

#nullable disable

namespace ccms.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20231204080712_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ccms.Data.Employee", b =>
                {
                    b.Property<string>("emp_id")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("emp_email")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("emp_name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("emp_password")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("emp_id");

                    b.ToTable("Employee_table");
                });

            modelBuilder.Entity("ccms.Data.History", b =>
                {
                    b.Property<int>("history_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("history_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("history_id"), 1L, 1);

                    b.Property<double>("cost")
                        .HasColumnType("FLOAT(2)");

                    b.Property<string>("date")
                        .IsRequired()
                        .HasColumnType("char(10)");

                    b.Property<string>("employee_id")
                        .IsRequired()
                        .HasColumnType("char(15)");

                    b.Property<string>("student_id")
                        .IsRequired()
                        .HasColumnType("char(15)");

                    b.Property<string>("time_in")
                        .IsRequired()
                        .HasColumnType("char(5)");

                    b.Property<string>("time_out")
                        .IsRequired()
                        .HasColumnType("char(5)");

                    b.HasKey("history_id");

                    b.ToTable("History_table");
                });

            modelBuilder.Entity("ccms.Data.In_students", b =>
                {
                    b.Property<string>("in_student_id")
                        .HasColumnType("varchar(15)");

                    b.Property<string>("in_student_name")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("in_time")
                        .IsRequired()
                        .HasColumnType("char(5)");

                    b.HasKey("in_student_id");

                    b.ToTable("In_student_table");
                });
#pragma warning restore 612, 618
        }
    }
}
