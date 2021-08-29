namespace assignment1
{
    partial class ReserveBook
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
            this.cbbBooks = new System.Windows.Forms.ComboBox();
            this.cbbUsers = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbBooks
            // 
            this.cbbBooks.FormattingEnabled = true;
            this.cbbBooks.Location = new System.Drawing.Point(118, 66);
            this.cbbBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbBooks.Name = "cbbBooks";
            this.cbbBooks.Size = new System.Drawing.Size(289, 28);
            this.cbbBooks.TabIndex = 0;
            // 
            // cbbUsers
            // 
            this.cbbUsers.FormattingEnabled = true;
            this.cbbUsers.Location = new System.Drawing.Point(668, 66);
            this.cbbUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbUsers.Name = "cbbUsers";
            this.cbbUsers.Size = new System.Drawing.Size(294, 28);
            this.cbbUsers.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(476, 145);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name Boook";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "User";
            // 
            // ReserveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 214);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbbUsers);
            this.Controls.Add(this.cbbBooks);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ReserveBook";
            this.Text = "ReserveBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBooks;
        private System.Windows.Forms.ComboBox cbbUsers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}