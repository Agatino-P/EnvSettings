using Microsoft.Extensions.Configuration;

namespace EnvSettings.Domain.Settings
{
    public class MicroServiceSettings
    {

        public string POne { get; private set; }
        public string PTwo { get; private set; }

        public static MicroServiceSettings Create(string pOne, string pTwo)
            => new MicroServiceSettings(pOne, pTwo);

        public static MicroServiceSettings Create(IConfiguration configuration)
            => new MicroServiceSettings(configuration["POne"] ?? "", configuration["PTwo"] ?? "");

        public bool IsValid
            => !string.IsNullOrWhiteSpace(POne) && !string.IsNullOrWhiteSpace(PTwo);
        protected MicroServiceSettings(string pOne, string pTwo)
        {
            POne = pOne;
            PTwo = pTwo;
        }
    }


}
