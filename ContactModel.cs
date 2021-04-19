using System;
namespace LocalContact
{
    public class ContactModel
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public ContactModel(string name, string phoneNumber)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
        }
    }
}
