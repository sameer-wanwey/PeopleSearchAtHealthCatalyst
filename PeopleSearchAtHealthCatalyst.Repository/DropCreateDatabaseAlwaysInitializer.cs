using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSearchAtHealthCatalyst.Repository
{
    public class DropCreateDatabaseAlwaysInitializer : DropCreateDatabaseAlways<PeopleSearchAtHealthCatalystContext>
    {
        protected override void Seed(PeopleSearchAtHealthCatalystContext context)
        {
            DataInitializer.Initialize(context);
            base.Seed(context);
        }
    }
}
