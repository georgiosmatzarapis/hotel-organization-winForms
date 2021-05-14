using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace HotelOrganizationApp
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        // App.config data
        private static readonly int maxHotelId = Convert.ToInt32(ConfigurationManager.AppSettings["maxHotelId"]);
        private static readonly int maxDurationDays = Convert.ToInt32(ConfigurationManager.AppSettings["maxDurationDays"]);
        private static readonly int maxStars = Convert.ToInt32(ConfigurationManager.AppSettings["maxStars"]);
        private static readonly int maxRooms = Convert.ToInt32(ConfigurationManager.AppSettings["maxRooms"]);

        #region Forms
        private void btnAddReservation_Click(object sender, EventArgs e)
        {

            string hotelIdReservation = tbHotelIdReservation.Text;
            string surnameReservation = tbSurnameReservation.Text;
            var checkinReservation = dtCheckinReservation.Value;
            string durationDaysReservation = tbDurationDaysReservation.Text;

            bool isValid = true;
            string errorMessage = "";

            #region Validation
            if (string.IsNullOrWhiteSpace(hotelIdReservation))
            {
                isValid = false;
                errorMessage += "'Hotel id' field is empty.\n\r";
            }
            else if (!int.TryParse(hotelIdReservation, out _))
            {
                isValid = false;
                errorMessage += "Please provider an integer number for 'Hotel id' field.\n\r";
            }
            else if (Convert.ToInt32(hotelIdReservation) < 0 || Convert.ToInt32(hotelIdReservation) > maxHotelId)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Hotel id' field.\n\r";
            }

            if (string.IsNullOrWhiteSpace(surnameReservation))
            {
                isValid = false;
                errorMessage += "'Surname' field is emtpy.\n\r";
            }

            if (string.IsNullOrWhiteSpace(durationDaysReservation))
            {
                isValid = false;
                errorMessage += "'Duration (days)' field is empty.\n\r";
            }
            else if (!int.TryParse(durationDaysReservation, out _))
            {
                isValid = false;
                errorMessage += "Please provider an integer number for 'Duration (days)' field.\n\r";
            }
            else if (Convert.ToInt32(durationDaysReservation) < 1 || Convert.ToInt32(durationDaysReservation) > maxDurationDays)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Duration (days)' field.\n\r";
            }
            #endregion

            if (isValid)
            {
                tbHotelIdReservation.Clear();
                tbSurnameReservation.Clear();
                dtCheckinReservation.ResetText();
                tbDurationDaysReservation.Clear();

                MessageBox.Show($"Resrvation for hotel id '{hotelIdReservation}' successfully added.\n\n\r" +
                                "Reservation information:\n\r" +
                                $"Name: {surnameReservation}\n\r" +
                                $"Check-in date: {checkinReservation}\n\r" +
                                $"Duration days: {durationDaysReservation}");
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnSearchReservation_Click(object sender, EventArgs e)
        {
            string surnameSearch = tbSurnameSearch.Text;

            bool isValid = true;
            string errorMessage = "";

            #region Validation
            if (string.IsNullOrWhiteSpace(surnameSearch))
            {
                isValid = false;
                errorMessage += "'Surname' field is empty.\n\r";
            }
            #endregion

            if (isValid)
            {
                tbSurnameSearch.Clear();

                MessageBox.Show($"Search results for Surname '{surnameSearch}':\n\r ; ; ;");
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnSearchHotel_Click(object sender, EventArgs e)
        {
            string hotelIdSearch = tbHotelIdSearch.Text;

            bool isValid = true;
            string errorMessage = "";

            #region Validation
            if (string.IsNullOrWhiteSpace(hotelIdSearch))
            {
                isValid = false;
                errorMessage += "'Hotel id' field is empty.\n\r";
            }
            else if (!int.TryParse(hotelIdSearch, out _))
            {
                isValid = false;
                errorMessage += "Please provider an integer number for 'Hotel id' field.\n\r";
            }
            else if (Convert.ToInt32(hotelIdSearch) < 0 || Convert.ToInt32(hotelIdSearch) > maxHotelId)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Hotel id' field.\n\r";
            }
            #endregion

            if (isValid)
            {
                tbHotelIdSearch.Clear();

                MessageBox.Show($"Search results for hotel id '{Convert.ToInt32(hotelIdSearch)}':\n\r ; ; ;");
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            string hotelNameAdd = tbHotelNameAdd.Text;
            string hotelStarsAdd = tbHotelStarsAdd.Text;
            string hotelRoomsAdd = tbHotelRoomsAdd.Text;

            bool isValid = true;
            string errorMessage = "";

            #region Validation
            if (string.IsNullOrWhiteSpace(hotelNameAdd))
            {
                isValid = false;
                errorMessage += "'Name' field is emtpy.\n\r";
            }

            if (string.IsNullOrWhiteSpace(hotelStarsAdd))
            {
                isValid = false;
                errorMessage += "'Stars' field is empty.\n\r";
            }
            else if (!int.TryParse(hotelStarsAdd, out _))
            {
                isValid = false;
                errorMessage += "Please provider an integer number for 'Stars' field.\n\r";
            } 
            else if (Convert.ToInt32(hotelStarsAdd) < 1 || Convert.ToInt32(hotelStarsAdd) > maxStars)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Stars' field.\n\r";
            }

            if (string.IsNullOrWhiteSpace(hotelRoomsAdd))
            {
                isValid = false;
                errorMessage += "'Rooms' field is empty.\n\r";
            }
            else if (!int.TryParse(hotelRoomsAdd, out _))
            {
                isValid = false;
                errorMessage += "Please provider an integer number for 'Rooms' field.\n\r";
            }
            else if (Convert.ToInt32(hotelRoomsAdd) < 1 || Convert.ToInt32(hotelRoomsAdd) > maxRooms)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Rooms' field.\n\r";
            }
            #endregion

            if (isValid)
            {
                tbHotelNameAdd.Clear();
                tbHotelStarsAdd.Clear();
                tbHotelRoomsAdd.Clear();

                MessageBox.Show($"Hotel '{hotelNameAdd}' successfully added.\n\r" +
                                $"Stars: {Convert.ToInt32(hotelStarsAdd)}\n\r" +
                                $"Rooms: {Convert.ToInt32(hotelRoomsAdd)}");
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }
        #endregion

        #region BottomButtons
        private void btnLoad_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hotels' data successfully loaded!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hotels' data successfully saved!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bye!");
        }
        #endregion

        // Help Button
        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm helpForm = new HelpForm();
            FormCollection fc = Application.OpenForms;

            bool isOpen = false;

            foreach (Form form in fc)
            {
                if (form.Name == "HelpForm") isOpen = true;
            }

            if (isOpen)
            {
                fc["HelpForm"].BringToFront();
            }
            else
            {
                helpForm.Show();
            }
        }
    }
}
