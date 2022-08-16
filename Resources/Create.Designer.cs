
namespace Medcare.Resources
{
    partial class Create
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.fullname = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.doctorSelection = new Guna.UI.WinForms.GunaComboBox();
            this.dayofAppointment = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.email = new Guna.UI.WinForms.GunaTextBox();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(22, 24);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(67, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "FullName";
            // 
            // fullname
            // 
            this.fullname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.fullname.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.fullname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.fullname.BorderSize = 1;
            this.fullname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullname.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.fullname.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.fullname.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.fullname.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullname.ForeColor = System.Drawing.SystemColors.Control;
            this.fullname.Location = new System.Drawing.Point(24, 57);
            this.fullname.Name = "fullname";
            this.fullname.PasswordChar = '\0';
            this.fullname.SelectedText = "";
            this.fullname.Size = new System.Drawing.Size(235, 32);
            this.fullname.TabIndex = 1;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel2.Location = new System.Drawing.Point(322, 24);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(42, 17);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Email";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(21, 117);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(50, 17);
            this.gunaLabel3.TabIndex = 4;
            this.gunaLabel3.Text = "Doctor";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel4.Location = new System.Drawing.Point(322, 117);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(140, 17);
            this.gunaLabel4.TabIndex = 5;
            this.gunaLabel4.Text = "Date of Appointment";
            // 
            // doctorSelection
            // 
            this.doctorSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.doctorSelection.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.doctorSelection.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.doctorSelection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.doctorSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.doctorSelection.FocusedColor = System.Drawing.Color.Empty;
            this.doctorSelection.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doctorSelection.ForeColor = System.Drawing.Color.White;
            this.doctorSelection.FormattingEnabled = true;
            this.doctorSelection.Items.AddRange(new object[] {
            "Dr .Ian",
            "Dr Ngige"});
            this.doctorSelection.Location = new System.Drawing.Point(25, 152);
            this.doctorSelection.Name = "doctorSelection";
            this.doctorSelection.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.doctorSelection.OnHoverItemForeColor = System.Drawing.Color.White;
            this.doctorSelection.Size = new System.Drawing.Size(233, 24);
            this.doctorSelection.TabIndex = 6;
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
            this.dayofAppointment.Location = new System.Drawing.Point(324, 148);
            this.dayofAppointment.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dayofAppointment.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dayofAppointment.Name = "dayofAppointment";
            this.dayofAppointment.OnHoverBaseColor = System.Drawing.Color.White;
            this.dayofAppointment.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dayofAppointment.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dayofAppointment.OnPressedColor = System.Drawing.Color.Black;
            this.dayofAppointment.Size = new System.Drawing.Size(235, 30);
            this.dayofAppointment.TabIndex = 7;
            this.dayofAppointment.Text = "Thursday, August 4, 2022";
            this.dayofAppointment.Value = new System.DateTime(2022, 8, 4, 23, 58, 38, 934);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(325, 216);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(233, 42);
            this.gunaAdvenceButton1.TabIndex = 8;
            this.gunaAdvenceButton1.Text = "Make Appointment";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
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
            this.email.Location = new System.Drawing.Point(325, 57);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.SelectedText = "";
            this.email.Size = new System.Drawing.Size(235, 32);
            this.email.TabIndex = 9;
            // 
            // Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(584, 332);
            this.Controls.Add(this.email);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.dayofAppointment);
            this.Controls.Add(this.doctorSelection);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.fullname);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(584, 332);
            this.Name = "Create";
            this.Text = "Create";
            this.Load += new System.EventHandler(this.Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox fullname;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox doctorSelection;
        private Guna.UI.WinForms.GunaDateTimePicker dayofAppointment;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaTextBox email;
    }
}