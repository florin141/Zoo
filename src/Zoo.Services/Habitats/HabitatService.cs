using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Zoo.Core.Data;
using Zoo.Core.Domain;

namespace Zoo.Services.Habitats
{
    public class HabitatService : IHabitatService
    {
        private readonly IRepository<Habitat> _habitatRepository;

        public HabitatService(IRepository<Habitat> habitatRepository)
        {
            _habitatRepository = habitatRepository;
        }

        public Habitat GetHabitatById(int id)
        {
            if (id <= 0) return null;

            return _habitatRepository.GetById(id);
        }

        public IEnumerable<Habitat> GetHabitats()
        {
            return _habitatRepository.GetAll();
        }

        public void InsertHabitat(Habitat habitat)
        {
            if (habitat == null) throw new ArgumentNullException(nameof(habitat));

            _habitatRepository.Insert(habitat);
        }

        public void InsertHabitats(IEnumerable<Habitat> habitats)
        {
            if (habitats == null) throw new ArgumentNullException(nameof(habitats));

            _habitatRepository.Insert(habitats);
        }

        public void UpdateHabitat(Habitat habitat)
        {
            if (habitat == null) throw new ArgumentNullException(nameof(habitat));

            _habitatRepository.Update(habitat);
        }

        public void UpdateHabitats(IEnumerable<Habitat> habitats)
        {
            if (habitats == null) throw new ArgumentNullException(nameof(habitats));

            _habitatRepository.Update(habitats);
        }

        public void DeleteHabitat(Habitat habitat)
        {
            if (habitat == null) throw new ArgumentNullException(nameof(habitat));

            _habitatRepository.Update(habitat);
        }

        public void DeleteHabitats(IEnumerable<Habitat> habitats)
        {
            if (habitats == null) throw new ArgumentNullException(nameof(habitats));

            _habitatRepository.Update(habitats);
        }
    }
}
