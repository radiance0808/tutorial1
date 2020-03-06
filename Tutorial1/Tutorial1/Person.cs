using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorial1
{
    public class Person
    {
        private string firstName;
           
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName { get; set; }
    }
}
