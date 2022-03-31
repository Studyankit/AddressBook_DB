using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_Db
{
    internal class AddressBookMain
    {
        public void dbCreation()
        {
            List<Contact> contacts = new List<Contact>()
            {
                new Contact(){ firstName="Ankit",lastName="Ghosh", address="Kendua",city="Dhanbad",state="jharkhand",zipCode=829911,phoneNumber=938725431,email="ank@gmail.com"},
                new Contact(){ firstName="Nishanth",lastName="Raj", address="Hsr",city="Bangalore",state="Karnataka",zipCode=549499,phoneNumber=835245179,email="nish@gmail.com"},
                new Contact(){ firstName="milan",lastName="Chatterjee", address="putki",city="Dhanbad",state="jharkhand",zipCode=829911,phoneNumber=879000122,email="mil@gmail.com"},
                new Contact(){ firstName="Virender",lastName="yadav", address="patna",city="Patna",state="Bihar",zipCode=722399,phoneNumber=6887829290,email="vir@gmail.com"},
            };
            foreach (var list in contacts)
            {
                Console.WriteLine("Firstname:- " + list.firstName + " " + "Lastname:- " + list.lastName
                    + " " + "address:- " + list.address + " " + "city:- " + list.city + " " + "state:- " + list.state +" "+"zipcode:-"+list.zipCode+" "+"phone no-"+list.phoneNumber+" "+"email id:-"+list.email);
            }
        }

    }
}
