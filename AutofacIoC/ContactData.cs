using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacIoC
{
    public class ContactData
    {
        public static List<Contact> ListContacts { get; } = new List<Contact>
        {
            new Contact { Name= "An", Phone = "123456"},
            new Contact { Name= "Anh", Phone = "54321"},
            new Contact { Name= "Ba", Phone = "6575756"},
            new Contact { Name= "Chaien", Phone = "07886687"},
        };
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Phone { get; set; }
    }
}
