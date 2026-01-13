using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FredsBoats.Web.Models
{
    [Table("reservation")]
    public class Reservation
    {
        [Key]
        [Column("bookingid")]
        public int BookingId { get; set; }

        [Column("start_date")]
        public DateTime StartDate { get; set; }

        [Column("end_date")]
        public DateTime EndDate { get; set; }

        // Foreign Key to Boat
        [Column("fkboatid")]
        public int BoatId { get; set; }

        [ForeignKey("BoatId")]
        public Boat? Boat { get; set; }

        // Navigation to the Join Table
        public ICollection<CustReservation> CustReservations { get; set; } = new List<CustReservation>();
    }
}