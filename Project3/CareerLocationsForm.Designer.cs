namespace Project3
{
    partial class CareerLocationsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CoopTable = new System.Windows.Forms.DataGridView();
            this.DegreeCoop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployerCoop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationCoop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TermCoop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployerTable = new System.Windows.Forms.DataGridView();
            this.DegreeFulltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployerFulltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationFulltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitleFulltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartdateFulltime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employerTitle = new System.Windows.Forms.Label();
            this.coopTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CoopTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(475, 0, 475, 0);
            this.label1.Size = new System.Drawing.Size(1344, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Where Our Students Work";
            // 
            // CoopTable
            // 
            this.CoopTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CoopTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.CoopTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CoopTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DegreeCoop,
            this.EmployerCoop,
            this.LocationCoop,
            this.TermCoop});
            this.CoopTable.Location = new System.Drawing.Point(721, 143);
            this.CoopTable.Name = "CoopTable";
            this.CoopTable.ReadOnly = true;
            this.CoopTable.Size = new System.Drawing.Size(580, 245);
            this.CoopTable.TabIndex = 1;
            // 
            // DegreeCoop
            // 
            this.DegreeCoop.HeaderText = "Degree";
            this.DegreeCoop.Name = "DegreeCoop";
            this.DegreeCoop.ReadOnly = true;
            // 
            // EmployerCoop
            // 
            this.EmployerCoop.HeaderText = "Employer";
            this.EmployerCoop.Name = "EmployerCoop";
            this.EmployerCoop.ReadOnly = true;
            // 
            // LocationCoop
            // 
            this.LocationCoop.HeaderText = "Location";
            this.LocationCoop.Name = "LocationCoop";
            this.LocationCoop.ReadOnly = true;
            // 
            // TermCoop
            // 
            this.TermCoop.HeaderText = "Term";
            this.TermCoop.Name = "TermCoop";
            this.TermCoop.ReadOnly = true;
            // 
            // EmployerTable
            // 
            this.EmployerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployerTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DegreeFulltime,
            this.EmployerFulltime,
            this.LocationFulltime,
            this.TitleFulltime,
            this.StartdateFulltime});
            this.EmployerTable.Location = new System.Drawing.Point(721, 431);
            this.EmployerTable.Name = "EmployerTable";
            this.EmployerTable.ReadOnly = true;
            this.EmployerTable.Size = new System.Drawing.Size(580, 245);
            this.EmployerTable.TabIndex = 2;
            // 
            // DegreeFulltime
            // 
            this.DegreeFulltime.HeaderText = "Degree";
            this.DegreeFulltime.Name = "DegreeFulltime";
            this.DegreeFulltime.ReadOnly = true;
            // 
            // EmployerFulltime
            // 
            this.EmployerFulltime.HeaderText = "Employer";
            this.EmployerFulltime.Name = "EmployerFulltime";
            this.EmployerFulltime.ReadOnly = true;
            // 
            // LocationFulltime
            // 
            this.LocationFulltime.HeaderText = "Location";
            this.LocationFulltime.Name = "LocationFulltime";
            this.LocationFulltime.ReadOnly = true;
            // 
            // TitleFulltime
            // 
            this.TitleFulltime.HeaderText = "Title";
            this.TitleFulltime.Name = "TitleFulltime";
            this.TitleFulltime.ReadOnly = true;
            // 
            // StartdateFulltime
            // 
            this.StartdateFulltime.HeaderText = "Start Date";
            this.StartdateFulltime.Name = "StartdateFulltime";
            this.StartdateFulltime.ReadOnly = true;
            // 
            // employerTitle
            // 
            this.employerTitle.AutoSize = true;
            this.employerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employerTitle.ForeColor = System.Drawing.Color.White;
            this.employerTitle.Location = new System.Drawing.Point(716, 399);
            this.employerTitle.Name = "employerTitle";
            this.employerTitle.Size = new System.Drawing.Size(0, 29);
            this.employerTitle.TabIndex = 3;
            // 
            // coopTitle
            // 
            this.coopTitle.AutoSize = true;
            this.coopTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coopTitle.ForeColor = System.Drawing.Color.White;
            this.coopTitle.Location = new System.Drawing.Point(716, 111);
            this.coopTitle.Name = "coopTitle";
            this.coopTitle.Size = new System.Drawing.Size(0, 29);
            this.coopTitle.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(50, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 565);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "map";
            this.label2.Padding = new System.Windows.Forms.Padding(257, 266, 257, 266);
            this.label2.Size = new System.Drawing.Size(574, 561);
            this.label2.TabIndex = 0;
            this.label2.Text = "Map";
            this.label2.Click += new System.EventHandler(this.map_Click);
            // 
            // CareerLocationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.coopTitle);
            this.Controls.Add(this.employerTitle);
            this.Controls.Add(this.EmployerTable);
            this.Controls.Add(this.CoopTable);
            this.Controls.Add(this.label1);
            this.Name = "CareerLocationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CareerLocations";
            ((System.ComponentModel.ISupportInitialize)(this.CoopTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CoopTable;
        private System.Windows.Forms.DataGridView EmployerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DegreeCoop;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployerCoop;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationCoop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TermCoop;
        private System.Windows.Forms.DataGridViewTextBoxColumn DegreeFulltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployerFulltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationFulltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleFulltime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartdateFulltime;
        private System.Windows.Forms.Label employerTitle;
        private System.Windows.Forms.Label coopTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}