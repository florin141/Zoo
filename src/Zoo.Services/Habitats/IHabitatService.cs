using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Core.Domain;

namespace Zoo.Services.Habitats
{
    public interface IHabitatService
    {
        IEnumerable<Habitat> GetHabitats();
    }
}
