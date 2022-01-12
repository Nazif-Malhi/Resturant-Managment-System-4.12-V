
namespace Spinzer_Managment_System__4._12_V_.View.Grid.Base
{
    partial class GetCustomerDataGrid
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.range_Label = new System.Windows.Forms.Label();
            this.forward_Picturebox = new System.Windows.Forms.PictureBox();
            this.backward_PictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forward_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backward_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(66)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.range_Label);
            this.panel1.Controls.Add(this.forward_Picturebox);
            this.panel1.Controls.Add(this.backward_PictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 631);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 50);
            this.panel1.TabIndex = 0;
            // 
            // range_Label
            // 
            this.range_Label.AutoSize = true;
            this.range_Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.range_Label.ForeColor = System.Drawing.Color.White;
            this.range_Label.Location = new System.Drawing.Point(471, 14);
            this.range_Label.Name = "range_Label";
            this.range_Label.Size = new System.Drawing.Size(74, 25);
            this.range_Label.TabIndex = 2;
            this.range_Label.Text = "1 . . . 20";
            // 
            // forward_Picturebox
            // 
            this.forward_Picturebox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.Forward;
            this.forward_Picturebox.Location = new System.Drawing.Point(573, 9);
            this.forward_Picturebox.Name = "forward_Picturebox";
            this.forward_Picturebox.Size = new System.Drawing.Size(35, 32);
            this.forward_Picturebox.TabIndex = 1;
            this.forward_Picturebox.TabStop = false;
            this.forward_Picturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.forward_Picturebox_MouseDown);
            // 
            // backward_PictureBox
            // 
            this.backward_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.Backward;
            this.backward_PictureBox.Location = new System.Drawing.Point(400, 9);
            this.backward_PictureBox.Name = "backward_PictureBox";
            this.backward_PictureBox.Size = new System.Drawing.Size(35, 32);
            this.backward_PictureBox.TabIndex = 0;
            this.backward_PictureBox.TabStop = false;
            this.backward_PictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.backward_PictureBox_MouseDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1091, 631);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // GetCustomerDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "GetCustomerDataGrid";
            this.Size = new System.Drawing.Size(1091, 681);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.forward_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backward_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox forward_Picturebox;
        private System.Windows.Forms.PictureBox backward_PictureBox;
        private System.Windows.Forms.Label range_Label;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
