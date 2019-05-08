﻿// <auto-generated />
using MP_Couture;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MP_Couture.Migrations
{
    [DbContext(typeof(MP_Context))]
    partial class MP_ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MP_Couture.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartItems");

                    b.Property<int>("CustomerID");

                    b.Property<decimal>("ItemPrice");

                    b.Property<int>("Quantity");

                    b.HasKey("CartID")
                        .HasName("PK_Carts");

                    b.HasIndex("CustomerID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("MP_Couture.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("FistName");

                    b.Property<string>("LastName");

                    b.HasKey("CustomerID")
                        .HasName("PK_Customers");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MP_Couture.Cart", b =>
                {
                    b.HasOne("MP_Couture.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
