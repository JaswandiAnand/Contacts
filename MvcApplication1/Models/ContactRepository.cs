using System;
using System.Collections.Generic;

namespace MvcApplication1.Models
{
    public class ContactRepository : IContactRepository
    {
        private List<Contact> Contacts = new List<Contact>();
        private int _nextId = 1;

        public ContactRepository()
        {
            Add(new Contact { id = 1, FirstName = "Michale", LastName = "Louri", Email = "Michale@gmail.com", Status = "Active", PhoneNumber = 9923701766 });
            Add(new Contact { id = 2, FirstName = "Sunil", LastName = "Das", Email = "Sunil@gmail.com", Status = "Active", PhoneNumber = 9923701766 });
            Add(new Contact { id = 3, FirstName = "Robin", LastName = "Pandey", Email = "Robin@gmail.com", Status = "Active", PhoneNumber = 9923701766 });
            Add(new Contact { id = 4, FirstName = "Mona", LastName = "Singh", Email = "Mona@gmail.com", Status = "Active", PhoneNumber = 9923701766 });
            Add(new Contact { id = 5, FirstName = "Micha", LastName = "Shetti", Email = "Micha@gmail.com", Status = "Active", PhoneNumber = 9923701766 });
            
        }

        public IEnumerable<Contact> GetAll()
        {
            return Contacts;
        }

        public Contact Get(int id)
        {
            return Contacts.Find(e => e.id == id);
        }

        public Contact Add(Contact Contact)
        {
            if (Contact == null)
            {
                throw new ArgumentNullException("Contact");
            }
            Contact.id= _nextId++;
            Contacts.Add(Contact);
            return Contact;
        }

        public Contact Update(Contact Contact)
        {
            if (Contact == null)
            {
                throw new ArgumentNullException("Contact");
            }
            int index = Contacts.FindIndex(e => e.id == Contact.id);            
            Contacts.RemoveAt(index);
            Contacts.Add(Contact);
            return Contact;
        }

        public IEnumerable<Contact> Delete(int id)
        {
            Contacts.RemoveAll(e => e.id == id);
            return Contacts;
        }
    }
}