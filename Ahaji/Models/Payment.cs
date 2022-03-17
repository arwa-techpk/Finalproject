using System;
using System.Collections.Generic;

#nullable disable

namespace Ahaji.Models
{
    public partial class Payment
    {
        public int InvoiceNum { get; set; }
        public int ConfNum { get; set; }
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public int ReservationId { get; set; }
    }
}
