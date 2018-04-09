using System.Collections.Generic;
using System.Web.Http;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class ContactController : ApiController
    {
       static readonly IContactRepository ContactRepository = new ContactRepository();

       //GET all Contacts
                                        
        //api/Contact

        public IEnumerable<Contact> GetAllContacts()
        {
            return ContactRepository.GetAll();
        }


        // GET a particular Contact

        //api/Contact/2
        public Contact GetContact(int id)
        {
            return ContactRepository.Get(id); ;

        }

        //POST (insert) an Contact

        //api/Contact/
        public Contact PostContact(Contact Contact)
        {
            return ContactRepository.Add(Contact);
        }

        //PUT (update) an Contact

        //api/Contact/{id}
        public Contact PutContact(int id, Contact Contact)
        {
            Contact.id = id;
            return ContactRepository.Update(Contact);
            
        }

        //DELETE an Contact

        //api/Contact/{id}
        public IEnumerable<Contact> DeleteContact(int id)
        {
            return ContactRepository.Delete(id);           

        }
    }
}
