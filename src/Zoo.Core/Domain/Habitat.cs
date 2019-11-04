using System;
using System.Collections.Generic;
using System.Text;

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

        public virtual ICollection<Animal> Animals { get; set; }
    }
}
