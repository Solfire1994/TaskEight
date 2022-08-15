using System;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;


namespace PartFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact[] contact = new Contact[] { new Contact("Karunny Dzmitry", "Slobodskaya", 79, 54, "+375298537808", "+375172777428"),
                new Contact("Karunny Tatsiana", "Slobodskaya", 79, 54, "+375291446814", "+375172777428") };

            XDocument xdoc = new XDocument();
            XElement[] person = new XElement[contact.Length];
            for (int i = 0; i < contact.Length; i++)
            {
                person[i] = new XElement("Person");
                XAttribute personNameAttr = new XAttribute("name", contact[i].FullName);
                person[i].Add(personNameAttr);

                XElement address = new XElement("Address");
                XElement addressstreetElem = new XElement("Street", contact[i].Street);
                XElement addresshouseElem = new XElement("HouseNumber", contact[i].House);
                XElement addressflattElem = new XElement("FlatNumber", contact[i].Flat);
                address.Add(addressstreetElem);
                address.Add(addresshouseElem);
                address.Add(addressflattElem);

                XElement phones = new XElement("Phones");
                XElement mobilePhone = new XElement("MobilePhone", contact[i].MobileNumber);
                XElement flatPhone = new XElement("FlatPhone", contact[i].HomeNumber);
                phones.Add(mobilePhone);
                phones.Add(flatPhone);

                person[i].Add(address);
                person[i].Add(phones);
                
            }

            XElement people = new XElement("People");
            people.Add(person);
            xdoc.Add(people);
            xdoc.Save("people.xml");

            Console.WriteLine("Data saved");

        }

    }
}
