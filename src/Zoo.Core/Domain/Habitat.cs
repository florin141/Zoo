using System.Collections.Generic;

namespace Zoo.Core.Domain
{
    public class Habitat : BaseEntity
    {
        public Habitat()
        {
            Animals = new HashSet<Animal>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
