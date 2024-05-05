using EnvSettings.Domain;
using System;

namespace EnvSettings.Domain
{


    public class Cat : Animal, IConcreteAnimal
    {
        public string LocalSound => "Local Cat sound";

        protected override string Sound => "Cat sound";
    }

}