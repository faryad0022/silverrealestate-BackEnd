using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BackEnd_Persistence.Migrations
{
    public partial class _1234894 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 500, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "CellPhone", "CreateDate", "Email", "IsDelete", "IsSelected", "LastUpdateDate", "Location", "Telephone", "WorkHour" },
                values: new object[,]
                {
                    { 1L, "+98-9123071411", new DateTime(2023, 5, 24, 14, 34, 25, 505, DateTimeKind.Local).AddTicks(3614), "mahancomputer49@gmail.com", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "کیش - شهرک صدف - خیابان سبلان - پلاک 27 - واحد6", "00987644446503", "شنبه تا جمعه ساعت 8-20" },
                    { 2L, "+90-5338355243", new DateTime(2023, 5, 24, 14, 34, 25, 505, DateTimeKind.Local).AddTicks(3662), "mahancomputer49@gmail.com", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "قبرس شمالی - شهرک رویال سان - پرل 105", "00987644446503", "شنبه تا جمعه ساعت 8-20" }
                });

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "BlogGroups",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 34, 25, 506, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.InsertData(
                table: "CommonQuestions",
                columns: new[] { "Id", "Answer", "CreateDate", "IsDelete", "IsSelected", "LastUpdateDate", "Question" },
                values: new object[,]
                {
                    { 1L, "قبرس با داشتن آب و هوای معتدل و مرطوب مدیترانه ایی مقصد مورد علاقه جهانگردان برای تعطیلات می باشد، با داشتن بیش از ۳۰۰ روز آفتابی و گرمایی مطلوب و کوهستان هایی در دل خود، از اعتدالی مدیترانه ایی برخوردار است.", new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(3285), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "قبرس کجاست؟" },
                    { 2L, "قبرس شمالی با داشتن ۳۶ درصد از مساحت کل جزیره قبرس به علت داشتن شرایط مهاجرتی آسان و مالیات بسیار کم در قیاس با جمهوری قبرس و سایر کشورهای اروپایی مورد توجه سرمایه گذارانی از نقاط مختلف دنیا قرار گرفته است", new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4260), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "چرا قبرس شمالی؟" },
                    { 3L, "لیر ترکیه به عنوان ارز رایج این کشور شناخته می شود ولی خرید فروش ملک به پوند انگلستان می باشد و دلار و یورو هم در کنار این دو واحد پولی مورد استفاده قرار می گیرد.", new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4270), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "واحد پولی قبرس شمالی چه می باشد؟" },
                    { 4L, "امنیت بالای قبرس شمالی در کنار رفاه مردم این کشور می تواند برای هر خانواده ایی دلیلی مناسب برای مهاجرت به قبرس شمالی باشد، بی علت نیست اگر قبرس شمالی در فهرست پنج کشور امن دنیا قرار گرفته است.", new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4272), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "آیا قبرس شمالی برای زندگی خانوادگی مناسب می باشد؟" },
                    { 5L, "برای ورود به قبرس شمالی به صورت توریستی نیازی به اخذ ویزا نخواهید داشت.  برای داشتن اقامت بیشتر، از طریق اقامت دانشجویی، خرید ملک و یا ثبت شرکت و یا اشتغال میسر خواهد بود.", new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(4274), false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "شرایط اخذ ویزا برای ورود به قبرس شمالی چگونه می باشد؟" }
                });

            migrationBuilder.InsertData(
                table: "ConstructorInformation",
                columns: new[] { "Id", "ConstructorLogo", "CreateDate", "Description", "IsDelete", "IsSelected", "LastUpdateDate", "Title" },
                values: new object[,]
                {
                    { 1L, "Noyanlar.jpg", new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(9813), "گروه شرکت های نویانلار که در سال 1973 تأسیس شد، خدمات با کیفیت بالا را در تمام زمینه های صنعت ساخت و ساز در قبرس شمالی ارائه می دهد. این یک شرکت خانوادگی موفق است که کیفیت و رشد قابل اعتماد را در صنعت ساخت و ساز فراهم می کند. پروژه های ما مطابق با طرح های ساختمانی معاصر انجام می شود تا رضایتمندی بالا را فراهم کند.این مسیر باتاسیس شرکت معماری و مهندسی با مسئولیت محدود Arken توسط معمار کهنه کار گوکان نویان آغاز شد که در دهه های 1970 و 1980 بسیاری از پروژه های معماری را امضا کرد. در سال ۱۹۸۶ یک مهندس عمران با تجربه به نام Mustafa Noyan به این تیم پیوست.", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Noyanlar Group Constructor" },
                    { 2L, "Ceaser.jpg", new DateTime(2023, 5, 24, 14, 34, 25, 507, DateTimeKind.Local).AddTicks(9826), "اگر که به دنبال خرید ملک در قبرس شمالی بوده اید، بدون شک نام سزار ریزورت‌ به گوشتان خورده است. افیک گروپ، شرکت مادر مجتمع سزار قبرس، در سال های اخیر در قبرس ترک مشهور و به دنبال آن اولین پروژه ی این شرکت به نام سزار ریزورت بر سر زبان ها افتاد. شهرک سزار قبرس شمالی با وجود قیمت نسبتا بالا خود در مقایسه با املاک منطقه توانسته در دل فارسی زبانان جا باز کند و جمع کثیری از ایرانیان را در این شهرک گرد هم آورد.\r\nشنا در استخرهای تابستانه، نوشیدن لاته گرم در کافه پاریس در فصل پاییز، پایکوبی در مهمانی های پر زرق و برق زمستانه و در نهایت پیاده روی های سرخوشانه به مقصد ساحل لانگ بیچ در فصل بهار همگی از زیبایی های شهرک سزار قبرس شمالی هستند.\r\nآنچه مجتمع سزار قبرس را از دیگر شهرک های جزیره جدا میکند، شرایط پرداخت اقساطی واحدها می باشد.\r\nوقتی پای اقساط به میان می آید، توجه به تبصره های قرارداد از مسائل حساس و چالش برانگیز می شود. قرارداد مجتمع سزار قبرس حاوی شش تا هشت صفحه با بند ها و تبصره های مختلف به زبان انگلیسی است که عدم توجه و غفلت از هر یک از این بندها ممکن است ضرر و زیان جبران ناپذیری برای خریداران به همراه داشته باشد. امکان تغییر در جزییات تبصره ها با صحبت و رایزنی مشاور املاک شما با مدیران فروش سزار ریزورت وجود دارد. بنابراین پیش از امضای هرگونه قرارداد ملک شهرک سزار قبرس شمالی حتما با مشاور املاک مسلط به زبان انگلیسی و ترکی، مشورت کرده و راهنمایی های لازم را دریافت کنید تا در آینده با مشکلات مالی و حقوقی مواجه نشوید.", false, true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ceaser Group" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "CommonQuestions",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ConstructorInformation",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.UpdateData(
                table: "AboutUs",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 10, 13, 708, DateTimeKind.Local).AddTicks(3095));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 10, 13, 712, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 10, 13, 712, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "BlogContents",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreateDate",
                value: new DateTime(2023, 5, 24, 14, 10, 13, 712, DateTimeKind.Local).AddTicks(8846));

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
    }
}
