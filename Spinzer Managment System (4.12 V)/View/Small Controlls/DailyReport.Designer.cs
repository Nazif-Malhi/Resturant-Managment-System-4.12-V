
namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    partial class DailyReport
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Close_pictureBox = new System.Windows.Forms.PictureBox();
            this.time_Label = new System.Windows.Forms.Label();
            this.itemsSold_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemNameDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalIncome_Label = new System.Windows.Forms.Label();
            this.date_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Close_pictureBox
            // 
            this.Close_pictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.CloseButton;
            this.Close_pictureBox.Location = new System.Drawing.Point(602, 12);
            this.Close_pictureBox.Name = "Close_pictureBox";
            this.Close_pictureBox.Size = new System.Drawing.Size(42, 37);
            this.Close_pictureBox.TabIndex = 0;
            this.Close_pictureBox.TabStop = false;
            this.Close_pictureBox.Click += new System.EventHandler(this.Close_pictureBox_Click);
            // 
            // time_Label
            // 
            this.time_Label.AutoSize = true;
            this.time_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Label.Location = new System.Drawing.Point(22, 14);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(44, 21);
            this.time_Label.TabIndex = 1;
            this.time_Label.Text = "Time";
            // 
            // itemsSold_Label
            // 
            this.itemsSold_Label.AutoSize = true;
            this.itemsSold_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsSold_Label.Location = new System.Drawing.Point(22, 364);
            this.itemsSold_Label.Name = "itemsSold_Label";
            this.itemsSold_Label.Size = new System.Drawing.Size(166, 21);
            this.itemsSold_Label.TabIndex = 2;
            this.itemsSold_Label.Text = "Number Of Items Sold";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeight = 31;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNameDGV,
            this.qtyDGV,
            this.totalPriceDGV});
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(2);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(632, 295);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.TabStop = false;
            // 
            // ItemNameDGV
            // 
            this.ItemNameDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemNameDGV.HeaderText = "Item Name";
            this.ItemNameDGV.Name = "ItemNameDGV";
            // 
            // qtyDGV
            // 
            this.qtyDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtyDGV.FillWeight = 31.38728F;
            this.qtyDGV.HeaderText = "QTY";
            this.qtyDGV.Name = "qtyDGV";
            this.qtyDGV.Width = 65;
            // 
            // totalPriceDGV
            // 
            this.totalPriceDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totalPriceDGV.FillWeight = 116.371F;
            this.totalPriceDGV.HeaderText = "Total Price";
            this.totalPriceDGV.Name = "totalPriceDGV";
            this.totalPriceDGV.Width = 113;
            // 
            // totalIncome_Label
            // 
            this.totalIncome_Label.AutoSize = true;
            this.totalIncome_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalIncome_Label.Location = new System.Drawing.Point(329, 364);
            this.totalIncome_Label.Name = "totalIncome_Label";
            this.totalIncome_Label.Size = new System.Drawing.Size(97, 21);
            this.totalIncome_Label.TabIndex = 4;
            this.totalIncome_Label.Text = "Total Income";
            // 
            // date_Timer
            // 
            this.date_Timer.Tick += new System.EventHandler(this.date_Timer_Tick);
            // 
            // DailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 414);
            this.Controls.Add(this.totalIncome_Label);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.itemsSold_Label);
            this.Controls.Add(this.time_Label);
            this.Controls.Add(this.Close_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyReport";
            ((System.ComponentModel.ISupportInitialize)(this.Close_pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Close_pictureBox;
        private System.Windows.Forms.Label time_Label;
        private System.Windows.Forms.Label itemsSold_Label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNameDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDGV;
        private System.Windows.Forms.Label totalIncome_Label;
        private System.Windows.Forms.Timer date_Timer;
    }
}