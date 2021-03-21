using System;
using System.Collections.Generic;

namespace CompanyApplication.Models
{
    public partial class Candidates
    {
        public Candidates()
        {
            //da proverim dali da raboti s logika za kandidati  ili obektat tuk da e direktora
            Candidate = new HashSet<Candidates>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        //proverka dali da pravim prqka vruzka s nego
        public int DirectorId { get; set; }
        public DateTimeOffset Created { get; set; }

        public virtual ICollection<Candidates> Candidate { get; set; }
    }
}