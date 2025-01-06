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
        public FormDashboard()
        {
            InitializeComponent();
        }
        //Fields
        private Button currentButton = null!;
        private void ButtonLogOut_LinkedClick(object sender, EventArgs e)
        {
            Application.Exit();
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
                if (control.GetType() == typeof(Button)) // Check if the control is a Button
                {
                    Button btn = (Button)control;
                    btn.BackColor = SystemColors.AppWorkspace; // Reset to default color
                    btn.ForeColor = SystemColors.ButtonHighlight; // Reset to default text color
                    btn.Font = new System.Drawing.Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point); // Reset font
                }
                else if (control.HasChildren) // Check if the control has child controls (e.g., Panels)
                {
                    ResetButtonStyle(control.Controls); // Recursively reset child controls
                }
            }
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
        }
    }
}
