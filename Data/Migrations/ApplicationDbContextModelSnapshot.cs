﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebProgProject.Data;

namespace WebProgProject.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("WebProgProject.Models.Cemetary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cemetary");
                });

            modelBuilder.Entity("WebProgProject.Models.Person", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AgeAtDeath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPOF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BPOM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baptism")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthCert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BurialDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BurialYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CensusBookNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CensusEntryNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CensusPageNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CensusRecords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Children")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChurchBuriedFrom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfDeath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateOfMarriage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeathCause")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeathCert")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeathPlace")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Father")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FuneralHome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPSGravesite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Godparents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GraveNumInCrypt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImmigrationYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LotNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaidenName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatGma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatGpa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatGreatGma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatGreatGpa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MausCorridor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MausTier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Military")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mother")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Obituary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrientationInLot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatGma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatGpa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatGreatGma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatGreatGpa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlotID")
                        .HasColumnType("int");

                    b.Property<string>("ResidenceAtDeath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionNum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Siblings")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpouseID")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tombstone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TombstoneInscription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Upload")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Will")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contactPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("PlotID");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("WebProgProject.Models.PersonPlot", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("personID")
                        .HasColumnType("int");

                    b.Property<int>("plotID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("personID");

                    b.HasIndex("plotID");

                    b.ToTable("PersonPlot");
                });

            modelBuilder.Entity("WebProgProject.Models.Picture", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("picPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Picture");
                });

            modelBuilder.Entity("WebProgProject.Models.PictureCemetary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CemetaryID")
                        .HasColumnType("int");

                    b.Property<int>("pictureID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CemetaryID");

                    b.HasIndex("pictureID");

                    b.ToTable("PictureCemetary");
                });

            modelBuilder.Entity("WebProgProject.Models.PicturePerson", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PersonID")
                        .HasColumnType("int");

                    b.Property<int>("pictureID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("PersonID");

                    b.HasIndex("pictureID");

                    b.ToTable("PicturePerson");
                });

            modelBuilder.Entity("WebProgProject.Models.PicturePlot", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("pictureID")
                        .HasColumnType("int");

                    b.Property<int>("plotID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("pictureID");

                    b.HasIndex("plotID");

                    b.ToTable("PicturePlot");
                });

            modelBuilder.Entity("WebProgProject.Models.Plot", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CemID")
                        .HasColumnType("int");

                    b.Property<int?>("Personid")
                        .HasColumnType("int");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("plotNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Personid");

                    b.ToTable("Plot");
                });

            modelBuilder.Entity("WebProgProject.Models.PlotCemetary", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CemetaryID")
                        .HasColumnType("int");

                    b.Property<int>("plotID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("CemetaryID");

                    b.HasIndex("plotID");

                    b.ToTable("PlotCemetary");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProgProject.Models.Person", b =>
                {
                    b.HasOne("WebProgProject.Models.Plot", "MyPlot")
                        .WithMany()
                        .HasForeignKey("PlotID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProgProject.Models.PersonPlot", b =>
                {
                    b.HasOne("WebProgProject.Models.Person", "person")
                        .WithMany()
                        .HasForeignKey("personID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgProject.Models.Plot", "plot")
                        .WithMany()
                        .HasForeignKey("plotID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProgProject.Models.PictureCemetary", b =>
                {
                    b.HasOne("WebProgProject.Models.Cemetary", "cemetary")
                        .WithMany()
                        .HasForeignKey("CemetaryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgProject.Models.Picture", "picture")
                        .WithMany()
                        .HasForeignKey("pictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProgProject.Models.PicturePerson", b =>
                {
                    b.HasOne("WebProgProject.Models.Person", "person")
                        .WithMany("PicturePersons")
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgProject.Models.Picture", "picture")
                        .WithMany("PicturePersons")
                        .HasForeignKey("pictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProgProject.Models.PicturePlot", b =>
                {
                    b.HasOne("WebProgProject.Models.Picture", "picture")
                        .WithMany()
                        .HasForeignKey("pictureID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgProject.Models.Plot", "plot")
                        .WithMany()
                        .HasForeignKey("plotID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebProgProject.Models.Plot", b =>
                {
                    b.HasOne("WebProgProject.Models.Person", null)
                        .WithMany("Plots")
                        .HasForeignKey("Personid");
                });

            modelBuilder.Entity("WebProgProject.Models.PlotCemetary", b =>
                {
                    b.HasOne("WebProgProject.Models.Cemetary", "cemetary")
                        .WithMany("PlotCemetaries")
                        .HasForeignKey("CemetaryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebProgProject.Models.Plot", "plot")
                        .WithMany("PlotCemetaries")
                        .HasForeignKey("plotID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
