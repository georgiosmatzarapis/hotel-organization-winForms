namespace HotelLibrary
{
    public interface IActions
    {
        string LoadHotelData();
        string AddHotel(string name, int stars, int rooms);
        string AddReservation(int hotelId, string surname, string checkinDate, int durationDays);
        string SearchHotel(int hotelId);
        string SearchReservation(string surname);
        string SaveHotelData();
    }
}