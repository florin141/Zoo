using System.Collections.Generic;

namespace Zoo.Core.Domain
{
    /// <summary>
    /// Habitat entity
    /// </summary>
    public class Habitat : BaseEntity
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Habitat()
        {
            Animals = new HashSet<Animal>();
        }

        /// <summary>
        /// Habitat name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Habitat description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Habitat picture
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Animals
        /// </summary>
        public virtual ICollection<Animal> Animals { get; set; }
    }
}
