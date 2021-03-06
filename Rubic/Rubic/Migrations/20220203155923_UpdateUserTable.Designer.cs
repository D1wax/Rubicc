// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rubic.DbContext;

namespace Rubic.Migrations
{
    [DbContext(typeof(MoneyBotContext))]
    [Migration("20220203155923_UpdateUserTable")]
    partial class UpdateUserTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21");

            modelBuilder.Entity("Rubic.Models.Money", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Operation")
                        .HasColumnType("TEXT");

                    b.Property<int>("Summ")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Moneys");
                });

            modelBuilder.Entity("Rubic.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .HasColumnType("TEXT");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PhoneNumberPrefix")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Rubic.Models.Money", b =>
                {
                    b.HasOne("Rubic.Models.User", "User")
                        .WithMany("Moneys")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
