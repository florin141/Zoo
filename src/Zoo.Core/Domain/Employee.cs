using System;

namespace Zoo.Core.Domain
{
    /// <summary>
    /// Employee entity
    /// </summary>
    public class Employee : BaseEntity
    {
        /// <summary>
        /// Employee first name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Employee last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Employee birth date
        /// </summary>
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// Employee picture
        /// </summary>
        public string Picture { get; set; }
    }
}
