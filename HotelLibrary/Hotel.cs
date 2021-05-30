using System.Collections.Generic;

namespace HotelLibrary
{
    /// <summary>This struct initializes 'Hotel' instances.</summary>
    public struct Hotel
    {
        public int Id { get; }
        public string Name { get; }
        public int Stars { get; }
        public int Rooms { get; }
        public List<Reservation> Reservations { get; }

        /// <summary>'Hotel' struct constructor.</summary>
        /// <param name="id">Hotel's id.</param>
        /// <param name="name">Hotel's name.</param>
        /// <param name="stars">Hotel's stars.</param>
        /// <param name="rooms">Hotel's rooms.</param>
        /// <param name="reservation">Hotel's reservations.</param>
        public Hotel(int id, string name, int stars, int rooms, List<Reservation> reservation)
        {
            this.Id = id;
            this.Name = name;
            this.Stars = stars;
            this.Rooms = rooms;
            this.Reservations = reservation;
        }
    }
}
