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

        public IEnumerable<Habitat> GetHabitats()
        {
            return _habitatRepository.GetAll();
        }
    }
}
