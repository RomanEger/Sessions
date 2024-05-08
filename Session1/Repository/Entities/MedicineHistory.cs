using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class MedicineHistory : TableDbBase
    {
        public int ClientId { get; set; }
        public int DiagnozeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Description { get; set; }

        public Client? Client { get; set; }
        public Diagnoze? Diagnoze { get; set; } 
    }
}
