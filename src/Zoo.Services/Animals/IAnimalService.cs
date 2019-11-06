using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Core.Domain;

namespace Zoo.Services.Animals
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimals();

        IEnumerable<Animal> GetAnimalsByHabitatId(int id);
    }
}
