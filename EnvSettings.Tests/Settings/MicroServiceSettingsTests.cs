using EnvSettings.Domain.Settings;
using FluentAssertions;
using Microsoft.Extensions.Configuration;

namespace EnvSettings.Tests.Settings;

public class MicroServiceSettingsTests
{
    [Fact]
    public void ShouldBeValidFromValidVariables()
    {
        string p1 = "One";
        string p2 = "Two";

        MicroServiceSettings sut = MicroServiceSettings.Create(p1, p2);
        sut.IsValid.Should().BeTrue();

    }

    [Theory]
    [InlineData("", "")]
    [InlineData("1", "")]
    [InlineData("", "2")]
    [InlineData(null, null)]
    [InlineData(null, "2")]
    [InlineData("1", null)]
    public void ShouldNotBeValidFromNotValidVariables(string p1, string p2)
    {
        MicroServiceSettings sut = MicroServiceSettings.Create(p1, p2);
        sut.IsValid.Should().BeFalse();
    }

    [Fact]
    public void ShouldBeValidFromValidConfiguration()
    {
        MicroServiceSettings sut = MicroServiceSettings.Create(TestData.Configuration);
        sut.IsValid.Should().BeTrue();
    }

    internal static class TestData
    {
        internal static IConfiguration Configuration = new ConfigurationBuilder()
         .AddInMemoryCollection(
             new Dictionary<string, string>
             {
                 ["POne"] = "p1",
                 ["PTwo"] = "p2"
             }.AsEnumerable<KeyValuePair<string, string>>()!
         )
         .Build();
    }
}
