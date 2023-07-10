using Domain.Entities.GeneralSiteInformation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace BackEnd_Persistence.EntityConfiguration.SeedData.General
{
    public class SeedCommonQuestions : IEntityTypeConfiguration<CommonQuestion>
    {
        public void Configure(EntityTypeBuilder<CommonQuestion> builder)
        {
            builder.HasData(
                new CommonQuestion
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Question = "قبرس کجاست؟",
                    Answer = "قبرس با داشتن آب و هوای معتدل و مرطوب مدیترانه ایی مقصد مورد علاقه جهانگردان برای تعطیلات می باشد، با داشتن بیش از ۳۰۰ روز آفتابی و گرمایی مطلوب و کوهستان هایی در دل خود، از اعتدالی مدیترانه ایی برخوردار است."
                },
                new CommonQuestion
                {
                    Id = 2,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Question = "چرا قبرس شمالی؟",
                    Answer = "قبرس شمالی با داشتن ۳۶ درصد از مساحت کل جزیره قبرس به علت داشتن شرایط مهاجرتی آسان و مالیات بسیار کم در قیاس با جمهوری قبرس و سایر کشورهای اروپایی مورد توجه سرمایه گذارانی از نقاط مختلف دنیا قرار گرفته است"
                },
                new CommonQuestion
                {
                    Id = 3,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Question = "واحد پولی قبرس شمالی چه می باشد؟",
                    Answer = "لیر ترکیه به عنوان ارز رایج این کشور شناخته می شود ولی خرید فروش ملک به پوند انگلستان می باشد و دلار و یورو هم در کنار این دو واحد پولی مورد استفاده قرار می گیرد."
                },
                new CommonQuestion
                {
                    Id = 4,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Question = "آیا قبرس شمالی برای زندگی خانوادگی مناسب می باشد؟",
                    Answer = "امنیت بالای قبرس شمالی در کنار رفاه مردم این کشور می تواند برای هر خانواده ایی دلیلی مناسب برای مهاجرت به قبرس شمالی باشد، بی علت نیست اگر قبرس شمالی در فهرست پنج کشور امن دنیا قرار گرفته است."
                },
                new CommonQuestion
                {
                    Id = 5,
                    CreateDate = DateTime.Now,
                    IsDelete = false,
                    IsSelected = true,
                    Question = "شرایط اخذ ویزا برای ورود به قبرس شمالی چگونه می باشد؟",
                    Answer = "برای ورود به قبرس شمالی به صورت توریستی نیازی به اخذ ویزا نخواهید داشت.  برای داشتن اقامت بیشتر، از طریق اقامت دانشجویی، خرید ملک و یا ثبت شرکت و یا اشتغال میسر خواهد بود."
                }
                );
        }
    }
}
