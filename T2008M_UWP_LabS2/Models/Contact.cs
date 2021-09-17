using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2008M_UWP_LabS2.Models
{
    public class Contact
    {
        public string Name { get; set; }

        public string Tel { get; set; }

        public Contact() { }

        public Contact(string name, string tel)
        {
            Name = name;
            Tel = tel;
        }
    }

    public class ContactManager
    {
        public static List<Contact> GetContacts()
        {
            var contacts = new List<Contact>();
            
            contacts.Add(new Contact("Carilyn Meacher", "922-108-4874"));
            contacts.Add(new Contact("Randell Congrave", "440-797-6259"));
            contacts.Add(new Contact("Stacie Olek", "416-368-3492"));
            contacts.Add(new Contact("Christie Heatly", "845-109-0078"));
            contacts.Add(new Contact("Melesa Akister", "668-696-5472"));
            contacts.Add(new Contact("Carilyn Meacher", "922-108-4874"));
            contacts.Add(new Contact("Randell Congrave", "440-797-6259"));
            contacts.Add(new Contact("Stacie Olek", "416-368-3492"));
            contacts.Add(new Contact("Christie Heatly", "845-109-0078"));
            contacts.Add(new Contact("Melesa Akister", "668-696-5472"));
            contacts.Add(new Contact("Carilyn Meacher", "922-108-4874"));
            contacts.Add(new Contact("Randell Congrave", "440-797-6259"));
            contacts.Add(new Contact("Stacie Olek", "416-368-3492"));
            contacts.Add(new Contact("Christie Heatly", "845-109-0078"));
            contacts.Add(new Contact("Melesa Akister", "668-696-5472"));
            contacts.Add(new Contact("Melesa Akister", "668-696-5472"));
            contacts.Add(new Contact("Carilyn Meacher", "922-108-4874"));
            contacts.Add(new Contact("Randell Congrave", "440-797-6259"));
            contacts.Add(new Contact("Stacie Olek", "416-368-3492"));
            contacts.Add(new Contact("Christie Heatly", "845-109-0078"));
            contacts.Add(new Contact("Melesa Akister", "668-696-5472"));
            contacts.Add(new Contact("Carilyn Meacher", "922-108-4874"));
            contacts.Add(new Contact("Randell Congrave", "440-797-6259"));
            contacts.Add(new Contact("Stacie Olek", "416-368-3492"));
            contacts.Add(new Contact("Christie Heatly", "845-109-0078"));
            contacts.Add(new Contact("Melesa Akister", "668-696-5472"));
            return contacts;
        }
    }
}
