namespace HotelLibrary
{
    /// <summary>This struct initializes 'Reservation' instances.</summary>
    public struct Reservation
    {
        public string Surname { get; }
        public string CheckinDate { get; }
        public int DurationDays { get; }

        /// <summary>'Reservation' struct constructor.</summary>
        /// <param name="surname">Reservation name.</param> 
        /// <param name="checkinDate">Reservation check-in date.</param>
        /// <param name="durationDays">Reservation duration days.</param>
        public Reservation(string surname, string checkinDate, int durationDays)
        {
            this.Surname = surname;
            this.CheckinDate = checkinDate;
            this.DurationDays = durationDays;
        }
    }
}
