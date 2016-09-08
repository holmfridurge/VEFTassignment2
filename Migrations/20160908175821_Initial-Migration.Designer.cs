using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using VEFTassignment2.Models;

namespace VEFTassignment2.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20160908175821_Initial-Migration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Semester")
                        .IsRequired();

                    b.Property<DateTime>("StartDate");

                    b.Property<string>("TemplateID");

                    b.HasKey("ID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebApplication.Models.Student", b =>
                {
                    b.Property<string>("SSN");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("StudentID");

                    b.HasKey("SSN");

                    b.HasIndex("StudentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("WebApplication.Models.Student", b =>
                {
                    b.HasOne("WebApplication.Models.Course")
                        .WithMany("Students")
                        .HasForeignKey("StudentID");
                });
        }
    }
}
