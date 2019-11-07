using System;
using System.Collections.Generic;
using System.Linq;
using Zoo.Core.Data;
using Zoo.Core.Domain;

namespace Zoo.Services.Animals
{
    public class AnimalService : IAnimalService
    {
        private readonly IRepository<Animal> _animalRepository;

        public AnimalService(IRepository<Animal> animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public void DeleteAnimal(Animal animal)
        {
            if (animal == null) throw new ArgumentNullException(nameof(animal));
            
            _animalRepository.Delete(animal);
        }

        public void DeleteAnimals(IEnumerable<Animal> animals)
        {
            if (animals == null) throw new ArgumentNullException(nameof(animals));

            _animalRepository.Delete(animals);
        }

        public Animal GetAnimalById(int id)
        {
            if (id <= 0) return null;

            return _animalRepository.GetById(id);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            return _animalRepository.GetAll();
        }

        public IEnumerable<Animal> GetAnimalsByHabitatId(int id)
        {
            return _animalRepository.Table.Where(h => h.HabitatId == id);
        }

        public void InsertAnimal(Animal animal)
        {
            if (animal == null) throw new ArgumentNullException(nameof(animal));

            _animalRepository.Insert(animal);
        }

        public void InsertAnimals(IEnumerable<Animal> animals)
        {
            if (animals == null) throw new ArgumentNullException(nameof(animals));

            _animalRepository.Insert(animals);
        }

        public void UpdateAnimal(Animal animal)
        {
            if (animal == null) throw new ArgumentNullException(nameof(animal));

            _animalRepository.Update(animal);
        }

        public void UpdateAnimals(IEnumerable<Animal> animals)
        {
            if (animals == null) throw new ArgumentNullException(nameof(animals));

            _animalRepository.Update(animals);
        }
    }
}
