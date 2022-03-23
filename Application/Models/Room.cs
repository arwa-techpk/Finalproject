using System;
using System.Collections.Generic;

#nullable disable

namespace Ahaji.Models
{
    // CRUD
    public partial class Room
    {
        public Room()
        {
            Reservations = new HashSet<Reservation>();
        }

        public int RoomId { get; set; }
        public string Desciption { get; set; }
        public string Name { get; set; }
        public bool IsVacant { get; set; }
        public int RoomCapacity { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }

    
}
