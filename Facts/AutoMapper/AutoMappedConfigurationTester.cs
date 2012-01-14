using AutoMapper;
using ElephantQuiz.Web.Infrastructure.AutoMapper;
using Xunit;

namespace Facts.AutoMapper
{
    class AutoMappedConfigurationTester
    {
        [Fact]
        public void AssertConfigurationIsValid()
        {
            AutoMapperConfiguration.Configure();
            Mapper.AssertConfigurationIsValid();
        }
    }
}
