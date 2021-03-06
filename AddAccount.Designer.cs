﻿
namespace _291GroupProject
{
    partial class AddAccount
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DoBBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountryBox = new System.Windows.Forms.TextBox();
            this.ProvinceBox = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.StreetNameBox = new System.Windows.Forms.TextBox();
            this.ZipBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerIDBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.AddAccountBackButton = new System.Windows.Forms.Button();
            this.DrivingLicenseBox = new System.Windows.Forms.TextBox();
            this.NumberBox = new System.Windows.Forms.TextBox();
            this.Apt_NumberBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Personal Information";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.Location = new System.Drawing.Point(75, 162);
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(161, 20);
            this.FirstNameBox.TabIndex = 2;
            this.FirstNameBox.Text = "First Name";
            // 
            // LastNameBox
            // 
            this.LastNameBox.Location = new System.Drawing.Point(432, 162);
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(161, 20);
            this.LastNameBox.TabIndex = 3;
            this.LastNameBox.Text = "Last Name";
            this.LastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contact Information";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(75, 229);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(161, 20);
            this.EmailBox.TabIndex = 5;
            this.EmailBox.Text = "Email";
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(432, 229);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(161, 20);
            this.PhoneBox.TabIndex = 6;
            this.PhoneBox.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(236, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date of Birth/Driving License";
            // 
            // DoBBox
            // 
            this.DoBBox.Location = new System.Drawing.Point(75, 309);
            this.DoBBox.Name = "DoBBox";
            this.DoBBox.Size = new System.Drawing.Size(161, 20);
            this.DoBBox.TabIndex = 8;
            this.DoBBox.Text = "dd/mm/yyyy";
            this.DoBBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // CountryBox
            // 
            this.CountryBox.Location = new System.Drawing.Point(75, 416);
            this.CountryBox.Name = "CountryBox";
            this.CountryBox.Size = new System.Drawing.Size(161, 20);
            this.CountryBox.TabIndex = 10;
            this.CountryBox.Text = "Country";
            // 
            // ProvinceBox
            // 
            this.ProvinceBox.Location = new System.Drawing.Point(250, 416);
            this.ProvinceBox.Name = "ProvinceBox";
            this.ProvinceBox.Size = new System.Drawing.Size(161, 20);
            this.ProvinceBox.TabIndex = 11;
            this.ProvinceBox.Text = "State/Province";
            // 
            // CityBox
            // 
            this.CityBox.Location = new System.Drawing.Point(432, 416);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(161, 20);
            this.CityBox.TabIndex = 12;
            this.CityBox.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(247, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "State/Province";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(429, 400);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "City";
            // 
            // StreetNameBox
            // 
            this.StreetNameBox.Location = new System.Drawing.Point(75, 462);
            this.StreetNameBox.Name = "StreetNameBox";
            this.StreetNameBox.Size = new System.Drawing.Size(161, 20);
            this.StreetNameBox.TabIndex = 16;
            this.StreetNameBox.Text = "Street Name";
            // 
            // ZipBox
            // 
            this.ZipBox.Location = new System.Drawing.Point(432, 462);
            this.ZipBox.Name = "ZipBox";
            this.ZipBox.Size = new System.Drawing.Size(161, 20);
            this.ZipBox.TabIndex = 17;
            this.ZipBox.Text = "Code";
            this.ZipBox.TextChanged += new System.EventHandler(this.ZipBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(72, 446);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Street Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(429, 446);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Zip/Postal Code";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(221, 566);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Please enter a User ID";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // CustomerIDBox
            // 
            this.CustomerIDBox.Location = new System.Drawing.Point(215, 610);
            this.CustomerIDBox.Name = "CustomerIDBox";
            this.CustomerIDBox.Size = new System.Drawing.Size(196, 20);
            this.CustomerIDBox.TabIndex = 21;
            this.CustomerIDBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(160, 686);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(293, 61);
            this.ConfirmButton.TabIndex = 22;
            this.ConfirmButton.Text = "Confirm";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // AddAccountBackButton
            // 
            this.AddAccountBackButton.Location = new System.Drawing.Point(4, 13);
            this.AddAccountBackButton.Name = "AddAccountBackButton";
            this.AddAccountBackButton.Size = new System.Drawing.Size(85, 26);
            this.AddAccountBackButton.TabIndex = 23;
            this.AddAccountBackButton.Text = "Back";
            this.AddAccountBackButton.UseVisualStyleBackColor = true;
            this.AddAccountBackButton.Click += new System.EventHandler(this.AddAccountBackButton_Click);
            // 
            // DrivingLicenseBox
            // 
            this.DrivingLicenseBox.Location = new System.Drawing.Point(432, 309);
            this.DrivingLicenseBox.Name = "DrivingLicenseBox";
            this.DrivingLicenseBox.Size = new System.Drawing.Size(161, 20);
            this.DrivingLicenseBox.TabIndex = 24;
            this.DrivingLicenseBox.Text = "Driving Licence";
            // 
            // NumberBox
            // 
            this.NumberBox.Location = new System.Drawing.Point(250, 462);
            this.NumberBox.Name = "NumberBox";
            this.NumberBox.Size = new System.Drawing.Size(161, 20);
            this.NumberBox.TabIndex = 25;
            this.NumberBox.Text = "Street Number";
            // 
            // Apt_NumberBox
            // 
            this.Apt_NumberBox.Location = new System.Drawing.Point(250, 504);
            this.Apt_NumberBox.Name = "Apt_NumberBox";
            this.Apt_NumberBox.Size = new System.Drawing.Size(161, 20);
            this.Apt_NumberBox.TabIndex = 26;
            this.Apt_NumberBox.Text = "Apt Number";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 797);
            this.Controls.Add(this.Apt_NumberBox);
            this.Controls.Add(this.NumberBox);
            this.Controls.Add(this.DrivingLicenseBox);
            this.Controls.Add(this.AddAccountBackButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CustomerIDBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ZipBox);
            this.Controls.Add(this.StreetNameBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.ProvinceBox);
            this.Controls.Add(this.CountryBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DoBBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameBox);
            this.Controls.Add(this.FirstNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAccount";
            this.Text = "AddAccountForm";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DoBBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CountryBox;
        private System.Windows.Forms.TextBox ProvinceBox;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox StreetNameBox;
        private System.Windows.Forms.TextBox ZipBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox CustomerIDBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Button AddAccountBackButton;
        private System.Windows.Forms.TextBox DrivingLicenseBox;
        private System.Windows.Forms.TextBox NumberBox;
        private System.Windows.Forms.TextBox Apt_NumberBox;
    }
}