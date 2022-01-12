
namespace Spinzer_Managment_System__4._12_V_.View.SubMenue
{
    partial class SubMenueDeals
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
            this.newDeals_PictureBox = new System.Windows.Forms.PictureBox();
            this.allDeals_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newDeals_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDeals_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newDeals_PictureBox
            // 
            this.newDeals_PictureBox.Location = new System.Drawing.Point(23, 12);
            this.newDeals_PictureBox.Name = "newDeals_PictureBox";
            this.newDeals_PictureBox.Size = new System.Drawing.Size(142, 29);
            this.newDeals_PictureBox.TabIndex = 0;
            this.newDeals_PictureBox.TabStop = false;
            this.newDeals_PictureBox.Click += new System.EventHandler(this.newDeals_PictureBox_Click);
            // 
            // allDeals_PictureBox
            // 
            this.allDeals_PictureBox.Location = new System.Drawing.Point(23, 49);
            this.allDeals_PictureBox.Name = "allDeals_PictureBox";
            this.allDeals_PictureBox.Size = new System.Drawing.Size(142, 29);
            this.allDeals_PictureBox.TabIndex = 1;
            this.allDeals_PictureBox.TabStop = false;
            // 
            // SubMenueDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.DealsSubMenue;
            this.Controls.Add(this.allDeals_PictureBox);
            this.Controls.Add(this.newDeals_PictureBox);
            this.Name = "SubMenueDeals";
            this.Size = new System.Drawing.Size(170, 92);
            ((System.ComponentModel.ISupportInitialize)(this.newDeals_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDeals_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox newDeals_PictureBox;
        public System.Windows.Forms.PictureBox allDeals_PictureBox;
    }
}
