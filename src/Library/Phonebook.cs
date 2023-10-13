using System.Collections.Generic;

namespace Library
{
    public class Phonebook
    {
        private List<Contact> persons;

        public Phonebook(Contact owner)
        {
            this.Owner = owner;
            this.persons = new List<Contact>();
        }

        public Contact Owner { get; }

        public List<Contact> Search(string[] names)
        {
            List<Contact> result = new List<Contact>();

            foreach (Contact person in this.persons)
            {
                foreach (string name in names)
                {
                    if (person.Name.Equals(name))
                    {
                        result.Add(person);
                    }
                }
            }

            return result;
        }

        public void AddContact(Contact contacto)
        {
            persons.Add(contacto);
        }

        public void RemoveContact(Contact contacto)
        {
            persons.Remove(contacto);
        }

        public void SendMessage(string[] destinatarios, string texto)
        {
            WhatsAppChannel canal = new();
            foreach(Contact destinatario in Search(destinatarios))
            {
                Message mensaje = canal.CreateMessage(Owner, destinatario, texto);
                canal.Send(mensaje);
            }
        }
    }
}