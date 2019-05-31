using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacIoC
{
    public interface IContactRepo
    {
        List<Contact> GetAllContacts();
    }
    public class ContactRepo : IContactRepo
    {
        public List<Contact> GetAllContacts()
        {
            return ContactData.ListContacts;
        }
    }

}
