using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace HotelOrganizationApp
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        // App.config data
        private static readonly string _email_link = ConfigurationManager.AppSettings["email"];
        private static readonly string _linkedin_link = ConfigurationManager.AppSettings["linkedin"];
        private static readonly string _gitlab_link = ConfigurationManager.AppSettings["gitlab"];
        private static readonly string _facebook_link = ConfigurationManager.AppSettings["facebook"];

        private void email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(_email_link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkedin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(_linkedin_link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gitlab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(_gitlab_link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void facebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(_facebook_link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
