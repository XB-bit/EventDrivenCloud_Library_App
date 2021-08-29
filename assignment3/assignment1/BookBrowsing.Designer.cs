
namespace assignment1
{
    partial class BookBrowsing
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
            this.bookViewGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bookViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bookViewGrid
            // 
            this.bookViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookViewGrid.Location = new System.Drawing.Point(22, 83);
            this.bookViewGrid.Name = "bookViewGrid";
            this.bookViewGrid.RowHeadersWidth = 62;
            this.bookViewGrid.RowTemplate.Height = 28;
            this.bookViewGrid.Size = new System.Drawing.Size(1075, 438);
            this.bookViewGrid.TabIndex = 0;
            this.bookViewGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookViewGrid_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // BookBrowsing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookViewGrid);
            this.Name = "BookBrowsing";
            this.Text = "BookBrowsing";
            this.Load += new System.EventHandler(this.BookBrowsing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bookViewGrid;
        private System.Windows.Forms.Label label1;
    }
}