namespace EnvSettings.Domain.Resolvers.Base
{
    public interface IMicroServiceResolver
    {
        bool IsValid { get; }

        string Resolved();
    }
}