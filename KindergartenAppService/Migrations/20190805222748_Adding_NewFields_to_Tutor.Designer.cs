﻿// <auto-generated />
using System;
using KindergartenAppService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KindergartenAppService.Migrations
{
    [DbContext(typeof(KindergarterContext))]
    [Migration("20190805222748_Adding_NewFields_to_Tutor")]
    partial class Adding_NewFields_to_Tutor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KindergartenAppService.Models.Activity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ActivityTemplateId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ActivityTemplateId");

                    b.ToTable("Activity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("659924bd-1522-430a-b521-423964bea024"),
                            ActivityTemplateId = new Guid("52680218-6927-4b78-b70f-da089f7c66ab"),
                            Description = "Clases de ingles"
                        },
                        new
                        {
                            Id = new Guid("7c31f467-c0b1-4718-a92b-4fb078e34eb2"),
                            ActivityTemplateId = new Guid("89afae68-4d45-4f6f-afae-b4a715c14e71"),
                            Description = "Cuidade matutino"
                        },
                        new
                        {
                            Id = new Guid("b1b3bed4-a201-4aa5-9837-da2ff76e035d"),
                            ActivityTemplateId = new Guid("d592df4d-57d6-4e12-afe3-45aad36f0f69"),
                            Description = "Cuidado Vespertino"
                        },
                        new
                        {
                            Id = new Guid("16706578-21d5-48c4-bbec-7cc8d7ecd6d9"),
                            ActivityTemplateId = new Guid("53e9029c-b970-4357-83e8-6634ccb32527"),
                            Description = "Cuidado dia completo"
                        },
                        new
                        {
                            Id = new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"),
                            ActivityTemplateId = new Guid("61600c37-13e8-43dd-b8e7-e9f62a916335"),
                            Description = "Clases de Ballet"
                        },
                        new
                        {
                            Id = new Guid("7493eac5-b59c-4343-8c60-9d4363c0f37f"),
                            ActivityTemplateId = new Guid("c4eb6cec-546f-4ff4-b8fa-87916ce2e1e2"),
                            Description = "Clases de logica"
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.ActivityTemplate", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<Guid>("KindergarterId");

                    b.HasKey("Id");

                    b.HasIndex("KindergarterId");

                    b.ToTable("ActivityTemplate");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52680218-6927-4b78-b70f-da089f7c66ab"),
                            Description = "Clases de ingles",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc")
                        },
                        new
                        {
                            Id = new Guid("89afae68-4d45-4f6f-afae-b4a715c14e71"),
                            Description = "Cuidade matutino",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc")
                        },
                        new
                        {
                            Id = new Guid("d592df4d-57d6-4e12-afe3-45aad36f0f69"),
                            Description = "Cuidado Vespertino",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc")
                        },
                        new
                        {
                            Id = new Guid("53e9029c-b970-4357-83e8-6634ccb32527"),
                            Description = "Cuidado dia completo",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc")
                        },
                        new
                        {
                            Id = new Guid("61600c37-13e8-43dd-b8e7-e9f62a916335"),
                            Description = "Clases de Ballet",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc")
                        },
                        new
                        {
                            Id = new Guid("c4eb6cec-546f-4ff4-b8fa-87916ce2e1e2"),
                            Description = "Clases de logica",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc")
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.EnrollActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ActivityId");

                    b.Property<Guid>("EnrollmentId");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("EnrollmentId");

                    b.ToTable("EnrollActivity");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e352ff3b-ea93-4ccd-b38f-1670524bdf29"),
                            ActivityId = new Guid("7c31f467-c0b1-4718-a92b-4fb078e34eb2"),
                            EnrollmentId = new Guid("645d5ff6-88b3-4efd-bad6-58824277a99a")
                        },
                        new
                        {
                            Id = new Guid("6b2878a8-b08d-4109-8a2b-5d76b210cec9"),
                            ActivityId = new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"),
                            EnrollmentId = new Guid("363174a4-711d-448c-b8a1-f13d7d8e2ae2")
                        },
                        new
                        {
                            Id = new Guid("5aed8a4d-f718-4b7b-be57-1653636a3f5b"),
                            ActivityId = new Guid("b1b3bed4-a201-4aa5-9837-da2ff76e035d"),
                            EnrollmentId = new Guid("59f38413-4b46-4045-8627-f826e4c47e48")
                        },
                        new
                        {
                            Id = new Guid("e22035c0-ea70-49de-8edb-4ebc36111138"),
                            ActivityId = new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"),
                            EnrollmentId = new Guid("3e2f1a33-d057-4390-9882-e09b0a4ce9f9")
                        },
                        new
                        {
                            Id = new Guid("982929a0-d17f-4904-bda5-9ded2bf2c65d"),
                            ActivityId = new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"),
                            EnrollmentId = new Guid("9c527e12-6086-4a20-9d3e-1fa82f0e8ea2")
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.Enrollment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Comment");

                    b.Property<DateTime>("EnrollDay");

                    b.Property<Guid>("KidId");

                    b.HasKey("Id");

                    b.HasIndex("KidId")
                        .IsUnique();

                    b.ToTable("Enrollments");

                    b.HasData(
                        new
                        {
                            Id = new Guid("645d5ff6-88b3-4efd-bad6-58824277a99a"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("008e1b32-757a-4c4d-90d3-cace69412327")
                        },
                        new
                        {
                            Id = new Guid("363174a4-711d-448c-b8a1-f13d7d8e2ae2"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("0098f83a-5257-4247-a841-97dc3167b088")
                        },
                        new
                        {
                            Id = new Guid("59f38413-4b46-4045-8627-f826e4c47e48"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("01542ad7-82e1-4a29-83eb-e9555a2f9a37")
                        },
                        new
                        {
                            Id = new Guid("3e2f1a33-d057-4390-9882-e09b0a4ce9f9"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("03cbf736-0adc-446a-8c5f-86c20c338c84")
                        },
                        new
                        {
                            Id = new Guid("9c527e12-6086-4a20-9d3e-1fa82f0e8ea2"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("03de317f-f94d-4a37-9eff-bf1dcac32088")
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.Feeding", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Feeding");
                });

            modelBuilder.Entity("KindergartenAppService.Models.FeedingKid", b =>
                {
                    b.Property<Guid>("KidId");

                    b.Property<Guid>("FeddingId");

                    b.HasKey("KidId", "FeddingId");

                    b.HasIndex("FeddingId");

                    b.ToTable("FeedingKid");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Invoice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<Guid>("KidId");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("KindergartenAppService.Models.InvoiceDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<Guid?>("InvoiceId");

                    b.Property<Guid>("ItemId");

                    b.Property<decimal>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ItemId");

                    b.ToTable("InvoiceDetail");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<decimal>("Price");

                    b.Property<string>("Reference")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Kid", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<string>("Diseases");

                    b.Property<string>("FatherName")
                        .IsRequired();

                    b.Property<string>("FavoriteActivities");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<Guid>("KindergarterId");

                    b.Property<string>("MotherName");

                    b.Property<Guid?>("PediatricianId");

                    b.Property<string>("SecondName");

                    b.Property<int>("Sex");

                    b.Property<int>("SiblingCount");

                    b.Property<int>("TShirtSize");

                    b.Property<Guid?>("TutorAutorizedId");

                    b.Property<Guid?>("TutorId");

                    b.Property<Guid?>("TutorPrincipalId");

                    b.Property<Guid?>("TutorSecundaryId");

                    b.HasKey("Id");

                    b.HasIndex("KindergarterId");

                    b.HasIndex("PediatricianId");

                    b.HasIndex("TutorAutorizedId");

                    b.HasIndex("TutorId");

                    b.HasIndex("TutorPrincipalId");

                    b.HasIndex("TutorSecundaryId");

                    b.ToTable("Kid");

                    b.HasData(
                        new
                        {
                            Id = new Guid("008e1b32-757a-4c4d-90d3-cace69412327"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Lee",
                            FirstName = "Johan",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Worm",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("0098f83a-5257-4247-a841-97dc3167b088"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Johan",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Washinton",
                            SecondName = "Enrique",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("01542ad7-82e1-4a29-83eb-e9555a2f9a37"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "White",
                            SecondName = "Enrique",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("03cbf736-0adc-446a-8c5f-86c20c338c84"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Snow",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("03de317f-f94d-4a37-9eff-bf1dcac32088"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Stackeetam",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Washinton",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("069bb0ee-bdec-4415-97fb-114ed091e5cd"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Washinton",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("07902544-6e07-43af-8345-f11948b179e2"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Lee",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Worm",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("07aa97d6-d54b-42de-8cd2-d40bea395461"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Lee",
                            FirstName = "Johan",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Snow",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("08340cda-5c08-4dee-945d-d469627884dc"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Washinton",
                            SecondName = "Enrique",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        },
                        new
                        {
                            Id = new Guid("0924d5f0-63e8-41c9-8804-f90c34833ce6"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            MotherName = "Worm",
                            SecondName = "Emilio",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107")
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.Kindergarter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Kindergarters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("633c9f03-1d50-483b-bdc4-2f1743b26dbc"),
                            Description = "KPH"
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.MedicalRecord", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("KidId");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("MedicalRecord");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Payment", b =>
                {
                    b.Property<Guid>("InvoiceId");

                    b.Property<Guid>("ReceiptId");

                    b.HasKey("InvoiceId", "ReceiptId");

                    b.HasIndex("ReceiptId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Pediatrician", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Pediatrician");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Precense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("KidId");

                    b.Property<DateTime>("PrecenseDay");

                    b.HasKey("Id");

                    b.HasIndex("KidId");

                    b.ToTable("Precense");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Receipt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Receipt");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Stock", b =>
                {
                    b.Property<Guid>("StoreId");

                    b.Property<Guid>("ProductId");

                    b.HasKey("StoreId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("Stock");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Store", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.HasKey("Id");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("KindergartenAppService.Models.SubActivities", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ActivityId");

                    b.Property<DateTime>("Date");

                    b.Property<TimeSpan>("EndingTime");

                    b.Property<TimeSpan>("StaringTime");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("SubActivities");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Tutor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Facebook");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Identification");

                    b.Property<string>("Instagram");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Mail");

                    b.Property<string>("MovilNumber");

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("Relationship");

                    b.HasKey("Id");

                    b.ToTable("Tutors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f4a95ab5-9a96-40d4-95be-6c8e036f5107"),
                            FirstName = "Gregorio de Jesus",
                            LastName = "Rojas Acosta",
                            Relationship = 0
                        },
                        new
                        {
                            Id = new Guid("07662e45-c74c-471b-9a51-5eb0eab737c6"),
                            FirstName = "Yadira",
                            LastName = "Pinales Delgado",
                            Relationship = 0
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("KindergarterId");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("KindergarterId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Product", b =>
                {
                    b.HasBaseType("KindergartenAppService.Models.Item");

                    b.HasDiscriminator().HasValue("Product");
                });

            modelBuilder.Entity("KindergartenAppService.Models.Service", b =>
                {
                    b.HasBaseType("KindergartenAppService.Models.Item");

                    b.Property<Guid>("ActivityId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<int>("ServicePeriod");

                    b.HasIndex("ActivityId");

                    b.HasDiscriminator().HasValue("Service");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0098aef8-199e-41c0-91b7-0e7b2da7592c"),
                            Price = 7108m,
                            Reference = "SRV-328",
                            ActivityId = new Guid("659924bd-1522-430a-b521-423964bea024"),
                            Description = "Service Clases de ingles",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("dc65a1f8-d529-4975-9aec-10cdb993878f"),
                            Price = 727m,
                            Reference = "SRV-146",
                            ActivityId = new Guid("7c31f467-c0b1-4718-a92b-4fb078e34eb2"),
                            Description = "Service Cuidade matutino",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("efd16c04-5744-4717-b9fc-0e9e2e0a870e"),
                            Price = 5294m,
                            Reference = "SRV-507",
                            ActivityId = new Guid("b1b3bed4-a201-4aa5-9837-da2ff76e035d"),
                            Description = "Service Cuidado Vespertino",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("904507a1-c82d-4173-ae47-5c3895fc8c1f"),
                            Price = 2957m,
                            Reference = "SRV-558",
                            ActivityId = new Guid("16706578-21d5-48c4-bbec-7cc8d7ecd6d9"),
                            Description = "Service Cuidado dia completo",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("448d9918-4d8e-45b4-8a29-5506a1ba7bf6"),
                            Price = 560m,
                            Reference = "SRV-966",
                            ActivityId = new Guid("5e6a0154-ac07-4519-8513-fe9fe93ae6b9"),
                            Description = "Service Clases de Ballet",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("08267875-59c4-402c-abc8-9e0eaf01eabe"),
                            Price = 4773m,
                            Reference = "SRV-103",
                            ActivityId = new Guid("7493eac5-b59c-4343-8c60-9d4363c0f37f"),
                            Description = "Service Clases de logica",
                            ServicePeriod = 77
                        });
                });

            modelBuilder.Entity("KindergartenAppService.Models.Activity", b =>
                {
                    b.HasOne("KindergartenAppService.Models.ActivityTemplate", "ActivityTemplate")
                        .WithMany("Activities")
                        .HasForeignKey("ActivityTemplateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.ActivityTemplate", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kindergarter", "Kindergarter")
                        .WithMany("ActivityTemplates")
                        .HasForeignKey("KindergarterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.EnrollActivity", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Enrollment", "Enrollment")
                        .WithMany("EnrollActivities")
                        .HasForeignKey("EnrollmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Enrollment", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithOne("Enrollment")
                        .HasForeignKey("KindergartenAppService.Models.Enrollment", "KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.FeedingKid", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Feeding", "Fedding")
                        .WithMany("FeedingKids")
                        .HasForeignKey("FeddingId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany("FeedingKids")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Invoice", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany()
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.InvoiceDetail", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("KindergartenAppService.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Kid", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kindergarter", "Kindergarter")
                        .WithMany("Kids")
                        .HasForeignKey("KindergarterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Pediatrician", "Pediatrician")
                        .WithMany("Kids")
                        .HasForeignKey("PediatricianId");

                    b.HasOne("KindergartenAppService.Models.Tutor", "TutorAutorized")
                        .WithMany()
                        .HasForeignKey("TutorAutorizedId");

                    b.HasOne("KindergartenAppService.Models.Tutor")
                        .WithMany("Kids")
                        .HasForeignKey("TutorId");

                    b.HasOne("KindergartenAppService.Models.Tutor", "TutorPrincipal")
                        .WithMany()
                        .HasForeignKey("TutorPrincipalId");

                    b.HasOne("KindergartenAppService.Models.Tutor", "TutorSecundary")
                        .WithMany()
                        .HasForeignKey("TutorSecundaryId");
                });

            modelBuilder.Entity("KindergartenAppService.Models.MedicalRecord", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Payment", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Invoice", "Invoice")
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Receipt", "Receipt")
                        .WithMany("Payments")
                        .HasForeignKey("ReceiptId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Precense", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kid", "Kid")
                        .WithMany("Precenses")
                        .HasForeignKey("KidId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Stock", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Product", "Product")
                        .WithMany("Stock")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KindergartenAppService.Models.Store", "Store")
                        .WithMany("Stock")
                        .HasForeignKey("StoreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.SubActivities", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Activity", "Activity")
                        .WithMany("SubActivities")
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.User", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Kindergarter", "Kindergarter")
                        .WithMany("Users")
                        .HasForeignKey("KindergarterId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KindergartenAppService.Models.Service", b =>
                {
                    b.HasOne("KindergartenAppService.Models.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
