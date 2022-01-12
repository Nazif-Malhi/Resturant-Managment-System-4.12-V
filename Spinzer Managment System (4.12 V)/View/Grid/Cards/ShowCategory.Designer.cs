
namespace Spinzer_Managment_System__4._12_V_.View.Grid.Cards
{
    partial class ShowCategory
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
            this.categoryName_Label = new System.Windows.Forms.Label();
            this.avaulability_Label = new System.Windows.Forms.Label();
            this.delete_PictureBox = new System.Windows.Forms.PictureBox();
            this.update_PictureBox = new System.Windows.Forms.PictureBox();
            this.id_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryName_Label
            // 
            this.categoryName_Label.AutoSize = true;
            this.categoryName_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryName_Label.ForeColor = System.Drawing.Color.White;
            this.categoryName_Label.Location = new System.Drawing.Point(26, 111);
            this.categoryName_Label.Name = "categoryName_Label";
            this.categoryName_Label.Size = new System.Drawing.Size(53, 25);
            this.categoryName_Label.TabIndex = 8;
            this.categoryName_Label.Text = "label";
            // 
            // avaulability_Label
            // 
            this.avaulability_Label.AutoSize = true;
            this.avaulability_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avaulability_Label.ForeColor = System.Drawing.Color.White;
            this.avaulability_Label.Location = new System.Drawing.Point(27, 183);
            this.avaulability_Label.Name = "avaulability_Label";
            this.avaulability_Label.Size = new System.Drawing.Size(97, 21);
            this.avaulability_Label.TabIndex = 16;
            this.avaulability_Label.Text = "@gmail.com";
            // 
            // delete_PictureBox
            // 
            this.delete_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btnDataGrid_Delete;
            this.delete_PictureBox.Location = new System.Drawing.Point(115, 228);
            this.delete_PictureBox.Name = "delete_PictureBox";
            this.delete_PictureBox.Size = new System.Drawing.Size(95, 37);
            this.delete_PictureBox.TabIndex = 18;
            this.delete_PictureBox.TabStop = false;
            this.delete_PictureBox.Click += new System.EventHandler(this.delete_PictureBox_Click);
            this.delete_PictureBox.MouseEnter += new System.EventHandler(this.delete_PictureBox_MouseEnter);
            this.delete_PictureBox.MouseLeave += new System.EventHandler(this.delete_PictureBox_MouseLeave);
            // 
            // update_PictureBox
            // 
            this.update_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.update_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btnDataGrid_Update;
            this.update_PictureBox.Location = new System.Drawing.Point(13, 228);
            this.update_PictureBox.Name = "update_PictureBox";
            this.update_PictureBox.Size = new System.Drawing.Size(97, 37);
            this.update_PictureBox.TabIndex = 17;
            this.update_PictureBox.TabStop = false;
            this.update_PictureBox.Click += new System.EventHandler(this.update_PictureBox_Click);
            this.update_PictureBox.MouseEnter += new System.EventHandler(this.update_PictureBox_MouseEnter);
            this.update_PictureBox.MouseLeave += new System.EventHandler(this.update_PictureBox_MouseLeave);
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.White;
            this.id_label.Location = new System.Drawing.Point(59, 54);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(17, 15);
            this.id_label.TabIndex = 19;
            this.id_label.Text = "id";
            this.id_label.Visible = false;
            // 
            // ShowCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.CategoryCardPic;
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.delete_PictureBox);
            this.Controls.Add(this.update_PictureBox);
            this.Controls.Add(this.avaulability_Label);
            this.Controls.Add(this.categoryName_Label);
            this.Name = "ShowCategory";
            this.Size = new System.Drawing.Size(221, 272);
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label categoryName_Label;
        public System.Windows.Forms.Label avaulability_Label;
        public System.Windows.Forms.PictureBox delete_PictureBox;
        public System.Windows.Forms.PictureBox update_PictureBox;
        public System.Windows.Forms.Label id_label;
    }
}
