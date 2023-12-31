﻿
namespace HotelOrganizationApp
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.tbHotelNameAdd = new System.Windows.Forms.TextBox();
            this.tbHotelStarsAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHotelRoomsAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddHotel = new System.Windows.Forms.Button();
            this.btnAddReservation = new System.Windows.Forms.Button();
            this.tbDurationDaysReservation = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSurnameReservation = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbHotelIdReservation = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbHotelIdSearch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnSearchHotel = new System.Windows.Forms.Button();
            this.btnSearchReservation = new System.Windows.Forms.Button();
            this.tbSurnameSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dtCheckinReservation = new System.Windows.Forms.DateTimePicker();
            this.btnHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("NSimSun", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(270, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Organization System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(820, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(820, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Stars";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(492, 668);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(209, 51);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Hotels and Reservations";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Snow;
            this.btnExit.Location = new System.Drawing.Point(891, 668);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(209, 51);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.LightCoral;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLoad.Location = new System.Drawing.Point(76, 668);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(209, 51);
            this.btnLoad.TabIndex = 10;
            this.btnLoad.Text = "Load Hotels and Reservations";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // tbHotelNameAdd
            // 
            this.tbHotelNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHotelNameAdd.ForeColor = System.Drawing.Color.Black;
            this.tbHotelNameAdd.Location = new System.Drawing.Point(913, 196);
            this.tbHotelNameAdd.Name = "tbHotelNameAdd";
            this.tbHotelNameAdd.Size = new System.Drawing.Size(187, 26);
            this.tbHotelNameAdd.TabIndex = 11;
            // 
            // tbHotelStarsAdd
            // 
            this.tbHotelStarsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHotelStarsAdd.Location = new System.Drawing.Point(913, 250);
            this.tbHotelStarsAdd.Name = "tbHotelStarsAdd";
            this.tbHotelStarsAdd.Size = new System.Drawing.Size(187, 26);
            this.tbHotelStarsAdd.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(820, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Rooms";
            // 
            // tbHotelRoomsAdd
            // 
            this.tbHotelRoomsAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHotelRoomsAdd.Location = new System.Drawing.Point(913, 302);
            this.tbHotelRoomsAdd.Name = "tbHotelRoomsAdd";
            this.tbHotelRoomsAdd.Size = new System.Drawing.Size(187, 26);
            this.tbHotelRoomsAdd.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(191, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Add Reservations";
            // 
            // btnAddHotel
            // 
            this.btnAddHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHotel.Location = new System.Drawing.Point(913, 377);
            this.btnAddHotel.Name = "btnAddHotel";
            this.btnAddHotel.Size = new System.Drawing.Size(143, 36);
            this.btnAddHotel.TabIndex = 16;
            this.btnAddHotel.Text = "Add";
            this.btnAddHotel.UseVisualStyleBackColor = false;
            this.btnAddHotel.Click += new System.EventHandler(this.btnAddHotel_Click);
            // 
            // btnAddReservation
            // 
            this.btnAddReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReservation.Location = new System.Drawing.Point(196, 422);
            this.btnAddReservation.Name = "btnAddReservation";
            this.btnAddReservation.Size = new System.Drawing.Size(143, 36);
            this.btnAddReservation.TabIndex = 17;
            this.btnAddReservation.Text = "Add";
            this.btnAddReservation.UseVisualStyleBackColor = false;
            this.btnAddReservation.Click += new System.EventHandler(this.btnAddReservation_Click);
            // 
            // tbDurationDaysReservation
            // 
            this.tbDurationDaysReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDurationDaysReservation.Location = new System.Drawing.Point(196, 352);
            this.tbDurationDaysReservation.Name = "tbDurationDaysReservation";
            this.tbDurationDaysReservation.Size = new System.Drawing.Size(187, 26);
            this.tbDurationDaysReservation.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(36, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 22;
            this.label7.Text = "Duration (days)";
            // 
            // tbSurnameReservation
            // 
            this.tbSurnameReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurnameReservation.ForeColor = System.Drawing.Color.Black;
            this.tbSurnameReservation.Location = new System.Drawing.Point(196, 250);
            this.tbSurnameReservation.Name = "tbSurnameReservation";
            this.tbSurnameReservation.Size = new System.Drawing.Size(187, 26);
            this.tbSurnameReservation.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(36, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Check-in date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(36, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Surname";
            // 
            // tbHotelIdReservation
            // 
            this.tbHotelIdReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHotelIdReservation.ForeColor = System.Drawing.Color.Black;
            this.tbHotelIdReservation.Location = new System.Drawing.Point(196, 198);
            this.tbHotelIdReservation.Name = "tbHotelIdReservation";
            this.tbHotelIdReservation.Size = new System.Drawing.Size(187, 26);
            this.tbHotelIdReservation.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(36, 200);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 24;
            this.label10.Text = "Hotel id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Salmon;
            this.label4.Location = new System.Drawing.Point(908, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add Hotel";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Salmon;
            this.label11.Location = new System.Drawing.Point(548, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 26);
            this.label11.TabIndex = 26;
            this.label11.Text = "Hotel";
            // 
            // tbHotelIdSearch
            // 
            this.tbHotelIdSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHotelIdSearch.ForeColor = System.Drawing.Color.Black;
            this.tbHotelIdSearch.Location = new System.Drawing.Point(553, 460);
            this.tbHotelIdSearch.Name = "tbHotelIdSearch";
            this.tbHotelIdSearch.Size = new System.Drawing.Size(183, 26);
            this.tbHotelIdSearch.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(451, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 24);
            this.label12.TabIndex = 27;
            this.label12.Text = "Hotel id";
            // 
            // btnSearchHotel
            // 
            this.btnSearchHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearchHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchHotel.Location = new System.Drawing.Point(553, 525);
            this.btnSearchHotel.Name = "btnSearchHotel";
            this.btnSearchHotel.Size = new System.Drawing.Size(143, 36);
            this.btnSearchHotel.TabIndex = 29;
            this.btnSearchHotel.Text = "Search";
            this.btnSearchHotel.UseVisualStyleBackColor = false;
            this.btnSearchHotel.Click += new System.EventHandler(this.btnSearchHotel_Click);
            // 
            // btnSearchReservation
            // 
            this.btnSearchReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSearchReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchReservation.Location = new System.Drawing.Point(553, 263);
            this.btnSearchReservation.Name = "btnSearchReservation";
            this.btnSearchReservation.Size = new System.Drawing.Size(143, 36);
            this.btnSearchReservation.TabIndex = 33;
            this.btnSearchReservation.Text = "Search";
            this.btnSearchReservation.UseVisualStyleBackColor = false;
            this.btnSearchReservation.Click += new System.EventHandler(this.btnSearchReservation_Click);
            // 
            // tbSurnameSearch
            // 
            this.tbSurnameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSurnameSearch.ForeColor = System.Drawing.Color.Black;
            this.tbSurnameSearch.Location = new System.Drawing.Point(553, 196);
            this.tbSurnameSearch.Name = "tbSurnameSearch";
            this.tbSurnameSearch.Size = new System.Drawing.Size(183, 26);
            this.tbSurnameSearch.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(451, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(87, 24);
            this.label13.TabIndex = 31;
            this.label13.Text = "Surname";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Salmon;
            this.label14.Location = new System.Drawing.Point(548, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 26);
            this.label14.TabIndex = 30;
            this.label14.Text = "Reservation";
            // 
            // dtCheckinReservation
            // 
            this.dtCheckinReservation.Checked = false;
            this.dtCheckinReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtCheckinReservation.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCheckinReservation.Location = new System.Drawing.Point(196, 298);
            this.dtCheckinReservation.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dtCheckinReservation.MinDate = new System.DateTime(2021, 5, 13, 0, 0, 0, 0);
            this.dtCheckinReservation.Name = "dtCheckinReservation";
            this.dtCheckinReservation.Size = new System.Drawing.Size(187, 26);
            this.dtCheckinReservation.TabIndex = 34;
            this.dtCheckinReservation.Value = new System.DateTime(2021, 5, 13, 0, 0, 0, 0);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnHelp.Location = new System.Drawing.Point(1022, 12);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(105, 29);
            this.btnHelp.TabIndex = 35;
            this.btnHelp.Text = "Help ?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1128, 746);
            this.ControlBox = false;
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.dtCheckinReservation);
            this.Controls.Add(this.btnSearchReservation);
            this.Controls.Add(this.tbSurnameSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnSearchHotel);
            this.Controls.Add(this.tbHotelIdSearch);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbHotelIdReservation);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDurationDaysReservation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbSurnameReservation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnAddReservation);
            this.Controls.Add(this.btnAddHotel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHotelRoomsAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbHotelStarsAdd);
            this.Controls.Add(this.tbHotelNameAdd);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindowForm";
            this.Text = "Hotel Organization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox tbHotelNameAdd;
        private System.Windows.Forms.TextBox tbHotelStarsAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHotelRoomsAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddHotel;
        private System.Windows.Forms.Button btnAddReservation;
        private System.Windows.Forms.TextBox tbDurationDaysReservation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSurnameReservation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbHotelIdReservation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbHotelIdSearch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnSearchHotel;
        private System.Windows.Forms.Button btnSearchReservation;
        private System.Windows.Forms.TextBox tbSurnameSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtCheckinReservation;
        private System.Windows.Forms.Button btnHelp;
    }
}

