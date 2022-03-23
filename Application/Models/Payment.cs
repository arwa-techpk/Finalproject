
namespace Ahaji.Models
{
    public partial class Payment
    {
        public int InvoiceNum { get; set; }
        public int ConfNum { get; set; }
        public double Amount { get; set; }
        public int CustomerId { get; set; }
        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Customer Customer { get; set; }
        // why we put virtual keyword | friend properties, methods | OOP over riding
    }
}
