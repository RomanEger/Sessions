using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    [Index("Passport", IsUnique = true)]
    public class Client : TableDbBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Patronymic { get; set; }

        [MaxLength(10)]
        public string Passport { get; set; }
        
        public int GenderId { get; set; }
        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int MedicineCardId { get; set;}
        public string PolisId { get; set; }

        public Gender? Gender { get; set; }
        public MedicineCard? MedicineCard { get; set;}
        public Polis? Polis { get; set; }
    }
}
