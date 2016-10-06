using PeopleSearchAtHealthCatalyst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSearchAtHealthCatalyst.Repository
{
    internal static class DataInitializer
    {
        internal static void Initialize(PeopleSearchAtHealthCatalystContext context)
        {
            context.people.Add(new Person() { FirstName="Sameer", LastName="Wanwey",
                Address1 = "789 San Carlos Road",
                Address2 = "North Tonawanda", City="NY", State="NY", PostalCode="14120",
                Age =32, Interests="Cricket, Reading" ,
                CreatedBy ="system", CreatedDate=DateTime.Now});

            context.people.Add(new Person()
            {
                FirstName = "Gina",
                LastName = "Revera",
                Address1 = "92 santa cruz road",
                Address2 = "west cost",
                City = "Nerela",
                State = "OR",
                PostalCode = "42020",
                Age = 32,
                Interests = "Running, Biking",
                CreatedBy = "system",
                CreatedDate = DateTime.Now
            });
            context.people.Add(new Person()
            {
                FirstName = "Eli",
                LastName = "Olentor",
                Address1 = "2240 Deckear lake drive",
                Address2 = null,
                City = "SLC",
                State = "UT",
                PostalCode = "44119",
                Age = 22,
                Interests = "Photography, Music",
                CreatedBy = "system",
                CreatedDate = DateTime.Now
            });
            context.people.Add(new Person()
            {
                FirstName = "Amanda",
                LastName = "Stark",
                Address1 = "129 Bear lake drive", 
                Address2 = "East Navada",
                City = "SFO",
                State = "CA",
                PostalCode = "21190",
                Age = 42,
                Interests = "Swimming, Yoga",
                CreatedBy = "system",
                CreatedDate = DateTime.Now
            });

            context.people.Add(new Person()
            {
                FirstName = "Laureen",
                LastName = "Ott",
                Address1 = "5120 west 3200 south",
                Address2 = null,
                City = "Stamford",
                State = "CN",
                PostalCode = "56120",
                Age = 18,
                Interests = "Soccar, Hocky",
                CreatedBy = "system",
                CreatedDate = DateTime.Now
            });

            context.SaveChanges();
        }
    }
}
