
namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    partial class DeletingStock
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
            this.close_PictureBox = new System.Windows.Forms.PictureBox();
            this.delete_PictureBox = new System.Windows.Forms.PictureBox();
            this.cancel_PictureBox = new System.Windows.Forms.PictureBox();
            this.name_ComboBox = new System.Windows.Forms.ComboBox();
            this.nameErrorlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // close_PictureBox
            // 
            this.close_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.close_PictureBox.Location = new System.Drawing.Point(353, 10);
            this.close_PictureBox.Name = "close_PictureBox";
            this.close_PictureBox.Size = new System.Drawing.Size(36, 33);
            this.close_PictureBox.TabIndex = 50;
            this.close_PictureBox.TabStop = false;
            this.close_PictureBox.Click += new System.EventHandler(this.close_PictureBox_Click);
            // 
            // delete_PictureBox
            // 
            this.delete_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.delete_PictureBox.Location = new System.Drawing.Point(52, 165);
            this.delete_PictureBox.Name = "delete_PictureBox";
            this.delete_PictureBox.Size = new System.Drawing.Size(123, 33);
            this.delete_PictureBox.TabIndex = 53;
            this.delete_PictureBox.TabStop = false;
            this.delete_PictureBox.Click += new System.EventHandler(this.delete_PictureBox_Click);
            // 
            // cancel_PictureBox
            // 
            this.cancel_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.cancel_PictureBox.Location = new System.Drawing.Point(228, 165);
            this.cancel_PictureBox.Name = "cancel_PictureBox";
            this.cancel_PictureBox.Size = new System.Drawing.Size(123, 33);
            this.cancel_PictureBox.TabIndex = 52;
            this.cancel_PictureBox.TabStop = false;
            this.cancel_PictureBox.Click += new System.EventHandler(this.cancel_PictureBox_Click);
            // 
            // name_ComboBox
            // 
            this.name_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.name_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.name_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_ComboBox.FormattingEnabled = true;
            this.name_ComboBox.Location = new System.Drawing.Point(136, 109);
            this.name_ComboBox.Name = "name_ComboBox";
            this.name_ComboBox.Size = new System.Drawing.Size(187, 24);
            this.name_ComboBox.TabIndex = 54;
            // 
            // nameErrorlabel
            // 
            this.nameErrorlabel.AutoSize = true;
            this.nameErrorlabel.BackColor = System.Drawing.Color.White;
            this.nameErrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorlabel.Location = new System.Drawing.Point(334, 111);
            this.nameErrorlabel.Name = "nameErrorlabel";
            this.nameErrorlabel.Size = new System.Drawing.Size(14, 20);
            this.nameErrorlabel.TabIndex = 55;
            this.nameErrorlabel.Text = "!";
            this.nameErrorlabel.Visible = false;
            // 
            // DeletingStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.DeletingStock;
            this.ClientSize = new System.Drawing.Size(401, 228);
            this.Controls.Add(this.name_ComboBox);
            this.Controls.Add(this.nameErrorlabel);
            this.Controls.Add(this.delete_PictureBox);
            this.Controls.Add(this.cancel_PictureBox);
            this.Controls.Add(this.close_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeletingStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeletingStock";
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox close_PictureBox;
        private System.Windows.Forms.PictureBox delete_PictureBox;
        private System.Windows.Forms.PictureBox cancel_PictureBox;
        private System.Windows.Forms.ComboBox name_ComboBox;
        private System.Windows.Forms.Label nameErrorlabel;
    }
}