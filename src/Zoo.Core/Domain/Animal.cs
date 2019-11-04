using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Core.Domain
{
    public class Animal : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual int HabitatId { get; set; }
        public virtual Habitat Habitat { get; set; }
    }
}
