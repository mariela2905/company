using System;
using System.Collections.Generic;

namespace CompanyApplication.Models
{
    public partial class Employees
    {
        public Employees()
        {
            //promenihme pacienta na employee, obiknovenata promenliva e v edinstweno chislo, obecta e za vsichki
            Employee = new HashSet<Employees>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

        public DateTimeOffset Created { get; set; }

        public virtual ICollection<Employees> Employee { get; set; }
    }
}