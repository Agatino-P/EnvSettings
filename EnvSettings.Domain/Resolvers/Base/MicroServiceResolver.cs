using EnvSettings.Domain.Settings;
using Microsoft.Extensions.Configuration;

namespace EnvSettings.Domain.Resolvers.Base
{
    public abstract class MicroServiceResolver : IMicroServiceResolver
    {
        protected MicroServiceSettings? _configuration;


        public static T Create<T>(MicroServiceSettings configuration) where T : MicroServiceResolver, new()
        {
            T t = new T();
            t.Initialize(configuration);
            return t;
        }

        protected void Initialize(MicroServiceSettings configuration)
            => _configuration = configuration;


        public string Resolved()
            => $"{_configuration?.POne}{_configuration?.PTwo}";

        protected MicroServiceResolver()
        {
            _configuration = null;
        }

        public virtual bool IsValid => _configuration?.IsValid ?? false;
    }
}