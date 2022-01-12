
namespace Spinzer_Managment_System__4._12_V_.View.StartUp_Autherization_Controll
{
    partial class ForgetPassword
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
            this.mail_TextBox = new System.Windows.Forms.TextBox();
            this.sendReqxt_PictureBox = new System.Windows.Forms.PictureBox();
            this.logIn_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sendReqxt_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mail_TextBox
            // 
            this.mail_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mail_TextBox.Enabled = false;
            this.mail_TextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mail_TextBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.mail_TextBox.Location = new System.Drawing.Point(880, 293);
            this.mail_TextBox.Name = "mail_TextBox";
            this.mail_TextBox.Size = new System.Drawing.Size(304, 22);
            this.mail_TextBox.TabIndex = 9;
            this.mail_TextBox.Text = "Email @ Account .Com";
            // 
            // sendReqxt_PictureBox
            // 
            this.sendReqxt_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.sendReqxt_PictureBox.Location = new System.Drawing.Point(939, 359);
            this.sendReqxt_PictureBox.Name = "sendReqxt_PictureBox";
            this.sendReqxt_PictureBox.Size = new System.Drawing.Size(190, 43);
            this.sendReqxt_PictureBox.TabIndex = 10;
            this.sendReqxt_PictureBox.TabStop = false;
            this.sendReqxt_PictureBox.Click += new System.EventHandler(this.sendReqxt_PictureBox_Click);
            // 
            // logIn_Label
            // 
            this.logIn_Label.AutoSize = true;
            this.logIn_Label.BackColor = System.Drawing.Color.Transparent;
            this.logIn_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logIn_Label.Location = new System.Drawing.Point(997, 434);
            this.logIn_Label.Name = "logIn_Label";
            this.logIn_Label.Size = new System.Drawing.Size(71, 30);
            this.logIn_Label.TabIndex = 11;
            this.logIn_Label.Text = "Log In";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.Forgot_your_password;
            this.Controls.Add(this.logIn_Label);
            this.Controls.Add(this.sendReqxt_PictureBox);
            this.Controls.Add(this.mail_TextBox);
            this.DoubleBuffered = true;
            this.Name = "ForgetPassword";
            this.Size = new System.Drawing.Size(1350, 750);
            ((System.ComponentModel.ISupportInitialize)(this.sendReqxt_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox mail_TextBox;
        private System.Windows.Forms.PictureBox sendReqxt_PictureBox;
        public System.Windows.Forms.Label logIn_Label;
    }
}
