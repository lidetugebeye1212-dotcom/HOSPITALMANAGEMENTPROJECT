namespace HOSPITALMANAGEMENTPROJECT
{
    partial class PatientForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PatAge = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Patid = new Guna.UI2.WinForms.Guna2TextBox();
            this.PatPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.Patblo = new System.Windows.Forms.ComboBox();
            this.PatGender = new System.Windows.Forms.ComboBox();
            this.Patdie = new Guna.UI2.WinForms.Guna2TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PatientGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1730, 100);
            this.panel1.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(650, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "HOSPITAL MANAGEMENT SYSTEM PATIENT";
            // 
            // PatAge
            // 
            this.PatAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatAge.DefaultText = "";
            this.PatAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatAge.Location = new System.Drawing.Point(15, 288);
            this.PatAge.Margin = new System.Windows.Forms.Padding(6);
            this.PatAge.Name = "PatAge";
            this.PatAge.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PatAge.PlaceholderText = "Patient Age";
            this.PatAge.SelectedText = "";
            this.PatAge.Size = new System.Drawing.Size(258, 44);
            this.PatAge.TabIndex = 13;
            // 
            // PatAddress
            // 
            this.PatAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatAddress.DefaultText = "";
            this.PatAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatAddress.Location = new System.Drawing.Point(15, 223);
            this.PatAddress.Margin = new System.Windows.Forms.Padding(6);
            this.PatAddress.Name = "PatAddress";
            this.PatAddress.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PatAddress.PlaceholderText = "Patient Address";
            this.PatAddress.SelectedText = "";
            this.PatAddress.Size = new System.Drawing.Size(258, 44);
            this.PatAddress.TabIndex = 14;
            // 
            // PatName
            // 
            this.PatName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatName.DefaultText = "";
            this.PatName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatName.Location = new System.Drawing.Point(15, 170);
            this.PatName.Margin = new System.Windows.Forms.Padding(6);
            this.PatName.Name = "PatName";
            this.PatName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PatName.PlaceholderText = "Patient Name";
            this.PatName.SelectedText = "";
            this.PatName.Size = new System.Drawing.Size(258, 41);
            this.PatName.TabIndex = 15;
            // 
            // Patid
            // 
            this.Patid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patid.DefaultText = "";
            this.Patid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Patid.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Patid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Patid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Patid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Patid.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Patid.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Patid.Location = new System.Drawing.Point(15, 114);
            this.Patid.Margin = new System.Windows.Forms.Padding(6);
            this.Patid.Name = "Patid";
            this.Patid.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Patid.PlaceholderText = "Patient id";
            this.Patid.SelectedText = "";
            this.Patid.Size = new System.Drawing.Size(263, 44);
            this.Patid.TabIndex = 16;
            // 
            // PatPhone
            // 
            this.PatPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PatPhone.DefaultText = "";
            this.PatPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PatPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PatPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PatPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PatPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PatPhone.Location = new System.Drawing.Point(15, 344);
            this.PatPhone.Margin = new System.Windows.Forms.Padding(6);
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PatPhone.PlaceholderText = "Patient Phone no";
            this.PatPhone.SelectedText = "";
            this.PatPhone.Size = new System.Drawing.Size(258, 44);
            this.PatPhone.TabIndex = 19;
            // 
            // Patblo
            // 
            this.Patblo.FormattingEnabled = true;
            this.Patblo.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "O-"});
            this.Patblo.Location = new System.Drawing.Point(12, 457);
            this.Patblo.Name = "Patblo";
            this.Patblo.Size = new System.Drawing.Size(266, 28);
            this.Patblo.TabIndex = 20;
            this.Patblo.Text = "BloodGroup";
            // 
            // PatGender
            // 
            this.PatGender.FormattingEnabled = true;
            this.PatGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.PatGender.Location = new System.Drawing.Point(15, 408);
            this.PatGender.Name = "PatGender";
            this.PatGender.Size = new System.Drawing.Size(263, 28);
            this.PatGender.TabIndex = 21;
            this.PatGender.Text = "Gender";
            // 
            // Patdie
            // 
            this.Patdie.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patdie.DefaultText = "";
            this.Patdie.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Patdie.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Patdie.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Patdie.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Patdie.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Patdie.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Patdie.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Patdie.Location = new System.Drawing.Point(15, 506);
            this.Patdie.Margin = new System.Windows.Forms.Padding(6);
            this.Patdie.Name = "Patdie";
            this.Patdie.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Patdie.PlaceholderText = "Major Deseas";
            this.Patdie.SelectedText = "";
            this.Patdie.Size = new System.Drawing.Size(258, 44);
            this.Patdie.TabIndex = 22;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Crimson;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(194, 595);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 65);
            this.button5.TabIndex = 26;
            this.button5.Text = "Update";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(386, 595);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 65);
            this.button4.TabIndex = 25;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(227, 679);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 64);
            this.button3.TabIndex = 24;
            this.button3.Text = "Home";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 595);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 63);
            this.button1.TabIndex = 23;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PatientGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PatientGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientGV.BackgroundColor = System.Drawing.Color.Teal;
            this.PatientGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PatientGV.ColumnHeadersHeight = 30;
            this.PatientGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.PatientGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.Location = new System.Drawing.Point(386, 126);
            this.PatientGV.Margin = new System.Windows.Forms.Padding(4);
            this.PatientGV.Name = "PatientGV";
            this.PatientGV.RowHeadersVisible = false;
            this.PatientGV.RowHeadersWidth = 62;
            this.PatientGV.RowTemplate.Height = 28;
            this.PatientGV.Size = new System.Drawing.Size(912, 461);
            this.PatientGV.TabIndex = 27;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PatientGV.ThemeStyle.BackColor = System.Drawing.Color.Teal;
            this.PatientGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PatientGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PatientGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PatientGV.ThemeStyle.HeaderStyle.Height = 30;
            this.PatientGV.ThemeStyle.ReadOnly = false;
            this.PatientGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PatientGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PatientGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGV.ThemeStyle.RowsStyle.Height = 28;
            this.PatientGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PatientGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PatientGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGV_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(1664, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 38);
            this.label7.TabIndex = 41;
            this.label7.Text = "X";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 826);
            this.Controls.Add(this.PatientGV);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Patdie);
            this.Controls.Add(this.PatGender);
            this.Controls.Add(this.Patblo);
            this.Controls.Add(this.PatPhone);
            this.Controls.Add(this.Patid);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.PatAddress);
            this.Controls.Add(this.PatAge);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientForm";
            this.Text = "PatientForm";
            this.Load += new System.EventHandler(this.PatientForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PatAge;
        private Guna.UI2.WinForms.Guna2TextBox PatAddress;
        private Guna.UI2.WinForms.Guna2TextBox PatName;
        private Guna.UI2.WinForms.Guna2TextBox Patid;
        private Guna.UI2.WinForms.Guna2TextBox PatPhone;
        private System.Windows.Forms.ComboBox Patblo;
        private System.Windows.Forms.ComboBox PatGender;
        private Guna.UI2.WinForms.Guna2TextBox Patdie;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2DataGridView PatientGV;
        private System.Windows.Forms.Label label7;
    }
}