using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Desktop_Contacts_App.Classes
{
    public class Contact
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
