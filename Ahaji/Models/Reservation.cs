using System;
using System.Collections.Generic;

#nullable disable

namespace Ahaji.Models
{
    public partial class Reservation
    {
        public int ReservationId { get; set; }
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}
