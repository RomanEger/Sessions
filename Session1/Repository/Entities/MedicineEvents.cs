using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
    public class MedicineEvents : TableDbBase
    {
        public int ClientId { get; set; }
        public int DoctorId { get; set; }
        public int EventTypeId { get; set; }
        public string Name { get; set; }
        public string Result { get; set; }
        public string Recomendations { get; set; }

        public Client? Client { get; set; }
        public Doctor? Doctor { get; set; } 
        public EventType? EventType { get; set; }
    }
}
