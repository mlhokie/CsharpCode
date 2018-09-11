using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClassExamples.Contacts
{
    public class Contact
    {
        private string emailAddress = string.Empty;
        public Contact()
        {
            PhoneNumbers = new List<PhoneNumber>();
        }

        internal Contact(BinaryReader reader) : this()
        {
            Name = reader.ReadString();
            EmailAddress = reader.ReadString();
            int nPhones = reader.ReadInt32();
            for (int i = 0; i < nPhones; ++i) PhoneNumbers.Add(new PhoneNumber(reader));
        }

        public string Name { get; set; }


        public List<PhoneNumber> PhoneNumbers { get; private set; }

        public string EmailAddress
        {
            get { return emailAddress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    emailAddress = string.Empty;
                }
                //expression from regexlib.com
                const string emailRegex = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
                if (Regex.Match(value, emailRegex).Success)
                {
                    emailAddress = value;
                }
                else throw new FormatException("Email format is incorrect.");
            }
        }

        internal void Serialize(BinaryWriter writer)
        {
            writer.Write(Name);
            writer.Write(EMailAddress);
            writer.Write(PhoneNumbers.Count);
            foreach (PhoneNumber p in PhoneNumbers)
            {
                p.Serialize(writer);
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is Contact c)
            {
                return string.Equals(Name, c.Name) &&
                       PhoneNumbers.Count == c.PhoneNumbers.Count &&
                       PhoneNumbers.All(p => c.PhoneNumbers.Contains(p));
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public bool AddPhoneNumber(PhoneNumber phoneNumber)
        {
            if (phoneNumber == null) return false;
            if (PhoneNumbers.Contains(phoneNumber)) return false;
            PhoneNumbers.Add(phoneNumber);
            return true;
        }

        public enum PhoneType{ Mobile, Home, Business}

        public class PhoneNumber
        {
            string number = string.Empty;
            public PhoneNumber() { }

            internal PhoneNumber(BinaryReader reader)
            {
                Number = reader.ReadString();
                Type = (PhoneType) reader.ReadInt32();
            }

            public string Number
            {
                get { return number; }
                set
                {
                    number = value ?? string.Empty;
                }
            }
            public PhoneType Type { get; set; }

            internal void Serialize(BinaryWriter writer)
            {
                writer.Write(Number);
                writer.Write((int)Type);
            }

            public override bool Equals(object obj)
            {
                if (obj is PhoneNumber p)
                {
                    return Type == p.Type && string.Equals(Number, p.Number);
                }
                else return false;
            }

            public override int GetHashCode()
            {
                return Number.GetHashCode();
            }



        }

        public class ContactList : IEnumerable
        {
            private List<Contact> contacts = new List<Contact>();

            public ContactList() { }

            public ContactList(Stream stream)
            {
                LoadFromStream(stream);
            }

            public ContactList(string filePath)
            {
                using (Stream stream = File.OpenRead(filePath)) LoadFromStream(stream);
            }

            private void LoadFromStream(Stream stream)
            {
                contacts.Clear();
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    int count = reader.ReadInt32();
                    for (int i = 0; i < count; ++i) contacts.Add(new Contact(reader));
                }
            }

            public int Count => contacts.Count;

            public void Add(Contact contact)
            {
                if (contact == null) throw new ArgumentNullException(nameof(contact));
                contacts.Add(contact);
            }

            public bool Remove(Contact c) => contacts.Remove(c);

            public bool Contains(Contact c) => contacts.Contains(c);

            public Contact this[int index]
            {
                get { return contacts[index]; }
            }

            public void Serialize(Stream stream)
            {
                using (BinaryWriter writer = new BinaryWriter(stream))
                {
                    writer.Write(contacts.Count);
                    foreach (Contact c in contacts) c.Serialize(writer);
                }
            }

            public void Serialize(string filePath)
            {
                using (FileStream fstream = File.OpenWrite(filePath)) Serialize(fstream);
            }

            #region IEnumerable implementation

            public IEnumerator GetEnumerator()
            {
                return contacts.GetEnumerator();
            }

            #endregion
        }
   
    }



}