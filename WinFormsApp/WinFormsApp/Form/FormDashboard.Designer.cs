namespace HotelManagementSystemProject
{
    partial class FormDashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            panelSlide = new Panel();
            pictureBoxDashboard = new PictureBox();
            buttonInformation = new Button();
            buttonContact = new Button();
            buttonSetting = new Button();
            buttonReservation = new Button();
            buttonRoom = new Button();
            buttonClient = new Button();
            buttonDashboard = new Button();
            buttonUser = new Button();
            labelTitelHotelManagementSystem = new Label();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            labelTitelOfMenu = new Label();
            buttonLogOut = new Button();
            timer = new System.Windows.Forms.Timer(components);
            labelTimer = new Label();
            panel1 = new Panel();
            panelContainerDashboardForm = new Panel();
            panelSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSlide
            // 
            panelSlide.BackColor = SystemColors.ActiveCaption;
            panelSlide.Controls.Add(pictureBoxDashboard);
            panelSlide.Controls.Add(buttonInformation);
            panelSlide.Controls.Add(buttonContact);
            panelSlide.Controls.Add(buttonSetting);
            panelSlide.Controls.Add(buttonReservation);
            panelSlide.Controls.Add(buttonRoom);
            panelSlide.Controls.Add(buttonClient);
            panelSlide.Controls.Add(buttonDashboard);
            panelSlide.Dock = DockStyle.Left;
            panelSlide.Location = new Point(0, 0);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(264, 734);
            panelSlide.TabIndex = 1;
            // 
            // pictureBoxDashboard
            // 
            pictureBoxDashboard.Image = (Image)resources.GetObject("pictureBoxDashboard.Image");
            pictureBoxDashboard.Location = new Point(3, 0);
            pictureBoxDashboard.Name = "pictureBoxDashboard";
            pictureBoxDashboard.Size = new Size(262, 69);
            pictureBoxDashboard.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDashboard.TabIndex = 3;
            pictureBoxDashboard.TabStop = false;
            // 
            // buttonInformation
            // 
            buttonInformation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonInformation.BackColor = SystemColors.AppWorkspace;
            buttonInformation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonInformation.ForeColor = SystemColors.ButtonHighlight;
            buttonInformation.Image = (Image)resources.GetObject("buttonInformation.Image");
            buttonInformation.ImageAlign = ContentAlignment.TopLeft;
            buttonInformation.Location = new Point(31, 522);
            buttonInformation.Name = "buttonInformation";
            buttonInformation.Padding = new Padding(11, 0, 0, 0);
            buttonInformation.Size = new Size(230, 59);
            buttonInformation.TabIndex = 7;
            buttonInformation.Text = "Information";
            buttonInformation.TextAlign = ContentAlignment.MiddleRight;
            buttonInformation.UseVisualStyleBackColor = false;
            buttonInformation.Click += buttonInformation_Click;
            // 
            // buttonContact
            // 
            buttonContact.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonContact.BackColor = SystemColors.AppWorkspace;
            buttonContact.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonContact.ForeColor = SystemColors.ButtonHighlight;
            buttonContact.Image = (Image)resources.GetObject("buttonContact.Image");
            buttonContact.ImageAlign = ContentAlignment.TopLeft;
            buttonContact.Location = new Point(31, 457);
            buttonContact.Name = "buttonContact";
            buttonContact.Padding = new Padding(11, 0, 0, 0);
            buttonContact.Size = new Size(230, 59);
            buttonContact.TabIndex = 6;
            buttonContact.Text = "Contact";
            buttonContact.TextAlign = ContentAlignment.MiddleRight;
            buttonContact.UseVisualStyleBackColor = false;
            buttonContact.Click += buttonContact_Click;
            // 
            // buttonSetting
            // 
            buttonSetting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonSetting.BackColor = SystemColors.AppWorkspace;
            buttonSetting.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSetting.ForeColor = SystemColors.ButtonHighlight;
            buttonSetting.Image = (Image)resources.GetObject("buttonSetting.Image");
            buttonSetting.ImageAlign = ContentAlignment.TopLeft;
            buttonSetting.Location = new Point(31, 392);
            buttonSetting.Name = "buttonSetting";
            buttonSetting.Padding = new Padding(11, 0, 0, 0);
            buttonSetting.Size = new Size(230, 59);
            buttonSetting.TabIndex = 5;
            buttonSetting.Text = "Setting";
            buttonSetting.TextAlign = ContentAlignment.MiddleRight;
            buttonSetting.UseVisualStyleBackColor = false;
            buttonSetting.Click += buttonSetting_Click;
            // 
            // buttonReservation
            // 
            buttonReservation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonReservation.BackColor = SystemColors.AppWorkspace;
            buttonReservation.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReservation.ForeColor = SystemColors.ButtonHighlight;
            buttonReservation.Image = (Image)resources.GetObject("buttonReservation.Image");
            buttonReservation.ImageAlign = ContentAlignment.TopLeft;
            buttonReservation.Location = new Point(31, 327);
            buttonReservation.Name = "buttonReservation";
            buttonReservation.Padding = new Padding(11, 0, 0, 0);
            buttonReservation.Size = new Size(230, 59);
            buttonReservation.TabIndex = 4;
            buttonReservation.Text = "Reservation";
            buttonReservation.TextAlign = ContentAlignment.MiddleRight;
            buttonReservation.UseVisualStyleBackColor = false;
            buttonReservation.Click += buttonReservation_Click;
            // 
            // buttonRoom
            // 
            buttonRoom.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonRoom.BackColor = SystemColors.AppWorkspace;
            buttonRoom.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRoom.ForeColor = SystemColors.ButtonHighlight;
            buttonRoom.Image = (Image)resources.GetObject("buttonRoom.Image");
            buttonRoom.ImageAlign = ContentAlignment.TopLeft;
            buttonRoom.Location = new Point(31, 262);
            buttonRoom.Name = "buttonRoom";
            buttonRoom.Padding = new Padding(11, 0, 0, 0);
            buttonRoom.Size = new Size(230, 59);
            buttonRoom.TabIndex = 3;
            buttonRoom.Text = "Room";
            buttonRoom.TextAlign = ContentAlignment.MiddleRight;
            buttonRoom.UseVisualStyleBackColor = false;
            buttonRoom.Click += buttonRoom_Click;
            // 
            // buttonClient
            // 
            buttonClient.BackColor = SystemColors.AppWorkspace;
            buttonClient.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonClient.ForeColor = SystemColors.ButtonHighlight;
            buttonClient.Image = (Image)resources.GetObject("buttonClient.Image");
            buttonClient.ImageAlign = ContentAlignment.TopLeft;
            buttonClient.Location = new Point(31, 197);
            buttonClient.Name = "buttonClient";
            buttonClient.Padding = new Padding(11, 0, 0, 0);
            buttonClient.Size = new Size(230, 59);
            buttonClient.TabIndex = 2;
            buttonClient.Text = "Client";
            buttonClient.TextAlign = ContentAlignment.MiddleRight;
            buttonClient.UseVisualStyleBackColor = false;
            buttonClient.Click += buttonClient_Click;
            // 
            // buttonDashboard
            // 
            buttonDashboard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonDashboard.BackColor = SystemColors.AppWorkspace;
            buttonDashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDashboard.ForeColor = SystemColors.ButtonHighlight;
            buttonDashboard.Image = (Image)resources.GetObject("buttonDashboard.Image");
            buttonDashboard.ImageAlign = ContentAlignment.TopLeft;
            buttonDashboard.Location = new Point(31, 132);
            buttonDashboard.Name = "buttonDashboard";
            buttonDashboard.Padding = new Padding(11, 0, 0, 0);
            buttonDashboard.Size = new Size(230, 59);
            buttonDashboard.TabIndex = 1;
            buttonDashboard.Text = "Dashboard";
            buttonDashboard.TextAlign = ContentAlignment.MiddleRight;
            buttonDashboard.UseVisualStyleBackColor = false;
            buttonDashboard.Click += buttonDashboard_Click;
            // 
            // buttonUser
            // 
            buttonUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonUser.BackColor = SystemColors.ActiveCaption;
            buttonUser.FlatAppearance.BorderSize = 0;
            buttonUser.FlatStyle = FlatStyle.Flat;
            buttonUser.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUser.ForeColor = SystemColors.Window;
            buttonUser.ImageAlign = ContentAlignment.TopLeft;
            buttonUser.Location = new Point(981, 8);
            buttonUser.Name = "buttonUser";
            buttonUser.Padding = new Padding(11, 0, 0, 0);
            buttonUser.Size = new Size(218, 54);
            buttonUser.TabIndex = 8;
            buttonUser.Text = "User";
            buttonUser.TextAlign = ContentAlignment.BottomLeft;
            buttonUser.UseVisualStyleBackColor = false;
            // 
            // labelTitelHotelManagementSystem
            // 
            labelTitelHotelManagementSystem.AutoSize = true;
            labelTitelHotelManagementSystem.BackColor = SystemColors.ActiveCaption;
            labelTitelHotelManagementSystem.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitelHotelManagementSystem.ForeColor = SystemColors.Window;
            labelTitelHotelManagementSystem.Location = new Point(38, 9);
            labelTitelHotelManagementSystem.Name = "labelTitelHotelManagementSystem";
            labelTitelHotelManagementSystem.Size = new Size(491, 41);
            labelTitelHotelManagementSystem.TabIndex = 0;
            labelTitelHotelManagementSystem.Text = "Hotel Management System: ";
            labelTitelHotelManagementSystem.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(buttonUser);
            panel4.Controls.Add(labelTitelOfMenu);
            panel4.Controls.Add(labelTitelHotelManagementSystem);
            panel4.Controls.Add(buttonLogOut);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(264, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1364, 69);
            panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(884, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // labelTitelOfMenu
            // 
            labelTitelOfMenu.AutoSize = true;
            labelTitelOfMenu.Font = new Font("Century Gothic", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitelOfMenu.ForeColor = SystemColors.Window;
            labelTitelOfMenu.Location = new Point(526, 9);
            labelTitelOfMenu.Name = "labelTitelOfMenu";
            labelTitelOfMenu.Size = new Size(178, 41);
            labelTitelOfMenu.TabIndex = 4;
            labelTitelOfMenu.Text = "Welcome";
            // 
            // buttonLogOut
            // 
            buttonLogOut.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonLogOut.BackColor = SystemColors.Highlight;
            buttonLogOut.CausesValidation = false;
            buttonLogOut.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogOut.ForeColor = SystemColors.ButtonHighlight;
            buttonLogOut.Image = (Image)resources.GetObject("buttonLogOut.Image");
            buttonLogOut.ImageAlign = ContentAlignment.MiddleRight;
            buttonLogOut.Location = new Point(1231, 8);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(133, 51);
            buttonLogOut.TabIndex = 0;
            buttonLogOut.Text = "Log out";
            buttonLogOut.TextAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += ButtonLogOut_LinkedClick;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // labelTimer
            // 
            labelTimer.AutoSize = true;
            labelTimer.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelTimer.Location = new Point(1279, 3);
            labelTimer.Name = "labelTimer";
            labelTimer.Size = new Size(57, 21);
            labelTimer.TabIndex = 3;
            labelTimer.Text = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelTimer);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(264, 701);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 33);
            panel1.TabIndex = 4;
            // 
            // panelContainerDashboardForm
            // 
            panelContainerDashboardForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelContainerDashboardForm.Location = new Point(264, 69);
            panelContainerDashboardForm.Name = "panelContainerDashboardForm";
            panelContainerDashboardForm.Size = new Size(1364, 632);
            panelContainerDashboardForm.TabIndex = 5;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1628, 734);
            Controls.Add(panelContainerDashboardForm);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panelSlide);
            Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hotel Management System | Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += FormDashBoard_Load;
            panelSlide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxDashboard).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSlide;
        private Panel panel4;
        private Label labelTitelHotelManagementSystem;
        private Button buttonDashboard;
        private Button buttonSetting;
        private Button buttonReservation;
        private Button buttonRoom;
        private Button buttonClient;
        private Button buttonContact;
        private Button buttonInformation;
        private PictureBox pictureBoxDashboard;
        private Button buttonLogOut;
        private System.Windows.Forms.Timer timer;
        private Label labelTimer;
        private Label labelTitelOfMenu;
        private Button buttonUser;
        private Panel panel1;
        private Panel panelContainerDashboardForm;
        private PictureBox pictureBox1;
    }
}