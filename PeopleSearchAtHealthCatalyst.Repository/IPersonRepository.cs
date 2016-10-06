using PeopleSearchAtHealthCatalyst.Model;
using System.Collections.Generic;

namespace PeopleSearchAtHealthCatalyst.Repository
{
    public interface IPersonRepository
    {
        List<Person> SearchPerson(string searchText);
        List<Person> GetPeople();
    }
}
