using Application.Models;
using Microsoft.Extensions.Options;
using Moq;

namespace BackEnd_UnitTest.Mocks
{
    public static class MockEmail
    {
        public static Mock<IOptions<EmailSetting>> GetMockEmail()
        {
            var mockEmail = new Mock<IOptions<EmailSetting>>();
            mockEmail.SetupAllProperties();
            mockEmail.SetupGet(m => m.Value).Returns(new EmailSetting
            {
                ApiKey = "test",
                FromAddress = "as@hotmail.com",
                FromName = "test3",
            });
            return mockEmail;
        }
    }
}
