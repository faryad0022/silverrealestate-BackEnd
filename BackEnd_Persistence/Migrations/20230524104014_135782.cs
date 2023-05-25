using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _135782 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AboutUs",
                columns: new[] { "Id", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "TeamImage", "Text" },
                values: new object[] { 1L, new DateTime(2023, 5, 24, 14, 10, 13, 708, DateTimeKind.Local).AddTicks(3095), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "املاک شبکه نقره ای با بیش از 6 سال سابقه درخشان آماده ی ارائه بهترین خدمات در راستای خرید ملک،سرمایه گذاری، اخذ اقامت، ثبت شرکت ، پذیرش دانشجویی و کلیه خدمات به همراه ارایه گشت های محلی با بکار گیری راهنمایان فارسی زبان بصورت گروهی و اختصاصی برای افراد و آژانسهای مسافرتی، به شما عزیزان در قبرس شمالی میباشد." });

            migrationBuilder.InsertData(
                table: "BlogContents",
                columns: new[] { "Id", "BlogGroupId", "BlogGroupName", "CreateDate", "ImageName", "IsDelete", "IsSelected", "LastUpdateDate", "Review", "Status", "Tags", "Text", "Title", "ViewCount" },
                values: new object[,]
                {
                    { 1L, 2L, "دانشگاه های قبرس", new DateTime(2023, 5, 24, 14, 10, 13, 712, DateTimeKind.Local).AddTicks(6156), "EMU.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "دانشگاه,قبرس", "بعنوان قدیمی ترین و اولین دانشگاه دولتی در قبرس شمالی، تمامی دانشکده ها و رشته های دانشگاه مدیترانه شرقی از زمان تاسیس خود در سال 1979 مورد تایید شورای عالی آموزش عالی قبرس شمالی (YODAK) و همچنین آموزش عالی کشور ترکیه (YOK) می باشند.\r\n\r\nدانشگاه مدیترانه شرقی با بهره گیری از محوطه دانشگاهی بوسعت 110 هکتار و زیرساختی با بالاترین استاندارد اروپا مفتخر به ذکر واقعیات زیر می باشد:\r\nبزرگترین محوطه دانشگاهی در منطقه\r\n12 دانشکده و 204 رشته در تمامی مقاطع\r\nمدرسه آمادگی زبان های خارجی\r\nبیش از 1100 عضو هیات علمی از 35 کشور متفاوت\r\nمعتبرترین و بزرگترین دانشگاه انگلیسی زبان در قبرس شمالی\r\nآموزش بیش از 17500 دانشجو از 110 کشور\r\nامکان یادگیری حداقل یک زبان خارجی بغیر از زبان انگلیسی برای تمامی دانشجویان\r\nبهره مندی از بهترین و مدرنترین امکانات ورزشی و فرهنگی\r\nامکان استفاده از برنامه های متنوع تبادل دانشجو با بیش از 220 دانشگاه معتبر در سرتاسر جهان برای تمامی دانشجویان\r\nارایه مدارک فارغ التحصیلی معتبر در سرتاسر دنیا\r\nارایه مدارک مورد تایید معتبرترین نهادهای اعتبارسنجی دنیا\r\nجزو دانشگاه های برتر دنیا از نظر رتبه بندی دانشگاهی تایمز (Times Higher Education)\r\nکسب 5 ستاره QS از نظر کیفیت آموزش\r\nدانشگاه مدیترانه شرقی  از طریق آموزش مهارتهای نوآوری و تشویق به خلاقیت آینده حرفه ای دانشجویان خود را در سطح بین الملل تضمین می کند.\r\n\r\n\r\nدانشگاه مدیترانه شرقی استاندارد کیفیت آموزش را در 12 دانشکده، 108 رشته کارشناسی و 96 رشته در سطوح کارشناسی ارشد و دکتری خود تعریف نموده است.", "دانشگاه مدیترانه شرقی", 0L },
                    { 2L, 2L, "دانشگاه های قبرس", new DateTime(2023, 5, 24, 14, 10, 13, 712, DateTimeKind.Local).AddTicks(8834), "EMU.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "دانشگاه,قبرس", "شما هم می توانید براحتی و بصورت آنلاین فرم درخواست اخذ پذیرش جهت پیوستن به خانواده بزرگ دانشگاه مدیترانه شرقی تکمیل و ارایه نمایید. برای تکمیل فرم درخواست اخذ پذیرش تنها کافی است با وارد کردن آدرس ایمیل خود در یکی از لینکهای زیر ثبت نام نمایید. دستور العمل ثبت نام و تکمیل فرم بصورت مشروح در فیلم آموزشی ذکر شده است: \r\nرشته های مقاطع کاردانی و کارشناسی\r\nرشته های مقاطع کارشناسی ارشد و دکتری\r\nنکات مهم:\r\nدانشگاه مدیترانه شرقی در ترمهای پاییز و بهار پذیرای دانشجویان جدید می باشد.\r\nهیچ گونه امتحان ورودی برای هیچ یک از رشته ها جهت اخذ پذیرش وجود ندارد.\r\nاخذ پذیرش از دانشگاه مدیترانه شرقی برای تمامی رشته ها و مقاطع کاملا رایگان می باشد. به هیچ عنوان هیچگونه وجهی جهت اخذ پذیرش به هیچ شخصی پرداخت ننمایید.\r\nشما می توانید به راحتی از بورسیه %50 درصد برای تمامی رشته های مقطع کارشناسی و کارشناسی ارشد باستثنا رشته های پزشکی و داروسازی بهره مند شوید. ", "مدارک لازم جهت ثبت نام در دانشگاه های قبرس", 0L },
                    { 3L, 1L, "اخبار قبرس", new DateTime(2023, 5, 24, 14, 10, 13, 712, DateTimeKind.Local).AddTicks(8846), "CYP.jpg", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, true, "شرایط جدید اقامت در قبرس", "خذ تابعیت با تولد فرزند در دنیا از دو قانون اصل خاک و اصل خون تبعیت میکند. برای مهاجرت از طریق تولد فرزند باید با قوانین آن کشور آشنا باشید. بسیار مهم است که بدانید آن کشور از کدام یک از این قوانین تبعیت میکند.\r\n\r\nقانون اصل خاک : در این قانون به دنیا آمدن و تولد فرزند در خاک کشور مورد نظر می باشد. بدون در نظر گرفتن اینکه پدر و مادر تابعیت کدام کشور را دارند.\r\n\r\nقانون اصل خون: در این اصل بسیار مهم آن است که یکی از پدر یا مادر یا هر دو، تبعه کشور مورد نظر باشند. در این حالت اینکه فرزند در کدام کشور متولد می شود اهمیتی ندارد.\r\n\r\nندا عباسیآنلاین", "شرایط جدید اخذ اقامت قبرس شمالی", 0L }
                });

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 10, 13, 713, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 10, 13, 713, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 10, 13, 713, DateTimeKind.Local).AddTicks(4715));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 13, 35, 17, 538, DateTimeKind.Local).AddTicks(5334));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 13, 35, 17, 540, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 13, 35, 17, 540, DateTimeKind.Local).AddTicks(8599));
        }
    }
}
