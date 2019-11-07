using System.Collections.Generic;
using Zoo.Core.Domain;

namespace Zoo.Services.Animals
{
    public interface IAnimalService
    {
        IEnumerable<Animal> GetAnimalsByHabitatId(int id);

        Animal GetAnimalById(int id);

        IEnumerable<Animal> GetAnimals();

        void InsertAnimal(Animal animal);

        void InsertAnimals(IEnumerable<Animal> animals);

        void UpdateAnimal(Animal animal);

        void UpdateAnimals(IEnumerable<Animal> animals);

        void DeleteAnimal(Animal animal);

        void DeleteAnimals(IEnumerable<Animal> animals);
    }
}
