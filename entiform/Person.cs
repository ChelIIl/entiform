using System;
using System.Collections.Generic;

namespace entiform
{
    public partial class Person
    {
        public Person()
        {
            Contract = new HashSet<Contract>();
        }

        public int IdPerson { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Pname { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
    }
}
