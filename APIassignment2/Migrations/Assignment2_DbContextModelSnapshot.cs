﻿// <auto-generated />
using APIassignment2.Domein;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIassignment2.Migrations
{
    [DbContext(typeof(Assignment2_DbContext))]
    partial class Assignment2_DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIassignment2.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarCompanyId");

                    b.Property<int>("CarUserId");

                    b.Property<string>("Description");

                    b.Property<string>("Make");

                    b.Property<double>("MileAge");

                    b.Property<string>("Model");

                    b.Property<double>("Range");

                    b.HasKey("Id");

                    b.HasIndex("CarCompanyId");

                    b.HasIndex("CarUserId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("APIassignment2.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Mission");

                    b.Property<string>("Name");

                    b.Property<string>("Strategy");

                    b.Property<string>("Vision");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("APIassignment2.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("ProjectTitle");

                    b.HasKey("Id");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("APIassignment2.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("SkillTitle");

                    b.HasKey("Id");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("APIassignment2.Models.SkillsProjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectId");

                    b.Property<int>("SkillId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SkillId");

                    b.ToTable("SkillsProjects");
                });

            modelBuilder.Entity("APIassignment2.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastActivityDate");

                    b.Property<string>("LastName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("APIassignment2.Models.UserSkills", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SkillId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("UserId");

                    b.ToTable("UserSkills");
                });

            modelBuilder.Entity("APIassignment2.Models.UsersProjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProjectId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersProjects");
                });

            modelBuilder.Entity("APIassignment2.Models.Car", b =>
                {
                    b.HasOne("APIassignment2.Models.Company", "CarCompany")
                        .WithMany("ListOfCars")
                        .HasForeignKey("CarCompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("APIassignment2.Models.User", "CarUser")
                        .WithMany("Cars")
                        .HasForeignKey("CarUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("APIassignment2.Models.SkillsProjects", b =>
                {
                    b.HasOne("APIassignment2.Models.Project", "Project")
                        .WithMany("SkillsProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("APIassignment2.Models.Skill", "Skill")
                        .WithMany("SkillsProjects")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("APIassignment2.Models.UserSkills", b =>
                {
                    b.HasOne("APIassignment2.Models.Skill", "Skill")
                        .WithMany("UserSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("APIassignment2.Models.User", "User")
                        .WithMany("UserSkills")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("APIassignment2.Models.UsersProjects", b =>
                {
                    b.HasOne("APIassignment2.Models.Project", "Project")
                        .WithMany("UsersProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("APIassignment2.Models.User", "User")
                        .WithMany("UsersProjects")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
