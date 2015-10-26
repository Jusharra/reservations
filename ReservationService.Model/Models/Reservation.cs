using System;

namespace ReservationService.Model.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Notes { get; set; }

        public User User { get; set; }
        public Item Item { get; set; }
    }
}