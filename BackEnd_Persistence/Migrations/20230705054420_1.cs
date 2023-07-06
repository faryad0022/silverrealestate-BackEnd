using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BackEnd_Persistence.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkHour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banners",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BannerImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommonQuestions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Answer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConstructorInformation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstructorLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConstructorInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryFlag = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Logo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PropertyTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RealEstateServices",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RealEstateServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Socials",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Socials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Spectacularlocations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spectacularlocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CellPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberPicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telegram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Twitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogContents",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogGroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Review = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ViewCount = table.Column<long>(type: "bigint", nullable: false),
                    BlogGroupId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogContents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogContents_BlogGroups_BlogGroupId",
                        column: x => x.BlogGroupId,
                        principalTable: "BlogGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpectacularLocationImages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpectacularlocationId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpectacularLocationImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SpectacularLocationImages_Spectacularlocations_SpectacularlocationId",
                        column: x => x.SpectacularlocationId,
                        principalTable: "Spectacularlocations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AgentPhoneNmber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentPlan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyHandOverDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VATFee = table.Column<int>(type: "int", nullable: false),
                    ConnectionFee = table.Column<int>(type: "int", nullable: false),
                    StampDutyFee = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfBedroom = table.Column<int>(type: "int", nullable: false),
                    NumberOfBathroom = table.Column<int>(type: "int", nullable: false),
                    FloorSpace = table.Column<int>(type: "int", nullable: false),
                    Floor = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyStatus = table.Column<bool>(type: "bit", nullable: false),
                    PropertyTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CityId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_PropertyTypes_PropertyTypeId",
                        column: x => x.PropertyTypeId,
                        principalTable: "PropertyTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyFacilities",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyFacilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyFacilities_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyGalleries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyGalleries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyGalleries_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyPlans",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyPlans_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PropertyVideos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VideoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyId = table.Column<long>(type: "bigint", nullable: false),
                    IsDelete = table.Column<bool>(type: "bit", nullable: false),
                    IsSelected = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PropertyVideos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PropertyVideos_Properties_PropertyId",
                        column: x => x.PropertyId,
                        principalTable: "Properties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "TeamImage", "Text" },
                values: new object[] { 1L, new DateTime(2023, 7, 5, 9, 14, 19, 128, DateTimeKind.Local).AddTicks(8893), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "املاک شبکه نقره ای با بیش از 6 سال سابقه درخشان آماده ی ارائه بهترین خدمات در راستای خرید ملک،سرمایه گذاری، اخذ اقامت، ثبت شرکت ، پذیرش دانشجویی و کلیه خدمات به همراه ارایه گشت های محلی با بکار گیری راهنمایان فارسی زبان بصورت گروهی و اختصاصی برای افراد و آژانسهای مسافرتی، به شما عزیزان در قبرس شمالی میباشد." });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CellPhone", "CreateDate", "Email", "IsDelete", "IsSelected", "LastUpdateDate", "Location", "Telephone", "WorkHour" },
                values: new object[,]
                {
                    { 1L, "+98-9123071411", new DateTime(2023, 7, 5, 9, 14, 19, 133, DateTimeKind.Local).AddTicks(6790), "mahancomputer49@gmail.com", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کیش - شهرک صدف - خیابان سبلان - پلاک 27 - واحد6", "00987644446503", "شنبه تا جمعه ساعت 8-20" },
                    { 2L, "+90-5338355243", new DateTime(2023, 7, 5, 9, 14, 19, 133, DateTimeKind.Local).AddTicks(6887), "mahancomputer49@gmail.com", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "قبرس شمالی - شهرک رویال سان - پرل 105", "00987644446503", "شنبه تا جمعه ساعت 8-20" }
                });

            migrationBuilder.InsertData(
                table: "BlogGroups",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 5, 9, 14, 19, 136, DateTimeKind.Local).AddTicks(1817), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "اخبار قبرس" },
                    { 2L, new DateTime(2023, 7, 5, 9, 14, 19, 136, DateTimeKind.Local).AddTicks(2607), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دانشگاه های قبرس" },
                    { 3L, new DateTime(2023, 7, 5, 9, 14, 19, 136, DateTimeKind.Local).AddTicks(2618), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کنسرت ها" }
                });

            migrationBuilder.InsertData(
                table: "CommonQuestions",
                columns: new[] { "Id", "Answer", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Question" },
                values: new object[,]
                {
                    { 1L, "قبرس با داشتن آب و هوای معتدل و مرطوب مدیترانه ایی مقصد مورد علاقه جهانگردان برای تعطیلات می باشد، با داشتن بیش از ۳۰۰ روز آفتابی و گرمایی مطلوب و کوهستان هایی در دل خود، از اعتدالی مدیترانه ایی برخوردار است.", new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(1853), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "قبرس کجاست؟" },
                    { 2L, "قبرس شمالی با داشتن ۳۶ درصد از مساحت کل جزیره قبرس به علت داشتن شرایط مهاجرتی آسان و مالیات بسیار کم در قیاس با جمهوری قبرس و سایر کشورهای اروپایی مورد توجه سرمایه گذارانی از نقاط مختلف دنیا قرار گرفته است", new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3477), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "چرا قبرس شمالی؟" },
                    { 3L, "لیر ترکیه به عنوان ارز رایج این کشور شناخته می شود ولی خرید فروش ملک به پوند انگلستان می باشد و دلار و یورو هم در کنار این دو واحد پولی مورد استفاده قرار می گیرد.", new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3491), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "واحد پولی قبرس شمالی چه می باشد؟" },
                    { 4L, "امنیت بالای قبرس شمالی در کنار رفاه مردم این کشور می تواند برای هر خانواده ایی دلیلی مناسب برای مهاجرت به قبرس شمالی باشد، بی علت نیست اگر قبرس شمالی در فهرست پنج کشور امن دنیا قرار گرفته است.", new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3495), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "آیا قبرس شمالی برای زندگی خانوادگی مناسب می باشد؟" },
                    { 5L, "برای ورود به قبرس شمالی به صورت توریستی نیازی به اخذ ویزا نخواهید داشت.  برای داشتن اقامت بیشتر، از طریق اقامت دانشجویی، خرید ملک و یا ثبت شرکت و یا اشتغال میسر خواهد بود.", new DateTime(2023, 7, 5, 9, 14, 19, 137, DateTimeKind.Local).AddTicks(3498), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شرایط اخذ ویزا برای ورود به قبرس شمالی چگونه می باشد؟" }
                });

            migrationBuilder.InsertData(
                table: "ConstructorInformation",
                columns: new[] { "Id", "ConstructorLogo", "CreateDate", "Description", "IsDelete", "IsSelected", "LastUpdateDate", "Title" },
                values: new object[,]
                {
                    { 2L, "Ceaser.jpg", new DateTime(2023, 7, 5, 9, 14, 19, 138, DateTimeKind.Local).AddTicks(2939), "اگر که به دنبال خرید ملک در قبرس شمالی بوده اید، بدون شک نام سزار ریزورت‌ به گوشتان خورده است. افیک گروپ، شرکت مادر مجتمع سزار قبرس، در سال های اخیر در قبرس ترک مشهور و به دنبال آن اولین پروژه ی این شرکت به نام سزار ریزورت بر سر زبان ها افتاد. شهرک سزار قبرس شمالی با وجود قیمت نسبتا بالا خود در مقایسه با املاک منطقه توانسته در دل فارسی زبانان جا باز کند و جمع کثیری از ایرانیان را در این شهرک گرد هم آورد.\r\nشنا در استخرهای تابستانه، نوشیدن لاته گرم در کافه پاریس در فصل پاییز، پایکوبی در مهمانی های پر زرق و برق زمستانه و در نهایت پیاده روی های سرخوشانه به مقصد ساحل لانگ بیچ در فصل بهار همگی از زیبایی های شهرک سزار قبرس شمالی هستند.\r\nآنچه مجتمع سزار قبرس را از دیگر شهرک های جزیره جدا میکند، شرایط پرداخت اقساطی واحدها می باشد.\r\nوقتی پای اقساط به میان می آید، توجه به تبصره های قرارداد از مسائل حساس و چالش برانگیز می شود. قرارداد مجتمع سزار قبرس حاوی شش تا هشت صفحه با بند ها و تبصره های مختلف به زبان انگلیسی است که عدم توجه و غفلت از هر یک از این بندها ممکن است ضرر و زیان جبران ناپذیری برای خریداران به همراه داشته باشد. امکان تغییر در جزییات تبصره ها با صحبت و رایزنی مشاور املاک شما با مدیران فروش سزار ریزورت وجود دارد. بنابراین پیش از امضای هرگونه قرارداد ملک شهرک سزار قبرس شمالی حتما با مشاور املاک مسلط به زبان انگلیسی و ترکی، مشورت کرده و راهنمایی های لازم را دریافت کنید تا در آینده با مشکلات مالی و حقوقی مواجه نشوید.", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceaser Group" },
                    { 1L, "Noyanlar.jpg", new DateTime(2023, 7, 5, 9, 14, 19, 138, DateTimeKind.Local).AddTicks(2909), "گروه شرکت های نویانلار که در سال 1973 تأسیس شد، خدمات با کیفیت بالا را در تمام زمینه های صنعت ساخت و ساز در قبرس شمالی ارائه می دهد. این یک شرکت خانوادگی موفق است که کیفیت و رشد قابل اعتماد را در صنعت ساخت و ساز فراهم می کند. پروژه های ما مطابق با طرح های ساختمانی معاصر انجام می شود تا رضایتمندی بالا را فراهم کند.این مسیر باتاسیس شرکت معماری و مهندسی با مسئولیت محدود Arken توسط معمار کهنه کار گوکان نویان آغاز شد که در دهه های 1970 و 1980 بسیاری از پروژه های معماری را امضا کرد. در سال ۱۹۸۶ یک مهندس عمران با تجربه به نام Mustafa Noyan به این تیم پیوست.", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noyanlar Group Constructor" }
                });

            migrationBuilder.InsertData(
                table: "Logo",
                columns: new[] { "Id", "CreateDate", "Description", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "Title" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 5, 9, 14, 19, 142, DateTimeKind.Local).AddTicks(1124), "The Best real estate in cyprus", "silver.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver Net Real Estate" },
                    { 2L, new DateTime(2023, 7, 5, 9, 14, 19, 142, DateTimeKind.Local).AddTicks(1166), "The Best real estate in cyprus", "silver-net.jpg", false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silver Net Real Estate" }
                });

            migrationBuilder.InsertData(
                table: "Socials",
                columns: new[] { "Id", "CreateDate", "Icon", "IsDelete", "IsSelected", "LastUpdateDate", "Link", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 5, 9, 14, 19, 143, DateTimeKind.Local).AddTicks(9352), "fa fa-instagram", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "instagram.com", "Instagram" },
                    { 2L, new DateTime(2023, 7, 5, 9, 14, 19, 143, DateTimeKind.Local).AddTicks(9398), "fa fa-facebok", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "facebook.com", "Facebook" }
                });

            migrationBuilder.InsertData(
                table: "Spectacularlocations",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8446), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghost City" },
                    { 2L, new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8475), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wall City" },
                    { 3L, new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8480), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Long Beach" },
                    { 4L, new DateTime(2023, 7, 5, 9, 14, 19, 144, DateTimeKind.Local).AddTicks(8483), false, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Casino" }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Id", "CellPhone", "CreateDate", "Email", "Facebook", "Instagram", "IsDelete", "IsSelected", "LastUpdateDate", "MemberPicture", "MemberPosition", "Name", "Telegram", "Twitter" },
                values: new object[,]
                {
                    { 1L, "09123071411", new DateTime(2023, 7, 5, 9, 14, 19, 146, DateTimeKind.Local).AddTicks(3455), "mahancomputer49@gmail.com", null, null, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "faryad.jpg", "CEO", "Faryad", null, null },
                    { 2L, "09352499091", new DateTime(2023, 7, 5, 9, 14, 19, 146, DateTimeKind.Local).AddTicks(3493), "faryad.abolhassani@yahoo.com", null, null, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "farzad.jpg", "CEO", "Farzad", null, null },
                    { 3L, "09122895170", new DateTime(2023, 7, 5, 9, 14, 19, 146, DateTimeKind.Local).AddTicks(3498), "Mojgan.Nazari@gmail.com", null, null, false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mojgan.jpg", "Sell Manager", "Mojgan", null, null }
                });

            migrationBuilder.InsertData(
                table: "BlogContents",
                columns: new[] { "Id", "BlogGroupId", "BlogGroupName", "CreateDate", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "Review", "Status", "Tags", "Text", "Title", "ViewCount" },
                values: new object[] { 3L, 1L, "اخبار قبرس", new DateTime(2023, 7, 5, 9, 14, 19, 135, DateTimeKind.Local).AddTicks(3596), "CYP.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "شرایط جدید اقامت در قبرس", "خذ تابعیت با تولد فرزند در دنیا از دو قانون اصل خاک و اصل خون تبعیت میکند. برای مهاجرت از طریق تولد فرزند باید با قوانین آن کشور آشنا باشید. بسیار مهم است که بدانید آن کشور از کدام یک از این قوانین تبعیت میکند.\r\n\r\nقانون اصل خاک : در این قانون به دنیا آمدن و تولد فرزند در خاک کشور مورد نظر می باشد. بدون در نظر گرفتن اینکه پدر و مادر تابعیت کدام کشور را دارند.\r\n\r\nقانون اصل خون: در این اصل بسیار مهم آن است که یکی از پدر یا مادر یا هر دو، تبعه کشور مورد نظر باشند. در این حالت اینکه فرزند در کدام کشور متولد می شود اهمیتی ندارد.\r\n\r\nندا عباسیآنلاین", "شرایط جدید اخذ اقامت قبرس شمالی", 0L });

            migrationBuilder.InsertData(
                table: "BlogContents",
                columns: new[] { "Id", "BlogGroupId", "BlogGroupName", "CreateDate", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "Review", "Status", "Tags", "Text", "Title", "ViewCount" },
                values: new object[] { 1L, 2L, "دانشگاه های قبرس", new DateTime(2023, 7, 5, 9, 14, 19, 135, DateTimeKind.Local).AddTicks(117), "EMU.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "دانشگاه,قبرس", "بعنوان قدیمی ترین و اولین دانشگاه دولتی در قبرس شمالی، تمامی دانشکده ها و رشته های دانشگاه مدیترانه شرقی از زمان تاسیس خود در سال 1979 مورد تایید شورای عالی آموزش عالی قبرس شمالی (YODAK) و همچنین آموزش عالی کشور ترکیه (YOK) می باشند.\r\n\r\nدانشگاه مدیترانه شرقی با بهره گیری از محوطه دانشگاهی بوسعت 110 هکتار و زیرساختی با بالاترین استاندارد اروپا مفتخر به ذکر واقعیات زیر می باشد:\r\nبزرگترین محوطه دانشگاهی در منطقه\r\n12 دانشکده و 204 رشته در تمامی مقاطع\r\nمدرسه آمادگی زبان های خارجی\r\nبیش از 1100 عضو هیات علمی از 35 کشور متفاوت\r\nمعتبرترین و بزرگترین دانشگاه انگلیسی زبان در قبرس شمالی\r\nآموزش بیش از 17500 دانشجو از 110 کشور\r\nامکان یادگیری حداقل یک زبان خارجی بغیر از زبان انگلیسی برای تمامی دانشجویان\r\nبهره مندی از بهترین و مدرنترین امکانات ورزشی و فرهنگی\r\nامکان استفاده از برنامه های متنوع تبادل دانشجو با بیش از 220 دانشگاه معتبر در سرتاسر جهان برای تمامی دانشجویان\r\nارایه مدارک فارغ التحصیلی معتبر در سرتاسر دنیا\r\nارایه مدارک مورد تایید معتبرترین نهادهای اعتبارسنجی دنیا\r\nجزو دانشگاه های برتر دنیا از نظر رتبه بندی دانشگاهی تایمز (Times Higher Education)\r\nکسب 5 ستاره QS از نظر کیفیت آموزش\r\nدانشگاه مدیترانه شرقی  از طریق آموزش مهارتهای نوآوری و تشویق به خلاقیت آینده حرفه ای دانشجویان خود را در سطح بین الملل تضمین می کند.\r\n\r\n\r\nدانشگاه مدیترانه شرقی استاندارد کیفیت آموزش را در 12 دانشکده، 108 رشته کارشناسی و 96 رشته در سطوح کارشناسی ارشد و دکتری خود تعریف نموده است.", "دانشگاه مدیترانه شرقی", 0L });

            migrationBuilder.InsertData(
                table: "BlogContents",
                columns: new[] { "Id", "BlogGroupId", "BlogGroupName", "CreateDate", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "Review", "Status", "Tags", "Text", "Title", "ViewCount" },
                values: new object[] { 2L, 2L, "دانشگاه های قبرس", new DateTime(2023, 7, 5, 9, 14, 19, 135, DateTimeKind.Local).AddTicks(3581), "EMU.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "دانشگاه,قبرس", "شما هم می توانید براحتی و بصورت آنلاین فرم درخواست اخذ پذیرش جهت پیوستن به خانواده بزرگ دانشگاه مدیترانه شرقی تکمیل و ارایه نمایید. برای تکمیل فرم درخواست اخذ پذیرش تنها کافی است با وارد کردن آدرس ایمیل خود در یکی از لینکهای زیر ثبت نام نمایید. دستور العمل ثبت نام و تکمیل فرم بصورت مشروح در فیلم آموزشی ذکر شده است: \r\nرشته های مقاطع کاردانی و کارشناسی\r\nرشته های مقاطع کارشناسی ارشد و دکتری\r\nنکات مهم:\r\nدانشگاه مدیترانه شرقی در ترمهای پاییز و بهار پذیرای دانشجویان جدید می باشد.\r\nهیچ گونه امتحان ورودی برای هیچ یک از رشته ها جهت اخذ پذیرش وجود ندارد.\r\nاخذ پذیرش از دانشگاه مدیترانه شرقی برای تمامی رشته ها و مقاطع کاملا رایگان می باشد. به هیچ عنوان هیچگونه وجهی جهت اخذ پذیرش به هیچ شخصی پرداخت ننمایید.\r\nشما می توانید به راحتی از بورسیه %50 درصد برای تمامی رشته های مقطع کارشناسی و کارشناسی ارشد باستثنا رشته های پزشکی و داروسازی بهره مند شوید. ", "مدارک لازم جهت ثبت نام در دانشگاه های قبرس", 0L });

            migrationBuilder.CreateIndex(
                name: "IX_BlogContents_BlogGroupId",
                table: "BlogContents",
                column: "BlogGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_CountryId",
                table: "Cities",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_CityId",
                table: "Properties",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_PropertyTypeId",
                table: "Properties",
                column: "PropertyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyFacilities_PropertyId",
                table: "PropertyFacilities",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyGalleries_PropertyId",
                table: "PropertyGalleries",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyPlans_PropertyId",
                table: "PropertyPlans",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_PropertyVideos_PropertyId",
                table: "PropertyVideos",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_SpectacularLocationImages_SpectacularlocationId",
                table: "SpectacularLocationImages",
                column: "SpectacularlocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUs");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Banners");

            migrationBuilder.DropTable(
                name: "BlogContents");

            migrationBuilder.DropTable(
                name: "CommonQuestions");

            migrationBuilder.DropTable(
                name: "ConstructorInformation");

            migrationBuilder.DropTable(
                name: "Logo");

            migrationBuilder.DropTable(
                name: "PropertyFacilities");

            migrationBuilder.DropTable(
                name: "PropertyGalleries");

            migrationBuilder.DropTable(
                name: "PropertyPlans");

            migrationBuilder.DropTable(
                name: "PropertyVideos");

            migrationBuilder.DropTable(
                name: "RealEstateServices");

            migrationBuilder.DropTable(
                name: "Socials");

            migrationBuilder.DropTable(
                name: "SpectacularLocationImages");

            migrationBuilder.DropTable(
                name: "TeamMembers");

            migrationBuilder.DropTable(
                name: "BlogGroups");

            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Spectacularlocations");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "PropertyTypes");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
