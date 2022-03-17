using System;
using System.Collections.Generic;

#nullable disable

namespace Ahaji.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int CustomerId { get; set; }
        public string CEmail { get; set; }
        public int PhoneNum { get; set; }
        public string Name { get; set; }
        public int GroupSize { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
