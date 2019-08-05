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
    [Migration("20190805210046_Adding_Sex_to_Kid")]
    partial class Adding_Sex_to_Kid
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
                            Id = new Guid("02852eea-cd8c-4e42-9e46-691dc19585a2"),
                            ActivityTemplateId = new Guid("c3a3c2c1-66a8-4516-97d3-48b56cecdf8e"),
                            Description = "Clases de ingles"
                        },
                        new
                        {
                            Id = new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"),
                            ActivityTemplateId = new Guid("96842ae8-5ad4-4b76-8751-077977e221a6"),
                            Description = "Cuidade matutino"
                        },
                        new
                        {
                            Id = new Guid("08a44ae6-3ffc-4805-94e2-05d88cd3d994"),
                            ActivityTemplateId = new Guid("7ad872f9-6889-40be-b7cf-a958d6aaf499"),
                            Description = "Cuidado Vespertino"
                        },
                        new
                        {
                            Id = new Guid("90e50ba1-980d-4340-87f4-44ae63850dc8"),
                            ActivityTemplateId = new Guid("d9386be6-94a7-4d18-af0a-6cb323a00cac"),
                            Description = "Cuidado dia completo"
                        },
                        new
                        {
                            Id = new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"),
                            ActivityTemplateId = new Guid("9da7ae7c-68a7-4a7b-9502-dfddeeec888e"),
                            Description = "Clases de Ballet"
                        },
                        new
                        {
                            Id = new Guid("691ee267-6ebe-40b3-b70a-433ffbe2cc78"),
                            ActivityTemplateId = new Guid("7fdd0071-cdd8-47aa-92aa-2f26c9758459"),
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
                            Id = new Guid("c3a3c2c1-66a8-4516-97d3-48b56cecdf8e"),
                            Description = "Clases de ingles",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059")
                        },
                        new
                        {
                            Id = new Guid("96842ae8-5ad4-4b76-8751-077977e221a6"),
                            Description = "Cuidade matutino",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059")
                        },
                        new
                        {
                            Id = new Guid("7ad872f9-6889-40be-b7cf-a958d6aaf499"),
                            Description = "Cuidado Vespertino",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059")
                        },
                        new
                        {
                            Id = new Guid("d9386be6-94a7-4d18-af0a-6cb323a00cac"),
                            Description = "Cuidado dia completo",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059")
                        },
                        new
                        {
                            Id = new Guid("9da7ae7c-68a7-4a7b-9502-dfddeeec888e"),
                            Description = "Clases de Ballet",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059")
                        },
                        new
                        {
                            Id = new Guid("7fdd0071-cdd8-47aa-92aa-2f26c9758459"),
                            Description = "Clases de logica",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059")
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
                            Id = new Guid("f856c279-3e08-4003-aa9a-6434976c6de8"),
                            ActivityId = new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"),
                            EnrollmentId = new Guid("a1610565-617a-4274-9833-746b485cab50")
                        },
                        new
                        {
                            Id = new Guid("9cd9dca7-34f5-4959-a094-f03b4f011781"),
                            ActivityId = new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"),
                            EnrollmentId = new Guid("7ac1d474-fcee-4187-a00b-036e621dd2d1")
                        },
                        new
                        {
                            Id = new Guid("65ce4479-c66f-411a-97e6-2b2e8f38e586"),
                            ActivityId = new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"),
                            EnrollmentId = new Guid("06c096cc-49ec-4303-9d39-df6de5bd3838")
                        },
                        new
                        {
                            Id = new Guid("5c3a60e8-f930-4688-bca4-2fd62725f72b"),
                            ActivityId = new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"),
                            EnrollmentId = new Guid("2cfe78c3-033d-47eb-b83d-647dd9ae8869")
                        },
                        new
                        {
                            Id = new Guid("d1f4b701-a2f4-481b-af2d-80d032135ec5"),
                            ActivityId = new Guid("08a44ae6-3ffc-4805-94e2-05d88cd3d994"),
                            EnrollmentId = new Guid("3305dac8-1f34-49d1-abc9-77177198de32")
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
                            Id = new Guid("a1610565-617a-4274-9833-746b485cab50"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("002ec496-09da-46c7-a12e-30d59604d747")
                        },
                        new
                        {
                            Id = new Guid("7ac1d474-fcee-4187-a00b-036e621dd2d1"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("004db9f2-af05-43e6-9c6b-0ffb269871d7")
                        },
                        new
                        {
                            Id = new Guid("06c096cc-49ec-4303-9d39-df6de5bd3838"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("01d8b9d2-fb79-4cd0-9126-c53758e079aa")
                        },
                        new
                        {
                            Id = new Guid("2cfe78c3-033d-47eb-b83d-647dd9ae8869"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("02c9237a-393d-4d3a-ad94-53ed36409244")
                        },
                        new
                        {
                            Id = new Guid("3305dac8-1f34-49d1-abc9-77177198de32"),
                            EnrollDay = new DateTime(2019, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KidId = new Guid("0475b56f-1ab3-4cae-a689-44ee43dc281d")
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

                    b.Property<string>("SecondName");

                    b.Property<int>("Sex");

                    b.Property<int>("SiblingCount");

                    b.Property<Guid>("TutorId");

                    b.HasKey("Id");

                    b.HasIndex("KindergarterId");

                    b.HasIndex("TutorId");

                    b.ToTable("Kid");

                    b.HasData(
                        new
                        {
                            Id = new Guid("002ec496-09da-46c7-a12e-30d59604d747"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Lee",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Washinton",
                            SecondName = "Emilio",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("004db9f2-af05-43e6-9c6b-0ffb269871d7"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Washinton",
                            SecondName = "Emilio",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("01d8b9d2-fb79-4cd0-9126-c53758e079aa"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Snow",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("02c9237a-393d-4d3a-ad94-53ed36409244"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Stackeetam",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Worm",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("0475b56f-1ab3-4cae-a689-44ee43dc281d"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Washinton",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("05566409-768f-4cab-a7d2-0c0b96b8de16"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Johan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "White",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("072c04dd-99fd-4e6e-a0ca-98d707aeca8a"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Escobar",
                            FirstName = "Dylan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Snow",
                            SecondName = "Emilio",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("09009f6e-be57-4a3a-bf8c-9f5f3c707a62"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Johan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Snow",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("0a01848f-b5a4-4a23-ab1f-78d183b2873a"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Lee",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Washinton",
                            SecondName = "Eduardo",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
                        },
                        new
                        {
                            Id = new Guid("0ce3bd10-9733-45a7-aa88-7d55462ec8c6"),
                            BirthDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Faringtom",
                            FirstName = "Lyan",
                            KindergarterId = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
                            MotherName = "Snow",
                            SecondName = "Carlos",
                            Sex = 0,
                            SiblingCount = 0,
                            TutorId = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e")
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
                            Id = new Guid("64bb4973-6892-426f-a93e-179db3f18059"),
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

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Mail");

                    b.Property<string>("MovilNumber");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Tutors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fecaefa5-5e6c-4000-8dc8-ad461dc9073e"),
                            FirstName = "Gregorio de Jesus",
                            LastName = "Rojas Acosta"
                        },
                        new
                        {
                            Id = new Guid("e267df5a-32ed-42d9-9715-901fe9e0ba19"),
                            FirstName = "Yadira",
                            LastName = "Pinales Delgado"
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
                            Id = new Guid("0f6169a6-4840-40f0-8b63-36c03547e495"),
                            Price = 5926m,
                            Reference = "SRV-651",
                            ActivityId = new Guid("02852eea-cd8c-4e42-9e46-691dc19585a2"),
                            Description = "Service Clases de ingles",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("bcb278fc-7429-46b7-8b6e-70c5194da5a5"),
                            Price = 1856m,
                            Reference = "SRV-99",
                            ActivityId = new Guid("747f6fd4-4b68-439a-bc41-9eb6f1bd55f1"),
                            Description = "Service Cuidade matutino",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("0f0578dc-87f0-4f51-a7ca-aa464a48b062"),
                            Price = 4527m,
                            Reference = "SRV-853",
                            ActivityId = new Guid("08a44ae6-3ffc-4805-94e2-05d88cd3d994"),
                            Description = "Service Cuidado Vespertino",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("b7327fc9-84a3-4e96-ac73-617d8ebf48d9"),
                            Price = 7375m,
                            Reference = "SRV-481",
                            ActivityId = new Guid("90e50ba1-980d-4340-87f4-44ae63850dc8"),
                            Description = "Service Cuidado dia completo",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("e1389f6e-4c54-4794-8d7a-716e285a82af"),
                            Price = 5052m,
                            Reference = "SRV-115",
                            ActivityId = new Guid("14e4dc48-010d-49ec-a73d-6cac772968d1"),
                            Description = "Service Clases de Ballet",
                            ServicePeriod = 77
                        },
                        new
                        {
                            Id = new Guid("e4fa9e0e-71cb-472d-9cbe-bab6f8f7393b"),
                            Price = 7377m,
                            Reference = "SRV-953",
                            ActivityId = new Guid("691ee267-6ebe-40b3-b70a-433ffbe2cc78"),
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

                    b.HasOne("KindergartenAppService.Models.Tutor", "Tutor")
                        .WithMany("Kids")
                        .HasForeignKey("TutorId")
                        .OnDelete(DeleteBehavior.Cascade);
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