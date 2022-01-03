
namespace WindowsFormsApp1
{
    partial class Doctor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DocID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DocName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ChanelDate = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ChanelFee = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Specialization = new System.Windows.Forms.ComboBox();
            this.DoctorGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(833, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 75);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans TC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(320, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Healthcare Channel Center - Doctor Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocID
            // 
            this.DocID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocID.HintForeColor = System.Drawing.Color.Empty;
            this.DocID.HintText = "";
            this.DocID.isPassword = false;
            this.DocID.LineFocusedColor = System.Drawing.Color.DimGray;
            this.DocID.LineIdleColor = System.Drawing.Color.Gray;
            this.DocID.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.DocID.LineThickness = 3;
            this.DocID.Location = new System.Drawing.Point(37, 135);
            this.DocID.Margin = new System.Windows.Forms.Padding(4);
            this.DocID.Name = "DocID";
            this.DocID.Size = new System.Drawing.Size(195, 33);
            this.DocID.TabIndex = 11;
            this.DocID.Text = "DoctorID";
            this.DocID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // DocName
            // 
            this.DocName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DocName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.DocName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DocName.HintForeColor = System.Drawing.Color.Empty;
            this.DocName.HintText = "";
            this.DocName.isPassword = false;
            this.DocName.LineFocusedColor = System.Drawing.Color.DimGray;
            this.DocName.LineIdleColor = System.Drawing.Color.Gray;
            this.DocName.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.DocName.LineThickness = 3;
            this.DocName.Location = new System.Drawing.Point(37, 176);
            this.DocName.Margin = new System.Windows.Forms.Padding(4);
            this.DocName.Name = "DocName";
            this.DocName.Size = new System.Drawing.Size(195, 33);
            this.DocName.TabIndex = 12;
            this.DocName.Text = "DoctorName";
            this.DocName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DocName.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox2_OnValueChanged);
            // 
            // ChanelDate
            // 
            this.ChanelDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChanelDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ChanelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChanelDate.HintForeColor = System.Drawing.Color.Empty;
            this.ChanelDate.HintText = "";
            this.ChanelDate.isPassword = false;
            this.ChanelDate.LineFocusedColor = System.Drawing.Color.DimGray;
            this.ChanelDate.LineIdleColor = System.Drawing.Color.Gray;
            this.ChanelDate.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.ChanelDate.LineThickness = 3;
            this.ChanelDate.Location = new System.Drawing.Point(37, 217);
            this.ChanelDate.Margin = new System.Windows.Forms.Padding(4);
            this.ChanelDate.Name = "ChanelDate";
            this.ChanelDate.Size = new System.Drawing.Size(195, 33);
            this.ChanelDate.TabIndex = 14;
            this.ChanelDate.Text = "ChannelingDate";
            this.ChanelDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChanelDate.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox4_OnValueChanged);
            // 
            // ChanelFee
            // 
            this.ChanelFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChanelFee.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ChanelFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChanelFee.HintForeColor = System.Drawing.Color.Empty;
            this.ChanelFee.HintText = "";
            this.ChanelFee.isPassword = false;
            this.ChanelFee.LineFocusedColor = System.Drawing.Color.DimGray;
            this.ChanelFee.LineIdleColor = System.Drawing.Color.Gray;
            this.ChanelFee.LineMouseHoverColor = System.Drawing.Color.DimGray;
            this.ChanelFee.LineThickness = 3;
            this.ChanelFee.Location = new System.Drawing.Point(37, 258);
            this.ChanelFee.Margin = new System.Windows.Forms.Padding(4);
            this.ChanelFee.Name = "ChanelFee";
            this.ChanelFee.Size = new System.Drawing.Size(195, 33);
            this.ChanelFee.TabIndex = 16;
            this.ChanelFee.Text = "ChannelingFee";
            this.ChanelFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChanelFee.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox5_OnValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(138, 395);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 41);
            this.button3.TabIndex = 18;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DodgerBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(37, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(37, 446);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 41);
            this.button4.TabIndex = 20;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Specialization
            // 
            this.Specialization.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialization.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Specialization.FormattingEnabled = true;
            this.Specialization.Items.AddRange(new object[] {
            "Anesthesiology",
            "Dermatology",
            "Pediatrics",
            "Cardiology",
            "Neurologist",
            "Psychiatry",
            "Radiologist",
            "Gastroenterology",
            "Surgeoun"});
            this.Specialization.Location = new System.Drawing.Point(37, 308);
            this.Specialization.Name = "Specialization";
            this.Specialization.Size = new System.Drawing.Size(195, 29);
            this.Specialization.TabIndex = 27;
            this.Specialization.Text = "Specialization";
            // 
            // DoctorGV
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.DoctorGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.DoctorGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DoctorGV.BackgroundColor = System.Drawing.Color.White;
            this.DoctorGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DoctorGV.ColumnHeadersHeight = 25;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorGV.DefaultCellStyle = dataGridViewCellStyle15;
            this.DoctorGV.EnableHeadersVisualStyles = false;
            this.DoctorGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.Location = new System.Drawing.Point(263, 103);
            this.DoctorGV.Name = "DoctorGV";
            this.DoctorGV.RowHeadersVisible = false;
            this.DoctorGV.RowHeadersWidth = 51;
            this.DoctorGV.RowTemplate.Height = 24;
            this.DoctorGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorGV.Size = new System.Drawing.Size(719, 380);
            this.DoctorGV.TabIndex = 28;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DoctorGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.DoctorGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DoctorGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DoctorGV.ThemeStyle.HeaderStyle.Height = 25;
            this.DoctorGV.ThemeStyle.ReadOnly = false;
            this.DoctorGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DoctorGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DoctorGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DoctorGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorGV.ThemeStyle.RowsStyle.Height = 24;
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DoctorGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DoctorGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DoctorGV_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DodgerBlue;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Noto Sans TC", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button5.Location = new System.Drawing.Point(138, 446);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 41);
            this.button5.TabIndex = 29;
            this.button5.Text = "Search";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1026, 583);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.DoctorGV);
            this.Controls.Add(this.Specialization);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ChanelFee);
            this.Controls.Add(this.ChanelDate);
            this.Controls.Add(this.DocName);
            this.Controls.Add(this.DocID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Doctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocID;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox DocName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ChanelDate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ChanelFee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Specialization;
        private Guna.UI2.WinForms.Guna2DataGridView DoctorGV;
        private System.Windows.Forms.Button button5;
    }
}