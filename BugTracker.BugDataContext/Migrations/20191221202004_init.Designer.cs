﻿// <auto-generated />
using BugTracker.BugDataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BugTracker.BugDataContext.Migrations
{
    [DbContext(typeof(BugContext))]
    [Migration("20191221202004_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BugTracker.BugDataModel.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ErroneousBehavior")
                        .IsRequired();

                    b.Property<string>("HowToReproduce");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("priorityId");

                    b.HasKey("Id");

                    b.HasIndex("priorityId");

                    b.ToTable("Bugs");
                });

            modelBuilder.Entity("BugTracker.BugDataModel.Priority", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LevelOfPriority");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Priorities");
                });

            modelBuilder.Entity("BugTracker.BugDataModel.Bug", b =>
                {
                    b.HasOne("BugTracker.BugDataModel.Priority", "Priority")
                        .WithMany("Bugs")
                        .HasForeignKey("priorityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
