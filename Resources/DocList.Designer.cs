
namespace Medcare.Resources
{
    partial class DocList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocList));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.searchText = new Guna.UI.WinForms.GunaTextBox();
            this.searchBtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.number = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.subPanel = new Guna.UI.WinForms.GunaPanel();
            this.DoctorList = new Guna.UI.WinForms.GunaDataGridView();
            this.btnPanel = new Guna.UI.WinForms.GunaPanel();
            this.gunaAdvenceButton5 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton4 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaPanel1.SuspendLayout();
            this.subPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorList)).BeginInit();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.searchText);
            this.gunaPanel1.Controls.Add(this.searchBtn);
            this.gunaPanel1.Controls.Add(this.gunaLabel3);
            this.gunaPanel1.Controls.Add(this.number);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(793, 40);
            this.gunaPanel1.TabIndex = 1;
            // 
            // searchText
            // 
            this.searchText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(12)))), ((int)(((byte)(54)))));
            this.searchText.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.searchText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.searchText.BorderSize = 1;
            this.searchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchText.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.searchText.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchText.FocusedForeColor = System.Drawing.SystemColors.Control;
            this.searchText.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.ForeColor = System.Drawing.SystemColors.Control;
            this.searchText.Location = new System.Drawing.Point(514, 5);
            this.searchText.Name = "searchText";
            this.searchText.PasswordChar = '\0';
            this.searchText.SelectedText = "";
            this.searchText.Size = new System.Drawing.Size(160, 29);
            this.searchText.TabIndex = 10;
            // 
            // searchBtn
            // 
            this.searchBtn.AnimationHoverSpeed = 0.07F;
            this.searchBtn.AnimationSpeed = 0.03F;
            this.searchBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.searchBtn.BorderColor = System.Drawing.Color.Black;
            this.searchBtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.searchBtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.searchBtn.CheckedForeColor = System.Drawing.Color.White;
            this.searchBtn.CheckedImage = null;
            this.searchBtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.searchBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchBtn.FocusedColor = System.Drawing.Color.Empty;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Image = null;
            this.searchBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.searchBtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.searchBtn.Location = new System.Drawing.Point(680, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.searchBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.searchBtn.OnHoverImage = null;
            this.searchBtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.searchBtn.OnPressedColor = System.Drawing.Color.Black;
            this.searchBtn.Size = new System.Drawing.Size(90, 29);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel3.Location = new System.Drawing.Point(402, 12);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(91, 17);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "search doctor";
            // 
            // number
            // 
            this.number.AutoSize = true;
            this.number.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.ForeColor = System.Drawing.SystemColors.Control;
            this.number.Location = new System.Drawing.Point(85, 12);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(15, 17);
            this.number.TabIndex = 4;
            this.number.Text = "0";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.gunaLabel1.Location = new System.Drawing.Point(16, 12);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(68, 17);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Doctors  :";
            // 
            // subPanel
            // 
            this.subPanel.Controls.Add(this.DoctorList);
            this.subPanel.Controls.Add(this.btnPanel);
            this.subPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subPanel.Location = new System.Drawing.Point(0, 40);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(793, 450);
            this.subPanel.TabIndex = 2;
            // 
            // DoctorList
            // 
            this.DoctorList.AllowUserToAddRows = false;
            this.DoctorList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DoctorList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.DoctorList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorList.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DoctorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorList.EnableHeadersVisualStyles = false;
            this.DoctorList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.DoctorList.Location = new System.Drawing.Point(0, 0);
            this.DoctorList.Name = "DoctorList";
            this.DoctorList.ReadOnly = true;
            this.DoctorList.RowHeadersVisible = false;
            this.DoctorList.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.DoctorList.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorList.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DoctorList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.DoctorList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.DoctorList.RowTemplate.Height = 32;
            this.DoctorList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorList.Size = new System.Drawing.Size(793, 403);
            this.DoctorList.TabIndex = 5;
            this.DoctorList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DoctorList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DoctorList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DoctorList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DoctorList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DoctorList.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.DoctorList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.DoctorList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DoctorList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DoctorList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DoctorList.ThemeStyle.HeaderStyle.Height = 35;
            this.DoctorList.ThemeStyle.ReadOnly = true;
            this.DoctorList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorList.ThemeStyle.RowsStyle.Height = 32;
            this.DoctorList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnPanel
            // 
            this.btnPanel.Controls.Add(this.gunaAdvenceButton5);
            this.btnPanel.Controls.Add(this.gunaAdvenceButton4);
            this.btnPanel.Controls.Add(this.gunaAdvenceButton2);
            this.btnPanel.Controls.Add(this.gunaAdvenceButton1);
            this.btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPanel.Location = new System.Drawing.Point(0, 403);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(793, 47);
            this.btnPanel.TabIndex = 3;
            // 
            // gunaAdvenceButton5
            // 
            this.gunaAdvenceButton5.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton5.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton5.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton5.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.CheckedImage = null;
            this.gunaAdvenceButton5.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton5.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton5.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton5.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton5.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.Image = null;
            this.gunaAdvenceButton5.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton5.Location = new System.Drawing.Point(164, 8);
            this.gunaAdvenceButton5.Name = "gunaAdvenceButton5";
            this.gunaAdvenceButton5.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton5.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton5.OnHoverImage = null;
            this.gunaAdvenceButton5.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton5.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton5.Size = new System.Drawing.Size(134, 31);
            this.gunaAdvenceButton5.TabIndex = 3;
            this.gunaAdvenceButton5.Text = "List Doctors";
            this.gunaAdvenceButton5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton5.Click += new System.EventHandler(this.gunaAdvenceButton5_Click);
            // 
            // gunaAdvenceButton4
            // 
            this.gunaAdvenceButton4.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton4.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton4.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton4.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.CheckedImage = null;
            this.gunaAdvenceButton4.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton4.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton4.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton4.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.Image = null;
            this.gunaAdvenceButton4.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.Location = new System.Drawing.Point(329, 8);
            this.gunaAdvenceButton4.Name = "gunaAdvenceButton4";
            this.gunaAdvenceButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton4.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton4.OnHoverImage = null;
            this.gunaAdvenceButton4.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton4.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton4.Size = new System.Drawing.Size(134, 31);
            this.gunaAdvenceButton4.TabIndex = 2;
            this.gunaAdvenceButton4.Text = "Add Doctor";
            this.gunaAdvenceButton4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton4.Click += new System.EventHandler(this.gunaAdvenceButton4_Click_1);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = null;
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = null;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(478, 8);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(134, 31);
            this.gunaAdvenceButton2.TabIndex = 1;
            this.gunaAdvenceButton2.Text = "Edit";
            this.gunaAdvenceButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaAdvenceButton2_Click);
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
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(635, 8);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(134, 31);
            this.gunaAdvenceButton1.TabIndex = 0;
            this.gunaAdvenceButton1.Text = "Delete";
            this.gunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // DocList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(5)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(793, 490);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.gunaPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DocList";
            this.Text = "DocList";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.subPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorList)).EndInit();
            this.btnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaAdvenceButton searchBtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel number;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox searchText;
        private Guna.UI.WinForms.GunaPanel subPanel;
        private Guna.UI.WinForms.GunaPanel btnPanel;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton4;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaDataGridView DoctorList;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton5;
    }
}