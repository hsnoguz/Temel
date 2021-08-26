﻿// <auto-generated />
using System;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(ManagerContext))]
    [Migration("20210826185016_UserChage2b")]
    partial class UserChage2b
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Turkish_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.Concrete.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Jop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Jop");
                });

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserOperationClaimId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserOperationClaimId");

                    b.ToTable("OperationClaims");
                });

            modelBuilder.Entity("Core.Entities.Concrete.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Organization");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("IsActive")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("JopId")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OrganizationId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasMaxLength(100)
                        .HasColumnType("varbinary(100)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Telephone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.HasIndex("JopId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BranchId = 0,
                            Email = "admin@arastirmaturk.com",
                            FirstName = "Admin",
                            InsertTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            JopId = 0,
                            LastName = "Admin",
                            OrganizationId = 0,
                            PasswordHash = new byte[] { 200, 185, 38, 114, 175, 33, 125, 226, 154, 148, 7, 134, 192, 105, 246, 31, 39, 36, 173, 196, 150, 129, 93, 43, 66, 89, 76, 110, 176, 29, 14, 138, 245, 55, 235, 201, 99, 197, 128, 158, 199, 19, 93, 77, 121, 55, 4, 4, 163, 131, 153, 186, 96, 8, 105, 171, 64, 133, 154, 62, 227, 123, 13, 15 },
                            PasswordSalt = new byte[] { 5, 252, 36, 212, 206, 245, 246, 192, 214, 85, 35, 216, 0, 74, 137, 45, 209, 40, 59, 155, 128, 205, 162, 250, 255, 17, 96, 19, 29, 227, 197, 227, 250, 187, 255, 169, 4, 247, 125, 75, 89, 116, 154, 183, 143, 38, 31, 202, 165, 176, 183, 5, 246, 164, 178, 27, 39, 225, 236, 171, 168, 239, 91, 238, 116, 217, 146, 225, 255, 211, 118, 157, 144, 88, 234, 250, 211, 182, 7, 205, 189, 80, 40, 120, 78, 119, 180, 214, 55, 233, 34, 124, 192, 17, 163, 118, 81, 103, 200, 214, 139, 124, 54, 35, 23, 33, 181, 254, 238, 236, 141, 225, 134, 164, 169, 223, 157, 222, 38, 131, 42, 64, 120, 106, 57, 80, 214, 31 },
                            Status = true
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OperationClaimId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("DAL.Model.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Explanation")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<short>("parentId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Branchs");
                });

            modelBuilder.Entity("DAL.Model.Jop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Explanation")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<short>("parentId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Jops");
                });

            modelBuilder.Entity("DAL.Model.Organization", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Explanation")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<short>("parentId")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("DAL.Model.Periot", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("StartYear")
                        .HasColumnType("int");

                    b.Property<int>("StopYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Periots");
                });

            modelBuilder.Entity("DAL.Model.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("InsertTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 8, 26, 21, 50, 15, 519, DateTimeKind.Local).AddTicks(861));

                    b.Property<bool>("IsSuccess")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PeriotId")
                        .HasColumnType("int");

                    b.Property<int>("SuccesCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.HasIndex("PeriotId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("DAL.Model.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColumnName")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Type")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("DAL.Model.QuestionHorizontal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColumnName")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<short>("Value")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionHorizontals");
                });

            modelBuilder.Entity("DAL.Model.QuestionVertical", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ColumnName")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<int>("ParentId")
                        .HasColumnType("int");

                    b.Property<decimal>("Point")
                        .HasPrecision(9, 4)
                        .HasColumnType("decimal(9,4)");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<short>("Value")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionVerticals");
                });

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.HasOne("Core.Entities.Concrete.UserOperationClaim", null)
                        .WithMany("OperationClaims")
                        .HasForeignKey("UserOperationClaimId");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.HasOne("Core.Entities.Concrete.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.Jop", "Jop")
                        .WithMany()
                        .HasForeignKey("JopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Jop");

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.HasOne("Core.Entities.Concrete.User", null)
                        .WithMany("UserOperationClaim")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Model.Project", b =>
                {
                    b.HasOne("DAL.Model.Periot", "Periot")
                        .WithMany()
                        .HasForeignKey("PeriotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Periot");
                });

            modelBuilder.Entity("DAL.Model.Question", b =>
                {
                    b.HasOne("DAL.Model.Project", "Project")
                        .WithMany("Questions")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("DAL.Model.QuestionHorizontal", b =>
                {
                    b.HasOne("DAL.Model.Question", "Question")
                        .WithMany("QuestionHorizontals")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("DAL.Model.QuestionVertical", b =>
                {
                    b.HasOne("DAL.Model.Question", "Question")
                        .WithMany("QuestionVerticals")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Navigation("UserOperationClaim");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Navigation("OperationClaims");
                });

            modelBuilder.Entity("DAL.Model.Project", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("DAL.Model.Question", b =>
                {
                    b.Navigation("QuestionHorizontals");

                    b.Navigation("QuestionVerticals");
                });
#pragma warning restore 612, 618
        }
    }
}
