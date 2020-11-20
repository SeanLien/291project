
namespace _291GroupProject
{
    partial class MainMenu
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
            this.EmployeeButton = new System.Windows.Forms.Button();
            this.CustomerButton = new System.Windows.Forms.Button();
            this.UserAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmployeeButton
            // 
            this.EmployeeButton.Location = new System.Drawing.Point(148, 61);
            this.EmployeeButton.Name = "EmployeeButton";
            this.EmployeeButton.Size = new System.Drawing.Size(154, 94);
            this.EmployeeButton.TabIndex = 0;
            this.EmployeeButton.Text = "EmployeeTest";
            this.EmployeeButton.UseVisualStyleBackColor = true;
            this.EmployeeButton.Click += new System.EventHandler(this.EmployeeButton_Click);
            // 
            // CustomerButton
            // 
            this.CustomerButton.Location = new System.Drawing.Point(148, 161);
            this.CustomerButton.Name = "CustomerButton";
            this.CustomerButton.Size = new System.Drawing.Size(154, 94);
            this.CustomerButton.TabIndex = 1;
            this.CustomerButton.Text = "Customer";
            this.CustomerButton.UseVisualStyleBackColor = true;
            this.CustomerButton.Click += new System.EventHandler(this.CustomerButton_Click);
            // 
            // UserAccountButton
            // 
            this.UserAccountButton.Location = new System.Drawing.Point(148, 261);
            this.UserAccountButton.Name = "UserAccountButton";
            this.UserAccountButton.Size = new System.Drawing.Size(154, 94);
            this.UserAccountButton.TabIndex = 2;
            this.UserAccountButton.Text = "Create User Account";
            this.UserAccountButton.UseVisualStyleBackColor = true;
            this.UserAccountButton.Click += new System.EventHandler(this.UserAccountButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 429);
            this.Controls.Add(this.UserAccountButton);
            this.Controls.Add(this.CustomerButton);
            this.Controls.Add(this.EmployeeButton);
            this.Name = "MainMenu";
            this.Text = "MainMenuForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EmployeeButton;
        private System.Windows.Forms.Button CustomerButton;
        private System.Windows.Forms.Button UserAccountButton;
    }
}