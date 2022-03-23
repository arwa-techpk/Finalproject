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
        public int CouponId { get; set; }
        public Coupon Coupon { get; set; }
        public DateTime ReservationDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }

    public class ReservaionHistory 
    {
    
    }
}
