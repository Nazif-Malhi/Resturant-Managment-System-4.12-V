
namespace Spinzer_Managment_System__4._12_V_.View.SubMenue
{
    partial class SubMenueStock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newStock_PictureBox = new System.Windows.Forms.PictureBox();
            this.allStock_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newStock_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStock_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newStock_PictureBox
            // 
            this.newStock_PictureBox.Location = new System.Drawing.Point(45, 16);
            this.newStock_PictureBox.Name = "newStock_PictureBox";
            this.newStock_PictureBox.Size = new System.Drawing.Size(100, 25);
            this.newStock_PictureBox.TabIndex = 0;
            this.newStock_PictureBox.TabStop = false;
            this.newStock_PictureBox.Click += new System.EventHandler(this.newStock_PictureBox_Click);
            // 
            // allStock_pictureBox
            // 
            this.allStock_pictureBox.Location = new System.Drawing.Point(45, 50);
            this.allStock_pictureBox.Name = "allStock_pictureBox";
            this.allStock_pictureBox.Size = new System.Drawing.Size(100, 25);
            this.allStock_pictureBox.TabIndex = 1;
            this.allStock_pictureBox.TabStop = false;
            // 
            // SubMenueStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.StockSubMenue;
            this.Controls.Add(this.allStock_pictureBox);
            this.Controls.Add(this.newStock_PictureBox);
            this.Name = "SubMenueStock";
            this.Size = new System.Drawing.Size(170, 92);
            ((System.ComponentModel.ISupportInitialize)(this.newStock_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allStock_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox newStock_PictureBox;
        public System.Windows.Forms.PictureBox allStock_pictureBox;
    }
}
