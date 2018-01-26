namespace Project3
{
    partial class NewsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.newsContent = new System.Windows.Forms.RichTextBox();
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
            this.label1.Padding = new System.Windows.Forms.Padding(624, 0, 624, 0);
            this.label1.Size = new System.Drawing.Size(1345, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "News";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.newsContent);
            this.panel1.Location = new System.Drawing.Point(50, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 561);
            this.panel1.TabIndex = 1;
            // 
            // newsContent
            // 
            this.newsContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.newsContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newsContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsContent.ForeColor = System.Drawing.Color.White;
            this.newsContent.Location = new System.Drawing.Point(3, 3);
            this.newsContent.Name = "newsContent";
            this.newsContent.ReadOnly = true;
            this.newsContent.Size = new System.Drawing.Size(1244, 555);
            this.newsContent.TabIndex = 0;
            this.newsContent.Text = "";
            // 
            // NewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "NewsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "News";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox newsContent;
    }
}