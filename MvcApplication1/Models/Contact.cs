
namespace MvcApplication1.Models
{
    public class Contact
    {       
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }        
        
        public long PhoneNumber { get; set; }

        public string Status { get; set; }
    }
}