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
            DataTable dataTables = new DataTable();
            dataTables.Columns.Add("firstName");
            dataTables.Columns.Add("lastName");
            dataTables.Columns.Add("address");
            dataTables.Columns.Add("city");
            dataTables.Columns.Add("state");
            dataTables.Columns.Add("zipCode");
            dataTables.Columns.Add("phoneNumber");
            dataTables.Columns.Add("email");

            dataTables.Rows.Add("Ankit", "Ghosh", "Dhnabad", "Jharkhand", "828171", "8219891889", "ank@gmail.com");
            dataTables.Rows.Add("Nishanth", "Raj", "Bangalore", "Karnataka", "560099", "8726345101", "nish@gmail.com");
            dataTables.Rows.Add("Raj", "Bakshi", "Kolkata", "West Bengal", "738377", "867211449", "raj@gmail.com");
            dataTables.Rows.Add("Ritesh", "Kumar", "Patna", "Bihar", "989002", "9000986543", "rit@gmail.com");

            DisplayContacts(dataTables);
        }

        public void DisplayContacts(DataTable dataTables)
        {
            var Names = from products in dataTables.AsEnumerable() select products.Field<string>("firstName");
            Console.WriteLine("Name : ");
            foreach (string n in Names)
            {
                Console.WriteLine(n);
            }

        }
    }
}
