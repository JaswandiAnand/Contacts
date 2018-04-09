using System.Collections.Generic;

namespace MvcApplication1.Models
{
    interface IContactRepository
    {
        IEnumerable<Contact> GetAll();
        Contact Get(int id);
        Contact Add(Contact Contact);
        Contact Update(Contact Contact);
        IEnumerable<Contact> Delete(int id);
    }
}
