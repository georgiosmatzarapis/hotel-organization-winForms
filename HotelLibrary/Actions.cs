using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Configuration;


namespace HotelLibrary
{
    /// <summary>This class implements all the actions that are available in the application.</summary>
    public class Actions : IActions
    {
        private static List<Hotel> _hotelObjList = new List<Hotel>();
        private static List<int> _totalHotelIds = new List<int>();
        private static List<Reservation> _totalReservationsObjList = new List<Reservation>();
        private static List<int> _updatedIds = new List<int>();

        private static readonly string _relativeCsvPath = @ConfigurationManager.AppSettings["csvPath"];
        private static readonly string _currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string _csvFile = Path.Combine(_currentDirectory, _relativeCsvPath);
        private static readonly string _hotelCsvPath = Path.GetFullPath(_csvFile);

        private static string[] _csvLinesNoDuplicates;

        #region Getters
        public List<Hotel> GetHotelData()
        {
            return _hotelObjList;
        }

        public List<int> GetUpdatedIds()
        {
            return _updatedIds;
        }
        #endregion

        /// <summary>Load rows from .csv file to memory.</summary>
        /// <return type="string">Helpful message for the user.</return>
        public string LoadHotelData()
        {
            int hotelId;
            string hotelName;
            int stars;
            int rooms;
            string surname;
            string checkinDate;
            int durationDays;

            if (File.Exists(_hotelCsvPath))
            {
                _csvLinesNoDuplicates = File.ReadAllLines(_hotelCsvPath).Distinct().ToArray();
            }
            else
            {
                return "File (.csv) not found.";
            }

            // Check if .csv is empty.
            if (_csvLinesNoDuplicates.Length != 0)
            {

                foreach (string line in _csvLinesNoDuplicates)
                {
                    string[] columns = line.Split(';');
                    int columnsLength = columns.Length - 1;

                    try
                    {
                        // Hotel case.
                        if (columnsLength >= 4)
                        {
                            // Hotel info.
                            hotelId = Convert.ToInt32(columns[0]);
                            hotelName = columns[1];
                            stars = Convert.ToInt32(columns[2]);
                            rooms = Convert.ToInt32(columns[3]);

                            // Reservation case.
                            if (columnsLength >= 7)
                            {
                                List<Reservation> ReservationObjList = new List<Reservation>();
                                var reservationsCount = Math.Truncate((double)(columns.Length - 4) / 3);
                                int i = 0, incr = 0;

                                while (i < reservationsCount)
                                {
                                    i++;
                                    string[] reservation = columns.Skip(4 + incr).Take(3).ToArray();
                                    incr += 3;

                                    // Validate fields for each reservation. If are wrong, ignore reservation.
                                    if (string.IsNullOrEmpty(reservation[0]) || string.IsNullOrEmpty(reservation[1]) ||  !int.TryParse(reservation[2], out _))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        surname = reservation[0];
                                        checkinDate = reservation[1];
                                        durationDays = Convert.ToInt32(reservation[2]);

                                        // Reservation info.
                                        Reservation newReservation = new Reservation(surname, checkinDate, durationDays);
                                        ReservationObjList.Add(newReservation);
                                        _totalReservationsObjList.Add(newReservation);
                                    }
                                }

                                _hotelObjList.Add(new Hotel(
                                    hotelId,
                                    hotelName,
                                    stars,
                                    rooms,
                                    ReservationObjList));
                            }
                            // Hotels without reservations.
                            else
                            {
                                _hotelObjList.Add(new Hotel(
                                    hotelId,
                                    hotelName,
                                    stars,
                                    rooms,
                                    new List<Reservation>()));
                            }

                            _totalHotelIds.Add(hotelId);
                        }
                    }
                    catch (Exception ex)
                    {
                        //// Don't throw as exception the first description-line of .csv.
                        //if (Array.FindIndex(_csvLinesNoDuplicates, row => row.Contains(line)) != 0)
                        //{
                        //  Console.WriteLine($"Input .csv file contains invalid rows of data.\r\n" +
                        //                    $"Exception: {ex.Message}.\r\n");
                        //}
                    }
                }

                return "File successfully loaded.";
            }
            else
            {
                return "Empty .csv loaded.";
            }
        }

        /// <summary>Adds new hotel in the _hotelObjList.</summary>
        /// <return type="string">Helpful message for the user.</return>
        /// <param name="name">Hotel name.</param>        
        /// <param name="stars">Hotel stars.</param>
        /// <param name="rooms">Hotel rooms.</param>
        public string AddHotel(string name, int stars, int rooms)
        {
            int newHotelId;

            if (_totalHotelIds.Any())
            {
                newHotelId = _totalHotelIds.Max() + 1;
            }
            else
            {
                newHotelId = 0;
            }

            _hotelObjList.Add(new Hotel(newHotelId, name, stars, rooms, new List<Reservation>()));
            _updatedIds.Add(newHotelId);
            _totalHotelIds.Add(newHotelId);

            return "Hotel added!";
        }

        /// <summary>Adds new reservation in the _hotelObjList.</summary>
        /// <return type="string">Helpful message for the user.</return>
        /// <param name="hotelId">Hotel id.</param>        
        /// <param name="surname">Reservation name.</param>
        /// <param name="checkinDate">Reservation check-in date.</param>
        /// <param name="durationDays">Reservation duration days.</param>
        public string AddReservation(int hotelId, string surname, string checkinDate, int durationDays)
        {
            // Check if hotelId exists.
            if (_totalHotelIds.Contains(hotelId))
            {
                Reservation newReservation = new Reservation(surname, checkinDate, durationDays);
                Hotel hotelToUpdate = _hotelObjList.First(x => x.Id == hotelId);
                hotelToUpdate.Reservations.Add(newReservation);

                if (!_updatedIds.Contains(hotelId))
                    _updatedIds.Add(hotelId);

                _totalReservationsObjList.Add(newReservation);

                return "Reservation added!";
            }
            else
            {
                return $"Hotel id '{hotelId}' does not exist.";
            }
        }

        /// <summary>Searchs for hotel information.</summary>
        /// <return type="string">Hotel information.</return>
        /// <param name="hotelId">Hotel id.</param>
        public string SearchHotel(int hotelId)
        {
            // Check if hotelId exists.
            if (_totalHotelIds.Contains(hotelId))
            {
                Hotel hotel = _hotelObjList.First(x => x.Id == hotelId);
                return $"Id: {hotel.Id}\r\n" +
                       $"Name: {hotel.Name}\r\n" +
                       $"Stars: {hotel.Stars}\r\n" +
                       $"Rooms: {hotel.Rooms}";
            }
            else
            {
                return $"Hotel id '{hotelId}' does not exist.";
            }
        }

        /// <summary>Searchs for reservation information.</summary>
        /// <return type="string">Reservation information.</return>
        /// <param name="surname">Reservation name.</param>
        public string SearchReservation(string surname)
        {
            List<Reservation> matchedReservations = new List<Reservation>();
            matchedReservations = _totalReservationsObjList.FindAll(x => x.Surname == surname);

            if (matchedReservations.Any())
            {
                string message = "";
                foreach(Reservation r in matchedReservations)
                {
                    message += r.Surname + ", " + r.CheckinDate + ", " + r.DurationDays + "\r\n";
                }
                return message;
            }
            else
            {
                return $"Surname '{surname}' does not exist.";
            }
        }

        /// <summary>Saves the updated 'Hotel' instances back to .csv.</summary>
        /// <return type="string">Helpful message for the user.</return>
        /// <todo>Write to file only the specific updated lines. Use '_updatedIds' field.</todo>
        public string SaveHotelData()
        {
            if (!_updatedIds.Any())
            {
                return "No change has occured.";
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(_hotelCsvPath, false))
                {
                    foreach(Hotel hotel in _hotelObjList)
                    {
                        string hotelToWrite = "";
                        hotelToWrite += hotel.Id + ";" + hotel.Name + ";" + hotel.Stars + ";" + hotel.Rooms + ";";

                        if (hotel.Reservations.Any())
                        {
                            foreach(Reservation reservation in hotel.Reservations)
                            {
                                hotelToWrite += reservation.Surname + ";" + reservation.CheckinDate + ";" + reservation.DurationDays + ";";
                            }
                        }

                        hotelToWrite += "\r\n";
                        writer.Write(hotelToWrite);
                    }
                }

                _updatedIds.Clear();
                return "Information saved.";
            }

        }
    }
}
