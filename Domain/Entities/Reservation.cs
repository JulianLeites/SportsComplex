using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    internal class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationStartDateTime { get; set; }
        public DateTime ReservationEndDateTime { get; set; }
        public decimal TotalPrice { get; set; }
        public enum ReservationStatus
        {
            Confirmed,
            Cancelled
        }
    }
}
