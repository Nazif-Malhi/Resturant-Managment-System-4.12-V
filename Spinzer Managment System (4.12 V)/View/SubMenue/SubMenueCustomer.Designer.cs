
namespace Spinzer_Managment_System__4._12_V_.View.SubMenue
{
    partial class SubMenueCustomer
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
            this.newCustomer_PictureBox = new System.Windows.Forms.PictureBox();
            this.allCustomer_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newCustomer_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCustomer_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newCustomer_PictureBox
            // 
            this.newCustomer_PictureBox.Location = new System.Drawing.Point(44, 17);
            this.newCustomer_PictureBox.Name = "newCustomer_PictureBox";
            this.newCustomer_PictureBox.Size = new System.Drawing.Size(100, 25);
            this.newCustomer_PictureBox.TabIndex = 0;
            this.newCustomer_PictureBox.TabStop = false;
            this.newCustomer_PictureBox.Click += new System.EventHandler(this.newCustomer_PictureBox_Click);
            // 
            // allCustomer_PictureBox
            // 
            this.allCustomer_PictureBox.Location = new System.Drawing.Point(44, 48);
            this.allCustomer_PictureBox.Name = "allCustomer_PictureBox";
            this.allCustomer_PictureBox.Size = new System.Drawing.Size(100, 25);
            this.allCustomer_PictureBox.TabIndex = 1;
            this.allCustomer_PictureBox.TabStop = false;
            // 
            // SubMenueCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.CustomerSubMenue;
            this.Controls.Add(this.allCustomer_PictureBox);
            this.Controls.Add(this.newCustomer_PictureBox);
            this.Name = "SubMenueCustomer";
            this.Size = new System.Drawing.Size(170, 92);
            ((System.ComponentModel.ISupportInitialize)(this.newCustomer_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allCustomer_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox allCustomer_PictureBox;
        public System.Windows.Forms.PictureBox newCustomer_PictureBox;
    }
}
