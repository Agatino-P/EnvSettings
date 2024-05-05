using EnvSettings.Domain.Settings;
using FluentAssertions;
using Microsoft.Extensions.Configuration;

namespace EnvSettings.Tests.Resolvers;
public class MicroServiceResolverTests
{

    [Fact]
    public void ShouldResolveLocal()
    {
        MicroServiceResolverTestable.Local.Should().Be("Testable");
    }

    [Fact]
    public void ShouldResolveByMicroServiceSettings()
    {
        MicroServiceSettings microServiceSettings = MicroServiceSettings.Create("p1","p2");

        MicroServiceResolverTestable sut = MicroServiceResolverTestable.Create(microServiceSettings);
        string actual = sut.Resolved();
        actual.Should().Be("p1p2");
    }

}
