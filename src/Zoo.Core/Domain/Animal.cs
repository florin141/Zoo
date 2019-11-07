namespace Zoo.Core.Domain
{
    /// <summary>
    /// Animal
    /// </summary>
    public class Animal : BaseEntity
    {
        /// <summary>
        /// Animal name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Animal description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Animal picture
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// Habitat identifier
        /// </summary>
        public virtual int HabitatId { get; set; }

        /// <summary>
        /// Habitat navigation property
        /// </summary>
        public virtual Habitat Habitat { get; set; }
    }
}
