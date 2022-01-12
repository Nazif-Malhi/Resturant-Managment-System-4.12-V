
namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    partial class Reports
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
            this.dailyReport_PictureBox = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dailyReport_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // dailyReport_PictureBox
            // 
            this.dailyReport_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dailyReport_PictureBox.Location = new System.Drawing.Point(38, 91);
            this.dailyReport_PictureBox.Name = "dailyReport_PictureBox";
            this.dailyReport_PictureBox.Size = new System.Drawing.Size(170, 118);
            this.dailyReport_PictureBox.TabIndex = 0;
            this.dailyReport_PictureBox.TabStop = false;
            this.dailyReport_PictureBox.Click += new System.EventHandler(this.dailyReport_PictureBox_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Location = new System.Drawing.Point(461, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(40, 41);
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.Reports;
            this.ClientSize = new System.Drawing.Size(513, 295);
            this.Controls.Add(this.close);
            this.Controls.Add(this.dailyReport_PictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            ((System.ComponentModel.ISupportInitialize)(this.dailyReport_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox dailyReport_PictureBox;
        private System.Windows.Forms.PictureBox close;
    }
}