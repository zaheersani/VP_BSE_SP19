using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstConsoleApp
{
    public enum ContactType { Name, Number }

    public class PhoneBook
    {
        private List<Contact> cList = new List<Contact>();

        public void AddContact(Contact contact)
        {
            cList.Add(contact);
        }

        public List<Contact> GetAllContacts()
        {
            return this.cList;
        }

        public Contact GetContact(int index)
        {
            return cList[index];
        }

        public Contact this[int index]
        {
            get
            {
                return this.cList[index];
            }
            set
            {
                this.cList[index] = value;
            }
        }

        public Contact this[string Name]
        {
            get
            {
                foreach (var item in cList)
                {
                    if (item.Name.StartsWith(Name))
                        return item;
                }
                return new Contact();
            }
            // TODO: Write set part of indexer. It searches for name and replaces contact
        }

        public Contact this[string Number, ContactType contactType]
        {
            get
            {
                return this.cList.Find(x => x.Number.StartsWith(Number));
            }
            //TODO: Convert this indexer as generic indexer which works with Name and Number
            // Based on user selection of ContactType
        }

    }
    public class Contact
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.Number;
        }
    }
}
