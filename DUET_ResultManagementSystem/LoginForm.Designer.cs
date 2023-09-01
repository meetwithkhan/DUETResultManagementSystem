namespace DUET_ResultManagementSystem
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginFormPanel = new System.Windows.Forms.Panel();
            this.loginButton = new DUET_ResultManagementSystem.CornerRoundButton();
            this.loginFormTitleLabel = new System.Windows.Forms.Label();
            this.loginFailStatusLabel = new System.Windows.Forms.Label();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.userPictureBox = new System.Windows.Forms.PictureBox();
            this.passwordPanel = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userNamePanel = new System.Windows.Forms.Panel();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loginFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginFormPanel
            // 
            this.loginFormPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(171)))), ((int)(((byte)(169)))));
            this.loginFormPanel.Controls.Add(this.loginButton);
            this.loginFormPanel.Controls.Add(this.loginFormTitleLabel);
            this.loginFormPanel.Controls.Add(this.loginFailStatusLabel);
            this.loginFormPanel.Controls.Add(this.userTypeComboBox);
            this.loginFormPanel.Controls.Add(this.pictureBox3);
            this.loginFormPanel.Controls.Add(this.pictureBox2);
            this.loginFormPanel.Controls.Add(this.userPictureBox);
            this.loginFormPanel.Controls.Add(this.passwordPanel);
            this.loginFormPanel.Controls.Add(this.passwordTextBox);
            this.loginFormPanel.Controls.Add(this.userNamePanel);
            this.loginFormPanel.Controls.Add(this.userNameTextBox);
            this.loginFormPanel.Controls.Add(this.pictureBox1);
            this.loginFormPanel.Location = new System.Drawing.Point(341, 74);
            this.loginFormPanel.Name = "loginFormPanel";
            this.loginFormPanel.Size = new System.Drawing.Size(345, 406);
            this.loginFormPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century", 14F);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(94, 331);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(201, 49);
            this.loginButton.TabIndex = 11;
            this.loginButton.Text = "Sign in";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginFormTitleLabel
            // 
            this.loginFormTitleLabel.AutoSize = true;
            this.loginFormTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginFormTitleLabel.Font = new System.Drawing.Font("Century", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFormTitleLabel.ForeColor = System.Drawing.Color.White;
            this.loginFormTitleLabel.Location = new System.Drawing.Point(3, 131);
            this.loginFormTitleLabel.Name = "loginFormTitleLabel";
            this.loginFormTitleLabel.Size = new System.Drawing.Size(344, 28);
            this.loginFormTitleLabel.TabIndex = 0;
            this.loginFormTitleLabel.Text = "Result  Management System";
            // 
            // loginFailStatusLabel
            // 
            this.loginFailStatusLabel.AutoSize = true;
            this.loginFailStatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginFailStatusLabel.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginFailStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.loginFailStatusLabel.Location = new System.Drawing.Point(6, 162);
            this.loginFailStatusLabel.Name = "loginFailStatusLabel";
            this.loginFailStatusLabel.Size = new System.Drawing.Size(336, 21);
            this.loginFailStatusLabel.TabIndex = 10;
            this.loginFailStatusLabel.Text = "Check your username and  password";
            // 
            // userTypeComboBox
            // 
            this.userTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.userTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userTypeComboBox.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTypeComboBox.ForeColor = System.Drawing.Color.White;
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Items.AddRange(new object[] {
            "Admin",
            "Student"});
            this.userTypeComboBox.Location = new System.Drawing.Point(80, 194);
            this.userTypeComboBox.Name = "userTypeComboBox";
            this.userTypeComboBox.Size = new System.Drawing.Size(117, 31);
            this.userTypeComboBox.TabIndex = 1;
            this.userTypeComboBox.Text = "User Type";
            this.userTypeComboBox.TextChanged += new System.EventHandler(this.userTypeComboBox_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(37, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 278);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // userPictureBox
            // 
            this.userPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.userPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("userPictureBox.Image")));
            this.userPictureBox.Location = new System.Drawing.Point(37, 235);
            this.userPictureBox.Name = "userPictureBox";
            this.userPictureBox.Size = new System.Drawing.Size(35, 33);
            this.userPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPictureBox.TabIndex = 6;
            this.userPictureBox.TabStop = false;
            // 
            // passwordPanel
            // 
            this.passwordPanel.BackColor = System.Drawing.Color.White;
            this.passwordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordPanel.Location = new System.Drawing.Point(80, 306);
            this.passwordPanel.Name = "passwordPanel";
            this.passwordPanel.Size = new System.Drawing.Size(228, 3);
            this.passwordPanel.TabIndex = 5;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.ForeColor = System.Drawing.Color.White;
            this.passwordTextBox.Location = new System.Drawing.Point(80, 285);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(228, 24);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.Text = "password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // userNamePanel
            // 
            this.userNamePanel.BackColor = System.Drawing.Color.White;
            this.userNamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNamePanel.Location = new System.Drawing.Point(80, 263);
            this.userNamePanel.Name = "userNamePanel";
            this.userNamePanel.Size = new System.Drawing.Size(228, 3);
            this.userNamePanel.TabIndex = 3;
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(38)))), ((int)(((byte)(65)))));
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.ForeColor = System.Drawing.Color.White;
            this.userNameTextBox.Location = new System.Drawing.Point(80, 240);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(228, 24);
            this.userNameTextBox.TabIndex = 2;
            this.userNameTextBox.Text = "Username";
            this.userNameTextBox.Enter += new System.EventHandler(this.userNameTextBox_Enter);
            this.userNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTextBox_KeyDown);
            this.userNameTextBox.Leave += new System.EventHandler(this.userNameTextBox_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(344, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Designed And Developed By \r\n               AMR_CSEian";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginFormPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DUET Result Managment System - Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.loginForm_FormClosing);
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.loginFormPanel.ResumeLayout(false);
            this.loginFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginFormPanel;
        private System.Windows.Forms.Label loginFormTitleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel passwordPanel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel userNamePanel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox userPictureBox;
        private System.Windows.Forms.ComboBox userTypeComboBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label loginFailStatusLabel;
        private CornerRoundButton loginButton;
        private System.Windows.Forms.Label label1;
    }
}

