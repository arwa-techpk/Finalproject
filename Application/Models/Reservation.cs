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
        public DateTime ReservationDateFrom { get; set; }
        public DateTime ReservationDateTo { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
        public ReservationType ReservationType { get; set; }
    }

    public class ReservaionHistory 
    {
    
    }

    public enum ReservationType
    {
        Game,
        Visit
    }
}
