namespace EnvSettings.Domain
{
    public interface IConcreteAnimal
    {
        public string LocalSound { get; }
        public string MakeSound();
    }

}