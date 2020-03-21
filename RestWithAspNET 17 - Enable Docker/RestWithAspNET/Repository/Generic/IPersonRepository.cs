using RestWithAspNET.Model;
using System.Collections.Generic;

namespace RestWithAspNET.Repository.Generic
{
    public interface IPersonRepository : IRepository<Person>
    {
        List<Person> FindByName(string firstName, string lastName);        
    }
}
