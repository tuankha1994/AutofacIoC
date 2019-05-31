using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacIoC
{
    public interface IAppService
    {
        void ShowAllContact();
    }
    public class AppService : IAppService
    {
        private readonly IContactRepo _iContactRepo;

        public AppService(IContactRepo contactRepo)
        {
            _iContactRepo = contactRepo;
        }
        public void ShowAllContact()
        {
            var listContact = _iContactRepo.GetAllContacts();
            foreach (var item in listContact)
            {
                Console.WriteLine("Name: " + item.Name + ", Phone: " + item.Phone);
            }
            
        }
    }
}
