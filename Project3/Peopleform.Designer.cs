namespace Project3
{
    partial class PeopleForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.facultyList = new System.Windows.Forms.ListBox();
            this.staffList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.facultyLbl = new System.Windows.Forms.Label();
            this.staffLbl = new System.Windows.Forms.Label();
            this.personContent = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(3, 33);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Padding = new System.Windows.Forms.Padding(583, 0, 583, 0);
            this.titleLbl.Size = new System.Drawing.Size(1166, 37);
            this.titleLbl.TabIndex = 0;
            // 
            // facultyList
            // 
            this.facultyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.facultyList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facultyList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyList.ForeColor = System.Drawing.Color.White;
            this.facultyList.FormattingEnabled = true;
            this.facultyList.ItemHeight = 24;
            this.facultyList.Location = new System.Drawing.Point(50, 143);
            this.facultyList.Name = "facultyList";
            this.facultyList.Size = new System.Drawing.Size(580, 240);
            this.facultyList.TabIndex = 1;
            this.facultyList.SelectedIndexChanged += new System.EventHandler(this.facultyList_SelectedIndexChanged);
            // 
            // staffList
            // 
            this.staffList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.staffList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffList.ForeColor = System.Drawing.Color.White;
            this.staffList.FormattingEnabled = true;
            this.staffList.ItemHeight = 24;
            this.staffList.Location = new System.Drawing.Point(50, 435);
            this.staffList.Name = "staffList";
            this.staffList.Size = new System.Drawing.Size(580, 240);
            this.staffList.TabIndex = 2;
            this.staffList.SelectedIndexChanged += new System.EventHandler(this.staffList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.personContent);
            this.panel1.Location = new System.Drawing.Point(721, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 564);
            this.panel1.TabIndex = 3;
            // 
            // facultyLbl
            // 
            this.facultyLbl.AutoSize = true;
            this.facultyLbl.BackColor = System.Drawing.Color.Black;
            this.facultyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facultyLbl.ForeColor = System.Drawing.Color.White;
            this.facultyLbl.Location = new System.Drawing.Point(45, 111);
            this.facultyLbl.Name = "facultyLbl";
            this.facultyLbl.Size = new System.Drawing.Size(89, 29);
            this.facultyLbl.TabIndex = 4;
            this.facultyLbl.Text = "Faculty";
            // 
            // staffLbl
            // 
            this.staffLbl.AutoSize = true;
            this.staffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.staffLbl.ForeColor = System.Drawing.Color.White;
            this.staffLbl.Location = new System.Drawing.Point(45, 403);
            this.staffLbl.Name = "staffLbl";
            this.staffLbl.Size = new System.Drawing.Size(60, 29);
            this.staffLbl.TabIndex = 5;
            this.staffLbl.Text = "Staff";
            // 
            // personContent
            // 
            this.personContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.personContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personContent.ForeColor = System.Drawing.Color.White;
            this.personContent.Location = new System.Drawing.Point(3, 3);
            this.personContent.Name = "personContent";
            this.personContent.Size = new System.Drawing.Size(574, 558);
            this.personContent.TabIndex = 0;
            this.personContent.Text = "";
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.staffLbl);
            this.Controls.Add(this.facultyLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.staffList);
            this.Controls.Add(this.facultyList);
            this.Controls.Add(this.titleLbl);
            this.Name = "PeopleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "People";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.ListBox facultyList;
        private System.Windows.Forms.ListBox staffList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label facultyLbl;
        private System.Windows.Forms.Label staffLbl;
        private System.Windows.Forms.RichTextBox personContent;
    }
}