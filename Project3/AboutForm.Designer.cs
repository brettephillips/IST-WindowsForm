namespace Project3
{
    partial class AboutForm
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
            this.aboutTitle = new System.Windows.Forms.Label();
            this.aboutPnl = new System.Windows.Forms.Panel();
            this.quoteAuthor = new System.Windows.Forms.Label();
            this.aboutQuote = new System.Windows.Forms.RichTextBox();
            this.aboutDescription = new System.Windows.Forms.RichTextBox();
            this.aboutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // aboutTitle
            // 
            this.aboutTitle.AutoSize = true;
            this.aboutTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTitle.ForeColor = System.Drawing.Color.White;
            this.aboutTitle.Location = new System.Drawing.Point(3, 33);
            this.aboutTitle.Name = "aboutTitle";
            this.aboutTitle.Padding = new System.Windows.Forms.Padding(374, 0, 374, 0);
            this.aboutTitle.Size = new System.Drawing.Size(748, 37);
            this.aboutTitle.TabIndex = 0;
            // 
            // aboutPnl
            // 
            this.aboutPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.aboutPnl.Controls.Add(this.quoteAuthor);
            this.aboutPnl.Controls.Add(this.aboutQuote);
            this.aboutPnl.Controls.Add(this.aboutDescription);
            this.aboutPnl.Location = new System.Drawing.Point(50, 111);
            this.aboutPnl.Name = "aboutPnl";
            this.aboutPnl.Size = new System.Drawing.Size(1243, 561);
            this.aboutPnl.TabIndex = 1;
            // 
            // quoteAuthor
            // 
            this.quoteAuthor.AutoSize = true;
            this.quoteAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quoteAuthor.ForeColor = System.Drawing.Color.White;
            this.quoteAuthor.Location = new System.Drawing.Point(68, 446);
            this.quoteAuthor.Name = "quoteAuthor";
            this.quoteAuthor.Size = new System.Drawing.Size(0, 20);
            this.quoteAuthor.TabIndex = 2;
            // 
            // aboutQuote
            // 
            this.aboutQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.aboutQuote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutQuote.ForeColor = System.Drawing.Color.White;
            this.aboutQuote.Location = new System.Drawing.Point(72, 305);
            this.aboutQuote.Name = "aboutQuote";
            this.aboutQuote.ReadOnly = true;
            this.aboutQuote.Size = new System.Drawing.Size(1096, 138);
            this.aboutQuote.TabIndex = 1;
            this.aboutQuote.Text = "";
            // 
            // aboutDescription
            // 
            this.aboutDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(110)))), ((int)(((byte)(33)))));
            this.aboutDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aboutDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutDescription.ForeColor = System.Drawing.Color.White;
            this.aboutDescription.Location = new System.Drawing.Point(72, 103);
            this.aboutDescription.Name = "aboutDescription";
            this.aboutDescription.ReadOnly = true;
            this.aboutDescription.Size = new System.Drawing.Size(1096, 138);
            this.aboutDescription.TabIndex = 0;
            this.aboutDescription.Text = "";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.aboutPnl);
            this.Controls.Add(this.aboutTitle);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.aboutPnl.ResumeLayout(false);
            this.aboutPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutTitle;
        private System.Windows.Forms.Panel aboutPnl;
        private System.Windows.Forms.Label quoteAuthor;
        private System.Windows.Forms.RichTextBox aboutQuote;
        private System.Windows.Forms.RichTextBox aboutDescription;
    }
}