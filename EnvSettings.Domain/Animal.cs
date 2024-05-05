namespace EnvSettings.Domain
{
    public abstract class Animal
    {
        protected abstract string Sound { get; }

        public string MakeSound() => $"Said...{Sound}";
    }

}