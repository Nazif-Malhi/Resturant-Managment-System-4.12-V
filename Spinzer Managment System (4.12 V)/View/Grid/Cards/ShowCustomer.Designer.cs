
namespace Spinzer_Managment_System__4._12_V_.View.Grid.Cards
{
    partial class ShowCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCustomer));
            this.employeeName_Label = new System.Windows.Forms.Label();
            this.address_Label = new System.Windows.Forms.Label();
            this.email_Label = new System.Windows.Forms.Label();
            this.phone_Label = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.qR_PictureBox = new System.Windows.Forms.PictureBox();
            this.delete_PictureBox = new System.Windows.Forms.PictureBox();
            this.update_PictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qR_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeName_Label
            // 
            this.employeeName_Label.AutoSize = true;
            this.employeeName_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName_Label.Location = new System.Drawing.Point(186, 25);
            this.employeeName_Label.Name = "employeeName_Label";
            this.employeeName_Label.Size = new System.Drawing.Size(53, 25);
            this.employeeName_Label.TabIndex = 7;
            this.employeeName_Label.Text = "label";
            // 
            // address_Label
            // 
            this.address_Label.AutoSize = true;
            this.address_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_Label.Location = new System.Drawing.Point(3, 0);
            this.address_Label.Name = "address_Label";
            this.address_Label.Size = new System.Drawing.Size(64, 21);
            this.address_Label.TabIndex = 12;
            this.address_Label.Text = "address";
            // 
            // email_Label
            // 
            this.email_Label.AutoSize = true;
            this.email_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_Label.Location = new System.Drawing.Point(512, 139);
            this.email_Label.Name = "email_Label";
            this.email_Label.Size = new System.Drawing.Size(97, 21);
            this.email_Label.TabIndex = 15;
            this.email_Label.Text = "@gmail.com";
            // 
            // phone_Label
            // 
            this.phone_Label.AutoSize = true;
            this.phone_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone_Label.Location = new System.Drawing.Point(512, 173);
            this.phone_Label.Name = "phone_Label";
            this.phone_Label.Size = new System.Drawing.Size(52, 21);
            this.phone_Label.TabIndex = 13;
            this.phone_Label.Text = "02-12";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(864, 173);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(97, 21);
            this.idLabel.TabIndex = 13;
            this.idLabel.Text = "ID Customer";
            this.idLabel.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.address_Label);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(433, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(349, 71);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // qR_PictureBox
            // 
            this.qR_PictureBox.Location = new System.Drawing.Point(191, 97);
            this.qR_PictureBox.Name = "qR_PictureBox";
            this.qR_PictureBox.Size = new System.Drawing.Size(100, 100);
            this.qR_PictureBox.TabIndex = 5;
            this.qR_PictureBox.TabStop = false;
            // 
            // delete_PictureBox
            // 
            this.delete_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btn_deleteLibrary;
            this.delete_PictureBox.Location = new System.Drawing.Point(829, 105);
            this.delete_PictureBox.Name = "delete_PictureBox";
            this.delete_PictureBox.Size = new System.Drawing.Size(144, 50);
            this.delete_PictureBox.TabIndex = 2;
            this.delete_PictureBox.TabStop = false;
            this.delete_PictureBox.Click += new System.EventHandler(this.delete_PictureBox_Click);
            this.delete_PictureBox.MouseEnter += new System.EventHandler(this.delete_PictureBox_MouseEnter);
            this.delete_PictureBox.MouseLeave += new System.EventHandler(this.delete_PictureBox_MouseLeave);
            // 
            // update_PictureBox
            // 
            this.update_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.update_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btn_UpdateLibrary;
            this.update_PictureBox.Location = new System.Drawing.Point(829, 49);
            this.update_PictureBox.Name = "update_PictureBox";
            this.update_PictureBox.Size = new System.Drawing.Size(144, 50);
            this.update_PictureBox.TabIndex = 1;
            this.update_PictureBox.TabStop = false;
            this.update_PictureBox.Click += new System.EventHandler(this.update_PictureBox_Click);
            this.update_PictureBox.MouseEnter += new System.EventHandler(this.update_PictureBox_MouseEnter);
            this.update_PictureBox.MouseLeave += new System.EventHandler(this.update_PictureBox_MouseLeave);
            // 
            // ShowCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.CustomerCardPic;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.email_Label);
            this.Controls.Add(this.employeeName_Label);
            this.Controls.Add(this.qR_PictureBox);
            this.Controls.Add(this.phone_Label);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.delete_PictureBox);
            this.Controls.Add(this.update_PictureBox);
            this.DoubleBuffered = true;
            this.Name = "ShowCustomer";
            this.Size = new System.Drawing.Size(998, 216);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowCustomer_MouseClick);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qR_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox delete_PictureBox;
        public System.Windows.Forms.PictureBox update_PictureBox;
        public System.Windows.Forms.Label employeeName_Label;
        public System.Windows.Forms.Label address_Label;
        public System.Windows.Forms.Label email_Label;
        public System.Windows.Forms.Label phone_Label;
        public System.Windows.Forms.Label idLabel;
        public System.Windows.Forms.PictureBox qR_PictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}
