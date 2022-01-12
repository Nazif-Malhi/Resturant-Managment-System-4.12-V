
namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    partial class Category
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
            this.name_TextBox = new System.Windows.Forms.TextBox();
            this.availablity_ComboBox = new System.Windows.Forms.ComboBox();
            this.close_PictureBox = new System.Windows.Forms.PictureBox();
            this.save_PictureBox = new System.Windows.Forms.PictureBox();
            this.cancel_PictureBox = new System.Windows.Forms.PictureBox();
            this.nameErrorlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // name_TextBox
            // 
            this.name_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_TextBox.Location = new System.Drawing.Point(159, 112);
            this.name_TextBox.Name = "name_TextBox";
            this.name_TextBox.Size = new System.Drawing.Size(182, 17);
            this.name_TextBox.TabIndex = 11;
            // 
            // availablity_ComboBox
            // 
            this.availablity_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.availablity_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availablity_ComboBox.FormattingEnabled = true;
            this.availablity_ComboBox.Items.AddRange(new object[] {
            "Available",
            "Not-Available"});
            this.availablity_ComboBox.Location = new System.Drawing.Point(159, 146);
            this.availablity_ComboBox.Name = "availablity_ComboBox";
            this.availablity_ComboBox.Size = new System.Drawing.Size(187, 24);
            this.availablity_ComboBox.TabIndex = 12;
            // 
            // close_PictureBox
            // 
            this.close_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.close_PictureBox.Location = new System.Drawing.Point(354, 11);
            this.close_PictureBox.Name = "close_PictureBox";
            this.close_PictureBox.Size = new System.Drawing.Size(36, 33);
            this.close_PictureBox.TabIndex = 15;
            this.close_PictureBox.TabStop = false;
            this.close_PictureBox.Click += new System.EventHandler(this.close_PictureBox_Click);
            // 
            // save_PictureBox
            // 
            this.save_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.save_PictureBox.Location = new System.Drawing.Point(52, 204);
            this.save_PictureBox.Name = "save_PictureBox";
            this.save_PictureBox.Size = new System.Drawing.Size(123, 33);
            this.save_PictureBox.TabIndex = 14;
            this.save_PictureBox.TabStop = false;
            this.save_PictureBox.Click += new System.EventHandler(this.save_PictureBox_Click);
            // 
            // cancel_PictureBox
            // 
            this.cancel_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.cancel_PictureBox.Location = new System.Drawing.Point(228, 204);
            this.cancel_PictureBox.Name = "cancel_PictureBox";
            this.cancel_PictureBox.Size = new System.Drawing.Size(123, 33);
            this.cancel_PictureBox.TabIndex = 13;
            this.cancel_PictureBox.TabStop = false;
            this.cancel_PictureBox.Click += new System.EventHandler(this.cancel_PictureBox_Click);
            // 
            // nameErrorlabel
            // 
            this.nameErrorlabel.AutoSize = true;
            this.nameErrorlabel.BackColor = System.Drawing.Color.White;
            this.nameErrorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameErrorlabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorlabel.Location = new System.Drawing.Point(359, 109);
            this.nameErrorlabel.Name = "nameErrorlabel";
            this.nameErrorlabel.Size = new System.Drawing.Size(14, 20);
            this.nameErrorlabel.TabIndex = 19;
            this.nameErrorlabel.Text = "!";
            this.nameErrorlabel.Visible = false;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.Categorry;
            this.ClientSize = new System.Drawing.Size(401, 264);
            this.Controls.Add(this.nameErrorlabel);
            this.Controls.Add(this.close_PictureBox);
            this.Controls.Add(this.save_PictureBox);
            this.Controls.Add(this.cancel_PictureBox);
            this.Controls.Add(this.availablity_ComboBox);
            this.Controls.Add(this.name_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            ((System.ComponentModel.ISupportInitialize)(this.close_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancel_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_TextBox;
        private System.Windows.Forms.ComboBox availablity_ComboBox;
        private System.Windows.Forms.PictureBox close_PictureBox;
        private System.Windows.Forms.PictureBox save_PictureBox;
        private System.Windows.Forms.PictureBox cancel_PictureBox;
        private System.Windows.Forms.Label nameErrorlabel;
    }
}