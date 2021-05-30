using System;
using System.Windows.Forms;
using System.Configuration;
using HotelLibrary;

namespace HotelOrganizationApp
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        Actions action = new Actions();

        // App.config data.
        private static readonly int _maxHotelId = Convert.ToInt32(ConfigurationManager.AppSettings["maxHotelId"]);
        private static readonly int _maxDurationDays = Convert.ToInt32(ConfigurationManager.AppSettings["maxDurationDays"]);
        private static readonly int _maxStars = Convert.ToInt32(ConfigurationManager.AppSettings["maxStars"]);
        private static readonly int _maxRooms = Convert.ToInt32(ConfigurationManager.AppSettings["maxRooms"]);

        // Control flow fields.
        private static bool _loadState = false;
        private static bool _saveState = false;
        private static bool _addState = false;

        #region Forms
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
            else if (Convert.ToInt32(hotelStarsAdd) < 1 || Convert.ToInt32(hotelStarsAdd) > _maxStars)
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
            else if (Convert.ToInt32(hotelRoomsAdd) < 1 || Convert.ToInt32(hotelRoomsAdd) > _maxRooms)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Rooms' field.\n\r";
            }
            #endregion

            if (isValid)
            {
                int hotelStarsAddInt = Convert.ToInt32(hotelStarsAdd);
                int hotelRoomsAddAddInt = Convert.ToInt32(hotelRoomsAdd);

                if (_loadState)
                {
                    MessageBox.Show(action.AddHotel(hotelNameAdd, hotelStarsAddInt, hotelRoomsAddAddInt));
                    _addState = true;
                    _saveState = false;
                }
                else
                {
                    MessageBox.Show("No file has been loaded.");
                }

                tbHotelNameAdd.Clear();
                tbHotelStarsAdd.Clear();
                tbHotelRoomsAdd.Clear();
            }
            else
            {
                MessageBox.Show(errorMessage);
            }
        }

        private void btnAddReservation_Click(object sender, EventArgs e)
        {
            string hotelIdReservation = tbHotelIdReservation.Text;
            string surnameReservation = tbSurnameReservation.Text;
            string checkinReservation = dtCheckinReservation.Text;
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
            else if (Convert.ToInt32(hotelIdReservation) < 0 || Convert.ToInt32(hotelIdReservation) > _maxHotelId)
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
            else if (Convert.ToInt32(durationDaysReservation) < 1 || Convert.ToInt32(durationDaysReservation) > _maxDurationDays)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Duration (days)' field.\n\r";
            }
            #endregion

            if (isValid)
            {
                int hotelIdReservationInt = Convert.ToInt32(hotelIdReservation);
                int durationDaysReservationInt = Convert.ToInt32(durationDaysReservation);

                if (_loadState)
                {
                    string response = action.AddReservation(hotelIdReservationInt, surnameReservation, checkinReservation, durationDaysReservationInt);

                    if (response != $"Hotel id '{hotelIdReservationInt}' does not exist.")
                    {
                        _addState = true;
                        _saveState = false;
                    }
                    MessageBox.Show(response);
                }
                else
                {
                    MessageBox.Show("No file has been loaded.");
                }

                tbHotelIdReservation.Clear();
                tbSurnameReservation.Clear();
                dtCheckinReservation.ResetText();
                tbDurationDaysReservation.Clear();

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
            else if (Convert.ToInt32(hotelIdSearch) < 0 || Convert.ToInt32(hotelIdSearch) > _maxHotelId)
            {
                isValid = false;
                errorMessage += "Invalid number for 'Hotel id' field.\n\r";
            }
            #endregion

            if (isValid)
            {
                if (_loadState)
                {
                    MessageBox.Show(action.SearchHotel(Convert.ToInt32(hotelIdSearch)));
                }
                else
                {
                    MessageBox.Show("No file has been loaded.");
                }
                tbHotelIdSearch.Clear();
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
                if (_loadState)
                {
                    MessageBox.Show(action.SearchReservation(surnameSearch));
                }
                else
                {
                    MessageBox.Show("No file has been loaded.");
                }
                tbSurnameSearch.Clear();
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
            if (!_loadState)
            {
                string response = action.LoadHotelData();

                if (response == "File (.csv) not found.")
                {
                    btnAddHotel.Enabled = false;
                    btnAddReservation.Enabled = false;
                    btnSearchHotel.Enabled = false;
                    btnSearchReservation.Enabled = false;
                    btnSave.Enabled = false;

                    _loadState = false;
                }
                else
                {
                    btnAddHotel.Enabled = true;
                    btnAddReservation.Enabled = true;
                    btnSearchHotel.Enabled = true;
                    btnSearchReservation.Enabled = true;
                    btnSave.Enabled = true;

                    _loadState = true;
                }
                MessageBox.Show(response);
            }
            else
            {
                MessageBox.Show("File is already loaded.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_loadState)
            {
                string response = action.SaveHotelData();
                _saveState = true;
                _addState = false;
                MessageBox.Show(response);
            }
            else
            {
                MessageBox.Show("No file has been loaded.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (!_saveState && _addState)
            {
                MessageBox.Show(action.SaveHotelData());
            }
            
            MessageBox.Show("Bye!");
            this.Close();
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
