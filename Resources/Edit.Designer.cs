
namespace Medcare.Resources
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.Fullname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.doctorList = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.dayofAppointment = new Guna.UI.WinForms.GunaDateTimePicker();
            this.email = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.SuspendLayout();
            // 
            // Fullname
            // 
            this.Fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.Fullname.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.Fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.Fullname.BorderSize = 1;
            this.Fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Fullname.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.Fullname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Fullname.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.Fullname.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fullname.ForeColor = System.Drawing.SystemColors.Control;
            this.Fullname.Location = new System.Drawing.Point(22, 53);
            this.Fullname.Name = "Fullname";
            this.Fullname.PasswordChar = '\0';
            this.Fullname.SelectedText = "";
            this.Fullname.Size = new System.Drawing.Size(235, 32);
            this.Fullname.TabIndex = 2;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(19, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(65, 17);
            this.gunaLabel1.TabIndex = 3;
            this.gunaLabel1.Text = "Fullname";
            // 
            // doctorList
            // 
            this.doctorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.doctorList.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.doctorList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.doctorList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.doctorList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorList.FocusedColor = System.Drawing.Color.Empty;
            this.doctorList.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorList.ForeColor = System.Drawing.Color.White;
            this.doctorList.FormattingEnabled = true;
            this.doctorList.Location = new System.Drawing.Point(24, 175);
            this.doctorList.Name = "doctorList";
            this.doctorList.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.doctorList.OnHoverItemForeColor = System.Drawing.Color.White;
            this.doctorList.Size = new System.Drawing.Size(233, 24);
            this.doctorList.TabIndex = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(21, 144);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(50, 17);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Doctor";
            // 
            // dayofAppointment
            // 
            this.dayofAppointment.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.dayofAppointment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.dayofAppointment.CustomFormat = null;
            this.dayofAppointment.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dayofAppointment.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dayofAppointment.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofAppointment.ForeColor = System.Drawing.Color.White;
            this.dayofAppointment.Location = new System.Drawing.Point(327, 173);
            this.dayofAppointment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dayofAppointment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dayofAppointment.Name = "dayofAppointment";
            this.dayofAppointment.OnHoverBaseColor = System.Drawing.Color.White;
            this.dayofAppointment.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dayofAppointment.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dayofAppointment.OnPressedColor = System.Drawing.Color.Black;
            this.dayofAppointment.Size = new System.Drawing.Size(235, 30);
            this.dayofAppointment.TabIndex = 9;
            this.dayofAppointment.Text = "Thursday, August 4, 2022";
            this.dayofAppointment.Value = new System.DateTime(2022, 8, 4, 23, 58, 38, 934);
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.email.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.email.BorderSize = 1;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.email.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.email.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.email.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.SystemColors.Control;
            this.email.Location = new System.Drawing.Point(327, 54);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(235, 32);
            this.email.TabIndex = 10;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(324, 21);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(42, 17);
            this.gunaLabel2.TabIndex = 11;
            this.gunaLabel2.Text = "Email";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(324, 140);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(140, 17);
            this.gunaLabel4.TabIndex = 12;
            this.gunaLabel4.Text = "Date of Appointment";
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = null;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(329, 239);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(233, 42);
            this.gunaAdvenceButton1.TabIndex = 13;
            this.gunaAdvenceButton1.Text = "Update Appointment";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(584, 332);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.email);
            this.Controls.Add(this.dayofAppointment);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.doctorList);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.Fullname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox Fullname;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox doctorList;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaDateTimePicker dayofAppointment;
        private Guna.UI.WinForms.GunaTextBox email;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
    }
}