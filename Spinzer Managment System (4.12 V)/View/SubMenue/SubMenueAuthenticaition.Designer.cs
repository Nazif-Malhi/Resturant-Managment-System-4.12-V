
namespace Spinzer_Managment_System__4._12_V_.View.SubMenue
{
    partial class SubMenueAuthenticaition
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
            this.newUser_PictureBox = new System.Windows.Forms.PictureBox();
            this.allUser_PictureBox = new System.Windows.Forms.PictureBox();
            this.allEmployee_PictureBox = new System.Windows.Forms.PictureBox();
            this.newEmployee_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.newUser_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allUser_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployee_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployee_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // newUser_PictureBox
            // 
            this.newUser_PictureBox.Location = new System.Drawing.Point(21, 13);
            this.newUser_PictureBox.Name = "newUser_PictureBox";
            this.newUser_PictureBox.Size = new System.Drawing.Size(144, 30);
            this.newUser_PictureBox.TabIndex = 0;
            this.newUser_PictureBox.TabStop = false;
            this.newUser_PictureBox.Click += new System.EventHandler(this.newUser_PictureBox_Click);
            // 
            // allUser_PictureBox
            // 
            this.allUser_PictureBox.Location = new System.Drawing.Point(21, 47);
            this.allUser_PictureBox.Name = "allUser_PictureBox";
            this.allUser_PictureBox.Size = new System.Drawing.Size(144, 30);
            this.allUser_PictureBox.TabIndex = 1;
            this.allUser_PictureBox.TabStop = false;
            // 
            // allEmployee_PictureBox
            // 
            this.allEmployee_PictureBox.Location = new System.Drawing.Point(21, 112);
            this.allEmployee_PictureBox.Name = "allEmployee_PictureBox";
            this.allEmployee_PictureBox.Size = new System.Drawing.Size(144, 31);
            this.allEmployee_PictureBox.TabIndex = 3;
            this.allEmployee_PictureBox.TabStop = false;
            // 
            // newEmployee_PictureBox
            // 
            this.newEmployee_PictureBox.Location = new System.Drawing.Point(21, 82);
            this.newEmployee_PictureBox.Name = "newEmployee_PictureBox";
            this.newEmployee_PictureBox.Size = new System.Drawing.Size(144, 30);
            this.newEmployee_PictureBox.TabIndex = 2;
            this.newEmployee_PictureBox.TabStop = false;
            this.newEmployee_PictureBox.Click += new System.EventHandler(this.newEmployee_PictureBox_Click);
            // 
            // SubMenueAuthenticaition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.AuthentcationSubMenue;
            this.Controls.Add(this.allEmployee_PictureBox);
            this.Controls.Add(this.newEmployee_PictureBox);
            this.Controls.Add(this.allUser_PictureBox);
            this.Controls.Add(this.newUser_PictureBox);
            this.Name = "SubMenueAuthenticaition";
            this.Size = new System.Drawing.Size(170, 158);
            ((System.ComponentModel.ISupportInitialize)(this.newUser_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allUser_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployee_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmployee_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox allUser_PictureBox;
        public System.Windows.Forms.PictureBox allEmployee_PictureBox;
        public System.Windows.Forms.PictureBox newUser_PictureBox;
        public System.Windows.Forms.PictureBox newEmployee_PictureBox;
    }
}
