
namespace Spinzer_Managment_System__4._12_V_.View.SubMenue
{
    partial class SubMenueFood
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
            this.newCategory_PictureBox = new System.Windows.Forms.PictureBox();
            this.AllCategory_pictureBox = new System.Windows.Forms.PictureBox();
            this.newItem_PictureBox = new System.Windows.Forms.PictureBox();
            this.allItems_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newCategory_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCategory_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newItem_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allItems_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newCategory_PictureBox
            // 
            this.newCategory_PictureBox.Location = new System.Drawing.Point(46, 15);
            this.newCategory_PictureBox.Name = "newCategory_PictureBox";
            this.newCategory_PictureBox.Size = new System.Drawing.Size(100, 25);
            this.newCategory_PictureBox.TabIndex = 0;
            this.newCategory_PictureBox.TabStop = false;
            this.newCategory_PictureBox.Click += new System.EventHandler(this.newCategory_PictureBox_Click);
            // 
            // AllCategory_pictureBox
            // 
            this.AllCategory_pictureBox.Location = new System.Drawing.Point(46, 49);
            this.AllCategory_pictureBox.Name = "AllCategory_pictureBox";
            this.AllCategory_pictureBox.Size = new System.Drawing.Size(100, 25);
            this.AllCategory_pictureBox.TabIndex = 1;
            this.AllCategory_pictureBox.TabStop = false;
            // 
            // newItem_PictureBox
            // 
            this.newItem_PictureBox.Location = new System.Drawing.Point(46, 82);
            this.newItem_PictureBox.Name = "newItem_PictureBox";
            this.newItem_PictureBox.Size = new System.Drawing.Size(100, 25);
            this.newItem_PictureBox.TabIndex = 2;
            this.newItem_PictureBox.TabStop = false;
            this.newItem_PictureBox.Click += new System.EventHandler(this.newItem_PictureBox_Click);
            // 
            // allItems_PictureBox
            // 
            this.allItems_PictureBox.Location = new System.Drawing.Point(46, 115);
            this.allItems_PictureBox.Name = "allItems_PictureBox";
            this.allItems_PictureBox.Size = new System.Drawing.Size(100, 25);
            this.allItems_PictureBox.TabIndex = 3;
            this.allItems_PictureBox.TabStop = false;
            // 
            // SubMenueFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.FoodSubMenue;
            this.Controls.Add(this.allItems_PictureBox);
            this.Controls.Add(this.newItem_PictureBox);
            this.Controls.Add(this.AllCategory_pictureBox);
            this.Controls.Add(this.newCategory_PictureBox);
            this.Name = "SubMenueFood";
            this.Size = new System.Drawing.Size(170, 158);
            ((System.ComponentModel.ISupportInitialize)(this.newCategory_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllCategory_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newItem_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allItems_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox AllCategory_pictureBox;
        public System.Windows.Forms.PictureBox allItems_PictureBox;
        public System.Windows.Forms.PictureBox newCategory_PictureBox;
        public System.Windows.Forms.PictureBox newItem_PictureBox;
    }
}
