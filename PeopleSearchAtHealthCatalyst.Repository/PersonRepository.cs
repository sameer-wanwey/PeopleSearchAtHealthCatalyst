using PeopleSearchAtHealthCatalyst.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSearchAtHealthCatalyst.Repository
{
    public class PersonRepository : RepositoryBase<PeopleSearchAtHealthCatalystContext>, IPersonRepository
    {
        public List<Person> GetPeople()
        {
            return DataContext.people.ToList();
        }

        public List<Person> SearchPerson(string searchText)
        {
            var name = searchText.Split(' ');
            return DataContext.people.Where(P => name.Any(n => P.FirstName.Contains(n)) || name.Any(n => P.LastName.Contains(n))).ToList();
        }

        public void DeletePerson(Person p)
        {
            DataContext.people.Remove(p);
        }

        public void Save()
        {
            DataContext.SaveChanges();
        }
    }
}
