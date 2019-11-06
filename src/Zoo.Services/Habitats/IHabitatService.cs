using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Core.Domain;

namespace Zoo.Services.Habitats
{
    public interface IHabitatService
    {
        Habitat GetHabitatById(int id);

        IEnumerable<Habitat> GetHabitats();

        void InsertHabitat(Habitat habitat);

        void InsertHabitats(IEnumerable<Habitat> habitats);

        void UpdateHabitat(Habitat habitat);

        void UpdateHabitats(IEnumerable<Habitat> habitats);

        void DeleteHabitat(Habitat habitat);

        void DeleteHabitats(IEnumerable<Habitat> habitats);
    }
}
