
namespace HotelManagementSystem
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            pictureBoxClose = new PictureBox();
            pictureBoxMinimizeWindows = new PictureBox();
            toolTipLogInForm = new ToolTip(components);
            panel1 = new Panel();
            Copyright = new Label();
            groupBox1 = new GroupBox();
            pictureBoxShowPassword = new PictureBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonLogIn = new Button();
            textBoxUserName = new TextBox();
            label1 = new Label();
            pictureBoxHidePassword = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizeWindows).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowPassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHidePassword).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxClose
            // 
            pictureBoxClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxClose.Cursor = Cursors.Hand;
            pictureBoxClose.Image = (Image)resources.GetObject("pictureBoxClose.Image");
            pictureBoxClose.Location = new Point(1394, 26);
            pictureBoxClose.Name = "pictureBoxClose";
            pictureBoxClose.Size = new Size(35, 35);
            pictureBoxClose.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxClose.TabIndex = 0;
            pictureBoxClose.TabStop = false;
            pictureBoxClose.Click += pictureBoxClose_Click;
            pictureBoxClose.MouseHover += pictureBoxClose_Hover;
            // 
            // pictureBoxMinimizeWindows
            // 
            pictureBoxMinimizeWindows.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxMinimizeWindows.Image = (Image)resources.GetObject("pictureBoxMinimizeWindows.Image");
            pictureBoxMinimizeWindows.Location = new Point(1353, 26);
            pictureBoxMinimizeWindows.Name = "pictureBoxMinimizeWindows";
            pictureBoxMinimizeWindows.Size = new Size(35, 35);
            pictureBoxMinimizeWindows.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxMinimizeWindows.TabIndex = 1;
            pictureBoxMinimizeWindows.TabStop = false;
            pictureBoxMinimizeWindows.Click += pictureBoxMinimizeWindows_Click;
            pictureBoxMinimizeWindows.MouseHover += pictureBoxMinimizeWindows_Hover;
            // 
            // panel1
            // 
            panel1.Controls.Add(Copyright);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 546);
            panel1.Name = "panel1";
            panel1.Size = new Size(1432, 70);
            panel1.TabIndex = 0;
            // 
            // Copyright
            // 
            Copyright.AutoSize = true;
            Copyright.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Copyright.Location = new Point(3, 38);
            Copyright.Name = "Copyright";
            Copyright.Size = new Size(455, 23);
            Copyright.TabIndex = 0;
            Copyright.Text = "Copyright © 2025. Allright Reserved. C# MODERN DESIGN";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(pictureBoxShowPassword);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(buttonLogIn);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBoxHidePassword);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(105, 120);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(691, 351);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Please Login First";
            // 
            // pictureBoxShowPassword
            // 
            pictureBoxShowPassword.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxShowPassword.Cursor = Cursors.Hand;
            pictureBoxShowPassword.Image = (Image)resources.GetObject("pictureBoxShowPassword.Image");
            pictureBoxShowPassword.Location = new Point(523, 143);
            pictureBoxShowPassword.Name = "pictureBoxShowPassword";
            pictureBoxShowPassword.Size = new Size(26, 30);
            pictureBoxShowPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxShowPassword.TabIndex = 6;
            pictureBoxShowPassword.TabStop = false;
            pictureBoxShowPassword.Click += pictureBoxShowPassword_Click;
            pictureBoxShowPassword.MouseHover += pictureBoxShowPassword_Hover;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaption;
            label3.Location = new Point(225, 197);
            label3.Name = "label3";
            label3.Size = new Size(161, 23);
            label3.TabIndex = 5;
            label3.Text = " Forgot Password ?";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.None;
            textBoxPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(225, 144);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(324, 30);
            textBoxPassword.TabIndex = 0;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 147);
            label2.Name = "label2";
            label2.Size = new Size(90, 23);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.Anchor = AnchorStyles.None;
            buttonLogIn.BackColor = SystemColors.ActiveCaption;
            buttonLogIn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.Location = new Point(221, 256);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(328, 41);
            buttonLogIn.TabIndex = 3;
            buttonLogIn.Text = "Log In";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Anchor = AnchorStyles.None;
            textBoxUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUserName.Location = new Point(221, 90);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(324, 30);
            textBoxUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(114, 93);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 0;
            label1.Text = "Username: ";
            // 
            // pictureBoxHidePassword
            // 
            pictureBoxHidePassword.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxHidePassword.Cursor = Cursors.Hand;
            pictureBoxHidePassword.Image = (Image)resources.GetObject("pictureBoxHidePassword.Image");
            pictureBoxHidePassword.Location = new Point(515, 144);
            pictureBoxHidePassword.Name = "pictureBoxHidePassword";
            pictureBoxHidePassword.Size = new Size(26, 30);
            pictureBoxHidePassword.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxHidePassword.TabIndex = 7;
            pictureBoxHidePassword.TabStop = false;
            pictureBoxHidePassword.Click += pictureBoxHidePassword_Click;
            pictureBoxHidePassword.MouseHover += pictureBoxHidePassword_Hover;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(963, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(291, 270);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(891, 425);
            label4.Name = "label4";
            label4.Size = new Size(434, 46);
            label4.TabIndex = 4;
            label4.Text = "Holtel Management System";
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1432, 616);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBoxMinimizeWindows);
            Controls.Add(pictureBoxClose);
            Name = "LogInForm";
            Text = "Hotel Management System | Login";
            ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMinimizeWindows).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShowPassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHidePassword).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBoxMinimizeWindows;
        private ToolTip toolTipLogInForm;
        private Panel panel1;
        private Label Copyright;
        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonLogIn;
        private TextBox textBoxUserName;
        private Label label1;
        private Label label3;
        private PictureBox pictureBoxShowPassword;
        private PictureBox pictureBoxHidePassword;
        private PictureBox pictureBox1;
        private Label label4;
        private EventHandler pictureBoxpHidePassword_Hover;

        public LogInForm(EventHandler pictureBoxpHidePassword_Hover)
        {
            this.pictureBoxpHidePassword_Hover = pictureBoxpHidePassword_Hover;
        }
    }
}