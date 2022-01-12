
namespace Spinzer_Managment_System__4._12_V_.View.Grid.Cards
{
    partial class ShowDeals
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
            this.delete_PictureBox = new System.Windows.Forms.PictureBox();
            this.update_PictureBox = new System.Windows.Forms.PictureBox();
            this.name_Label = new System.Windows.Forms.Label();
            this.totalPrice_label = new System.Windows.Forms.Label();
            this.totalItems_Label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // delete_PictureBox
            // 
            this.delete_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btnDataGrid_Delete;
            this.delete_PictureBox.Location = new System.Drawing.Point(119, 204);
            this.delete_PictureBox.Name = "delete_PictureBox";
            this.delete_PictureBox.Size = new System.Drawing.Size(95, 37);
            this.delete_PictureBox.TabIndex = 20;
            this.delete_PictureBox.TabStop = false;
            this.delete_PictureBox.Click += new System.EventHandler(this.delete_PictureBox_Click);
            this.delete_PictureBox.MouseEnter += new System.EventHandler(this.delete_PictureBox_MouseEnter);
            this.delete_PictureBox.MouseLeave += new System.EventHandler(this.delete_PictureBox_MouseLeave);
            // 
            // update_PictureBox
            // 
            this.update_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.update_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btnDataGrid_Update;
            this.update_PictureBox.Location = new System.Drawing.Point(17, 204);
            this.update_PictureBox.Name = "update_PictureBox";
            this.update_PictureBox.Size = new System.Drawing.Size(97, 37);
            this.update_PictureBox.TabIndex = 19;
            this.update_PictureBox.TabStop = false;
            this.update_PictureBox.Click += new System.EventHandler(this.update_PictureBox_Click);
            this.update_PictureBox.MouseEnter += new System.EventHandler(this.update_PictureBox_MouseEnter);
            this.update_PictureBox.MouseLeave += new System.EventHandler(this.update_PictureBox_MouseLeave);
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Label.Location = new System.Drawing.Point(72, 21);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(63, 25);
            this.name_Label.TabIndex = 21;
            this.name_Label.Text = "label1";
            // 
            // totalPrice_label
            // 
            this.totalPrice_label.AutoSize = true;
            this.totalPrice_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPrice_label.Location = new System.Drawing.Point(41, 157);
            this.totalPrice_label.Name = "totalPrice_label";
            this.totalPrice_label.Size = new System.Drawing.Size(44, 21);
            this.totalPrice_label.TabIndex = 22;
            this.totalPrice_label.Text = "Price";
            // 
            // totalItems_Label
            // 
            this.totalItems_Label.AutoSize = true;
            this.totalItems_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItems_Label.Location = new System.Drawing.Point(22, 94);
            this.totalItems_Label.Name = "totalItems_Label";
            this.totalItems_Label.Size = new System.Drawing.Size(102, 25);
            this.totalItems_Label.TabIndex = 23;
            this.totalItems_Label.Text = "Total Items";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_label.ForeColor = System.Drawing.Color.Black;
            this.id_label.Location = new System.Drawing.Point(170, 21);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(17, 15);
            this.id_label.TabIndex = 24;
            this.id_label.Text = "id";
            this.id_label.Visible = false;
            // 
            // ShowDeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(0)))));
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.totalItems_Label);
            this.Controls.Add(this.totalPrice_label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.delete_PictureBox);
            this.Controls.Add(this.update_PictureBox);
            this.Name = "ShowDeals";
            this.Size = new System.Drawing.Size(229, 244);
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox delete_PictureBox;
        public System.Windows.Forms.PictureBox update_PictureBox;
        public System.Windows.Forms.Label name_Label;
        public System.Windows.Forms.Label totalPrice_label;
        public System.Windows.Forms.Label totalItems_Label;
        public System.Windows.Forms.Label id_label;
    }
}
