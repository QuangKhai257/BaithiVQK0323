﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcMovie.Data;

#nullable disable

namespace BaithiVQK0323.Migrations
{
    [DbContext(typeof(MvcMovieContext))]
    partial class MvcMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("BaithiVQK0323.Models.VQKcau3", b =>
                {
                    b.Property<string>("hoten")
                        .HasColumnType("TEXT");

                    b.Property<string>("diachi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("gioitinh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("hoten");

                    b.ToTable("VQKcau3");
                });
#pragma warning restore 612, 618
        }
    }
}
