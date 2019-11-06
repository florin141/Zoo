using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public IEnumerable<Animal> GetAnimals()
        {
            return _animalRepository.GetAll();
        }

        public IEnumerable<Animal> GetAnimalsByHabitatId(int id)
        {
            return _animalRepository.Table.Where(h => h.HabitatId == id);
        }
    }
}
