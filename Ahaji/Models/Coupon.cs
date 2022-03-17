using System;
using System.Collections.Generic;

#nullable disable

namespace Ahaji.Models
{
    public partial class Coupon
    {
        public int CouponId { get; set; }
        public string CouponName { get; set; }
        public DateTime? Duration { get; set; }
    }
}
