using Application.Models;
using BackEnd_Infrastructure.Mail;
using BackEnd_UnitTest.Mocks;
using Microsoft.Extensions.Options;
using Moq;
using Shouldly;
using System.Threading.Tasks;
using Xunit;


namespace BackEnd_UnitTest.Facts.Emails
{
    public class EmailSenderTest
    {
        private readonly Mock<IOptions<EmailSetting>> _mock;
        public EmailSenderTest()
        {
            _mock = MockEmail.GetMockEmail();
        }

        [Fact]
        public async Task Valid_SendEmail()
        {
            //Arrange

            var send = new EmailSender(_mock.Object);
            //Act

            var res = await send.SendEmailAsync(new Email { Body = "dfghdfh", Subject = "cvbfgd", To = "a@google.com" });

            //Arrest Return false because apikey is wrong
            res.ShouldBe(false);
        }
    }
}
