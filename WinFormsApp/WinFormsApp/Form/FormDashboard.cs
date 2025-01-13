using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WinFormsApp;


namespace HotelManagementSystemProject
{
    public partial class FormDashboard : Form
    {
        public string firstName;
        public string lastName;
        public string adress;
        public string telefone;
        public string PersonalID;
        public string Roll;
        public string PostalCode;
        public string City;

        // To keep track of the currently active button
        private Button currentButton = null!;
        private readonly List<string> excludedButtons = new List<string> { "buttonUser", "buttonLogOut" };

        public FormDashboard()
        {
            InitializeComponent();
        }
        //Fields

        private void ButtonLogOut_LinkedClick(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == result)
            {
                timer.Stop();
                this.Close();
            }
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) // Check if the button is not null
            {
                DisableButton(); // Reset all buttons to default state

                // Activate the new button
                currentButton = (Button)btnSender;
                currentButton.BackColor = Color.SandyBrown; // Change to ActiveCaption color
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        private void DisableButton()
        {
            // Function to recursively reset all buttons
            ResetButtonStyle(this.Controls);
        }

        private void ResetButtonStyle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button btn)
                {
                    if (excludedButtons.Contains(btn.Name))
                        continue; // Skip resetting excluded buttons

                    // Reset button to default styles
                    btn.BackColor = SystemColors.AppWorkspace;
                    btn.ForeColor = SystemColors.ButtonHighlight;
                    btn.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
                }
                else if (control.HasChildren)
                {
                    ResetButtonStyle(control.Controls); // Recursively handle child controls
                }
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainerDashboardForm.Controls.Clear();
            panelContainerDashboardForm.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitelOfMenu.Text = buttonDashboard.Text;
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitelOfMenu.Text = buttonClient.Text;
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitelOfMenu.Text = buttonRoom.Text;
        }

        private void buttonReservation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitelOfMenu.Text = buttonReservation.Text;
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitelOfMenu.Text = buttonSetting.Text;
            UserControlSetting usercontrolsetting = new UserControlSetting();
            addUserControl(usercontrolsetting);
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitelOfMenu.Text = buttonContact.Text;
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            labelTitelOfMenu.Text = buttonInformation.Text;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTimer.Text = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
        }

        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            timer.Start();
            buttonUser.Text = "User: " + firstName;
        }

        private void labelTitelOfMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
