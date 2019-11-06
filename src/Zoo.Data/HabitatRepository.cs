using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Zoo.Core.Domain;

namespace Zoo.Data
{
    public class HabitatRepository : EfRepository<Habitat>
    {
        public HabitatRepository(DbContext context) 
            : base(context)
        {
        }

        public override IEnumerable<Habitat> GetAll()
        {
            return base.Table.Include(a => a.Animals).ToList();
        }
    }
}
