
namespace Spinzer_Managment_System__4._12_V_.View.UserControll
{
    partial class StockUserController
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.csv_PictureBox = new System.Windows.Forms.PictureBox();
            this.report_PictureBox = new System.Windows.Forms.PictureBox();
            this.modify_PictureBox = new System.Windows.Forms.PictureBox();
            this.update_PictureBox = new System.Windows.Forms.PictureBox();
            this.delete_PictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.updateListTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.csv_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // csv_PictureBox
            // 
            this.csv_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btn_StockCSV;
            this.csv_PictureBox.Location = new System.Drawing.Point(916, 12);
            this.csv_PictureBox.Name = "csv_PictureBox";
            this.csv_PictureBox.Size = new System.Drawing.Size(40, 39);
            this.csv_PictureBox.TabIndex = 0;
            this.csv_PictureBox.TabStop = false;
            this.csv_PictureBox.Click += new System.EventHandler(this.csv_PictureBox_Click);
            this.csv_PictureBox.MouseEnter += new System.EventHandler(this.csv_PictureBox_MouseEnter);
            this.csv_PictureBox.MouseLeave += new System.EventHandler(this.csv_PictureBox_MouseLeave);
            // 
            // report_PictureBox
            // 
            this.report_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btn_StockReport;
            this.report_PictureBox.Location = new System.Drawing.Point(740, 9);
            this.report_PictureBox.Name = "report_PictureBox";
            this.report_PictureBox.Size = new System.Drawing.Size(161, 51);
            this.report_PictureBox.TabIndex = 1;
            this.report_PictureBox.TabStop = false;
            this.report_PictureBox.Click += new System.EventHandler(this.report_PictureBox_Click);
            this.report_PictureBox.MouseEnter += new System.EventHandler(this.report_PictureBox_MouseEnter);
            this.report_PictureBox.MouseLeave += new System.EventHandler(this.report_PictureBox_MouseLeave);
            // 
            // modify_PictureBox
            // 
            this.modify_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btn_StockModify;
            this.modify_PictureBox.Location = new System.Drawing.Point(564, 9);
            this.modify_PictureBox.Name = "modify_PictureBox";
            this.modify_PictureBox.Size = new System.Drawing.Size(161, 51);
            this.modify_PictureBox.TabIndex = 2;
            this.modify_PictureBox.TabStop = false;
            this.modify_PictureBox.Click += new System.EventHandler(this.modify_PictureBox_Click);
            this.modify_PictureBox.MouseEnter += new System.EventHandler(this.modify_PictureBox_MouseEnter);
            this.modify_PictureBox.MouseLeave += new System.EventHandler(this.modify_PictureBox_MouseLeave);
            // 
            // update_PictureBox
            // 
            this.update_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btn_StockUpdate;
            this.update_PictureBox.Location = new System.Drawing.Point(512, 607);
            this.update_PictureBox.Name = "update_PictureBox";
            this.update_PictureBox.Size = new System.Drawing.Size(161, 51);
            this.update_PictureBox.TabIndex = 4;
            this.update_PictureBox.TabStop = false;
            this.update_PictureBox.Click += new System.EventHandler(this.update_PictureBox_Click);
            this.update_PictureBox.MouseEnter += new System.EventHandler(this.update_PictureBox_MouseEnter);
            this.update_PictureBox.MouseLeave += new System.EventHandler(this.update_PictureBox_MouseLeave);
            // 
            // delete_PictureBox
            // 
            this.delete_PictureBox.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.btn_StockDelete;
            this.delete_PictureBox.Location = new System.Drawing.Point(708, 607);
            this.delete_PictureBox.Name = "delete_PictureBox";
            this.delete_PictureBox.Size = new System.Drawing.Size(161, 51);
            this.delete_PictureBox.TabIndex = 5;
            this.delete_PictureBox.TabStop = false;
            this.delete_PictureBox.Click += new System.EventHandler(this.delete_PictureBox_Click);
            this.delete_PictureBox.MouseEnter += new System.EventHandler(this.delete_PictureBox_MouseEnter);
            this.delete_PictureBox.MouseLeave += new System.EventHandler(this.delete_PictureBox_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.id,
            this.userId,
            this.qty,
            this.weight,
            this.unit,
            this.expiryDate,
            this.price,
            this.description});
            this.dataGridView1.Location = new System.Drawing.Point(291, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.Size = new System.Drawing.Size(685, 527);
            this.dataGridView1.TabIndex = 6;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // userId
            // 
            this.userId.HeaderText = "Column2";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            this.userId.Visible = false;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qty.HeaderText = "Qauntity";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.weight.HeaderText = "Weight";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // unit
            // 
            this.unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unit.HeaderText = "Unit";
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // expiryDate
            // 
            this.expiryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.expiryDate.HeaderText = "Expiry-Date";
            this.expiryDate.Name = "expiryDate";
            this.expiryDate.ReadOnly = true;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Description";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Red;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(22, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 525);
            this.listBox1.TabIndex = 7;
            // 
            // updateListTimer
            // 
            this.updateListTimer.Interval = 1000;
            this.updateListTimer.Tick += new System.EventHandler(this.updateListTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(78, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "StockEnding";
            this.label1.Visible = false;
            // 
            // StockUserController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::Spinzer_Managment_System__4._12_V_.Properties.Resources.StockUserControllPic;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_PictureBox);
            this.Controls.Add(this.update_PictureBox);
            this.Controls.Add(this.modify_PictureBox);
            this.Controls.Add(this.report_PictureBox);
            this.Controls.Add(this.csv_PictureBox);
            this.Name = "StockUserController";
            this.Size = new System.Drawing.Size(1091, 681);
            ((System.ComponentModel.ISupportInitialize)(this.csv_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.report_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modify_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox csv_PictureBox;
        private System.Windows.Forms.PictureBox report_PictureBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        public System.Windows.Forms.PictureBox modify_PictureBox;
        public System.Windows.Forms.PictureBox update_PictureBox;
        public System.Windows.Forms.PictureBox delete_PictureBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer updateListTimer;
        private System.Windows.Forms.Label label1;
    }
}
