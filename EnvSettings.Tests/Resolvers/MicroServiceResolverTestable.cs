using EnvSettings.Domain.Resolvers.Base;
using EnvSettings.Domain.Settings;
using Microsoft.Extensions.Configuration;

namespace EnvSettings.Tests.Resolvers;
internal class MicroServiceResolverTestable : MicroServiceResolver
{
    public static string? Local => "Testable";

    public static MicroServiceResolverTestable Create(MicroServiceSettings configuration)
        => Create<MicroServiceResolverTestable>(configuration);
}
