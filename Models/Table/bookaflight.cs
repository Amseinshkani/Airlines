using System;
using System.ComponentModel.DataAnnotations;

namespace AirLine
{
    public class VM_BookFlight
    {
        [Key]
        public int ID { get; set; }
        public int ID_Flight_Name { get; set; }
        public int ID_User { get; set; }
    }
}