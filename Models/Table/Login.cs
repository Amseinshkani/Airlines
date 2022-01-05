using System;
using System.ComponentModel.DataAnnotations;

namespace AirLine
{
    public class VM_Login
    {
        [Key]
        public int ID_User { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string National_Code { get; set; }
        public string Phone_Number { get; set; }
        public string Password { get; set; }


    }
}
