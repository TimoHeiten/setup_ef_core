﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using simple_ef_core.Data;

namespace simple_ef_core.Data.Migrations
{
    [DbContext(typeof(TodoItemContext))]
    partial class TodoItemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("simple_ef_core.Models.TodoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("Date");

                    b.Property<bool>("IsDone");

                    b.HasKey("Id");

                    b.ToTable("TodoItems");
                });
#pragma warning restore 612, 618
        }
    }
}
