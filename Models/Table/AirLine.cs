using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AirLine
{
    public class VM_AirLine
    {
        public string Company_Name { get; set; }
        public string Source { get; set; }
        public string destination { get; set; }
        [Column("flight_date",TypeName ="Date")]
        public string flight_date { get; set; }
        [Column("flight_date",TypeName ="Date")]
        public string flight_time { get; set; }
        public string Capacity { get; set; }


    }
}
