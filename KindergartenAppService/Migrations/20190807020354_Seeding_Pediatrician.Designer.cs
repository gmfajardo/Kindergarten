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
    [Migration("20190807020354_Seeding_Pediatrician")]
    partial class Seeding_Pediatrician
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
                            Id = new Guid("f4c4bd06-eac0-44d9-9953-a8c94c7b13c0"),
                            ActivityTemplateId = new Guid("f229ad69-c892-4944-8c5f-de843f05e23a"),
                            Description = "Clases de ingles"
                        },
                        new
                        {
                            Id = new Guid("33572fb1-fa20-466a-aa09-9b523d440503"),
                            ActivityTemplateId = new Guid("64f78ab3-cdf5-45b4-9adb-b4fbd730553e"),
                            Description = "Cuidade matutino"
                        },
                        new
                        {
                            Id = new Guid("b1a1f881-4436-43e5-bd10-ae3b4f3f35b0"),
                            ActivityTemplateId = new Guid("e558595e-5b87-49ad-b711-d64ffb400200"),
                            Description = "Cuidado Vespertino"
                        },
                        new
                        {
                            Id = new Guid("a1afb5fa-bd98-492c-b9e1-cc79638fea92"),
                            ActivityTemplateId = new Guid("32c63273-04e9-4d6e-a216-ccb4567e470c"),
                            Description = "Cuidado dia completo"
                        },
                        new
                        {
                            Id = new Guid("b27f15cd-71a1-4969-a1d1-26953a6588de"),
                            ActivityTemplateId = new Guid("8ba04f88-a81e-4206-8003-b83ea09b3b5d"),
                            Description = "Clases de Ballet"
                        },
                        new
                        {
                            Id = new Guid("729570b9-afab-4db7-aa43-bebd6d12703d"),
                            ActivityTemplateId = new Guid("e93b2822-4cef-4014-8550-df9155500806"),
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
                            Id = new Guid("f229ad69-c892-4944-8c5f-de843f05e23a"),
                            Description = "Clases de ingles",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a")
                        },
                        new
                        {
                            Id = new Guid("64f78ab3-cdf5-45b4-9adb-b4fbd730553e"),
                            Description = "Cuidade matutino",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a")
                        },
                        new
                        {
                            Id = new Guid("e558595e-5b87-49ad-b711-d64ffb400200"),
                            Description = "Cuidado Vespertino",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a")
                        },
                        new
                        {
                            Id = new Guid("32c63273-04e9-4d6e-a216-ccb4567e470c"),
                            Description = "Cuidado dia completo",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a")
                        },
                        new
                        {
                            Id = new Guid("8ba04f88-a81e-4206-8003-b83ea09b3b5d"),
                            Description = "Clases de Ballet",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a")
                        },
                        new
                        {
                            Id = new Guid("e93b2822-4cef-4014-8550-df9155500806"),
                            Description = "Clases de logica",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a")
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
                            Id = new Guid("585034d6-63f2-4f15-96b1-a8ab4b80dcee"),
                            ActivityId = new Guid("729570b9-afab-4db7-aa43-bebd6d12703d"),
                            EnrollmentId = new Guid("fd2e534b-b745-4b1e-a047-e8a1e3a7a025")
                        },
                        new
                        {
                            Id = new Guid("f0dfff45-601e-405f-86e5-03fad2944153"),
                            ActivityId = new Guid("a1afb5fa-bd98-492c-b9e1-cc79638fea92"),
                            EnrollmentId = new Guid("d91398fc-3123-40f9-bdac-d4a919f2aa5a")
                        },
                        new
                        {
                            Id = new Guid("8b40a582-675b-4d2c-92bc-f8f8220b09f1"),
                            ActivityId = new Guid("b27f15cd-71a1-4969-a1d1-26953a6588de"),
                            EnrollmentId = new Guid("a601e722-c11a-4e4e-817c-07d461ea413c")
                        },
                        new
                        {
                            Id = new Guid("f7354b3b-f1da-4005-8ac4-e66cc51ce0e4"),
                            ActivityId = new Guid("f4c4bd06-eac0-44d9-9953-a8c94c7b13c0"),
                            EnrollmentId = new Guid("0dc1fe68-0344-470b-97be-840f56db48d3")
                        },
                        new
                        {
                            Id = new Guid("15198bbf-4ac8-4551-9e7f-0293dee487ae"),
                            ActivityId = new Guid("b1a1f881-4436-43e5-bd10-ae3b4f3f35b0"),
                            EnrollmentId = new Guid("d419db9a-25c9-4af6-9615-6de91147588e")
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
                            Id = new Guid("fd2e534b-b745-4b1e-a047-e8a1e3a7a025"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("00015c47-dbcb-4ca3-9bb6-5d79818f53c3")
                        },
                        new
                        {
                            Id = new Guid("d91398fc-3123-40f9-bdac-d4a919f2aa5a"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("0072d391-db51-4122-a484-1f441149d702")
                        },
                        new
                        {
                            Id = new Guid("a601e722-c11a-4e4e-817c-07d461ea413c"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("01da5487-9b6e-4370-a34a-b604592e92cd")
                        },
                        new
                        {
                            Id = new Guid("0dc1fe68-0344-470b-97be-840f56db48d3"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("058a9b67-1ab5-4a8b-8b93-18d8750f76b0")
                        },
                        new
                        {
                            Id = new Guid("d419db9a-25c9-4af6-9615-6de91147588e"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("060c00fc-bfe7-4412-a71b-ecfcd73e0ca1")
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
                            Id = new Guid("00015c47-dbcb-4ca3-9bb6-5d79818f53c3"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "Washinton",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("0072d391-db51-4122-a484-1f441149d702"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "Snow",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("01da5487-9b6e-4370-a34a-b604592e92cd"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Johan",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "Snow",
                            SecondName = "Enrique",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("058a9b67-1ab5-4a8b-8b93-18d8750f76b0"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Lee",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "White",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("060c00fc-bfe7-4412-a71b-ecfcd73e0ca1"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "Washinton",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("066b26fb-0cc4-49b9-b308-78cf2ee8afe5"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Stackeetam",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "White",
                            SecondName = "Emilio",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("071d688d-1300-473b-90ec-1eb4291c377e"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Stackeetam",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "Snow",
                            SecondName = "Enrique",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("093477eb-06e6-4241-88d4-cb903431bae4"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "White",
                            SecondName = "Enrique",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("0a0230e5-77cc-4aa4-b464-853422e331ee"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "Washinton",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
                        },
                        new
                        {
                            Id = new Guid("0a6ecd72-5ae3-403d-aabd-1b186825a045"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Aaron",
                            KindergarterId = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
                            MotherName = "Snow",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TShirtSize = 0,
                            TutorPrincipalId = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7")
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
                            Id = new Guid("0782c76f-12b7-44fe-beaa-cc644e71009a"),
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

                    b.HasData(
                        new
                        {
                            Id = new Guid("434532c4-03b0-4d6d-85c9-bbd39b0ec350"),
                            Address = "Address",
                            Name = "Felipe Felix",
                            PhoneNumber = "809-852-8521"
                        });
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
                            Id = new Guid("0ab1b68d-0ce4-476f-80f2-54d40daa3cb7"),
                            FirstName = "Gregorio de Jesus",
                            LastName = "Rojas Acosta",
                            Relationship = 0
                        },
                        new
                        {
                            Id = new Guid("6ff19c47-feb2-45c0-9e73-4ecec5dbfdb3"),
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
                            Id = new Guid("0f917693-08d3-4d50-9e3f-14a780eb269b"),
                            Price = 6347m,
                            Reference = "SRV-563",
                            ActivityId = new Guid("f4c4bd06-eac0-44d9-9953-a8c94c7b13c0"),
                            Description = "Service Clases de ingles",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("868a4733-2199-4cd7-97ac-7aecd5d92e78"),
                            Price = 328m,
                            Reference = "SRV-346",
                            ActivityId = new Guid("33572fb1-fa20-466a-aa09-9b523d440503"),
                            Description = "Service Cuidade matutino",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("c4d5315d-0012-4aee-b5f5-ea4b0c4175c5"),
                            Price = 867m,
                            Reference = "SRV-641",
                            ActivityId = new Guid("b1a1f881-4436-43e5-bd10-ae3b4f3f35b0"),
                            Description = "Service Cuidado Vespertino",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("371d4038-a7a3-418c-9a27-ef0378d44899"),
                            Price = 1899m,
                            Reference = "SRV-298",
                            ActivityId = new Guid("a1afb5fa-bd98-492c-b9e1-cc79638fea92"),
                            Description = "Service Cuidado dia completo",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("ea1aafaa-2866-4aeb-8c8a-530d0b9b5f64"),
                            Price = 8973m,
                            Reference = "SRV-399",
                            ActivityId = new Guid("b27f15cd-71a1-4969-a1d1-26953a6588de"),
                            Description = "Service Clases de Ballet",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("014b94ee-adc1-4127-b73a-33f05417ac05"),
                            Price = 2009m,
                            Reference = "SRV-811",
                            ActivityId = new Guid("729570b9-afab-4db7-aa43-bebd6d12703d"),
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
