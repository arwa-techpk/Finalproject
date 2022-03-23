using System;

namespace Ahaji.Models
{
    public partial class Coupon
    {
        public int CouponId { get; set; }
        public string CouponName { get; set; }
        public double? MoneyDiscount { get; set; }
        public double? DiscountPercentage { get; set; }
        public DateTime? Duration { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
