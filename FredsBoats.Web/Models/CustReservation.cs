using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("cust_reservations")]
    public class CustReservation
    {
        [Key]
        [Column("res_cust_id")]
        public int ResCustId { get; set; }

        [Column("fkcustomerid")]
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer? Customer { get; set; }

        [Column("fkbookingid")]
        public int BookingId { get; set; }

        [ForeignKey("BookingId")]
        public Reservation? Reservation { get; set; }
    }
}