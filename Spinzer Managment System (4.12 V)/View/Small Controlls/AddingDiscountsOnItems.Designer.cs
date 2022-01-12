
namespace Spinzer_Managment_System__4._12_V_.View.Small_Controlls
{
    partial class AddingDiscountsOnItems
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Done = new System.Windows.Forms.Button();
            this.discountoOnEachItem_comboBox = new System.Windows.Forms.ComboBox();
            this.discount_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(21, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 316);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(324, 32);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(201, 316);
            this.listBox2.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(235, 58);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(79, 46);
            this.add.TabIndex = 2;
            this.add.Text = ">>";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(234, 125);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(79, 46);
            this.remove.TabIndex = 3;
            this.remove.Text = "<<";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(234, 196);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(79, 46);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Done
            // 
            this.Done.BackColor = System.Drawing.Color.Chartreuse;
            this.Done.Location = new System.Drawing.Point(234, 267);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(79, 46);
            this.Done.TabIndex = 5;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = false;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // discountoOnEachItem_comboBox
            // 
            this.discountoOnEachItem_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.discountoOnEachItem_comboBox.FormattingEnabled = true;
            this.discountoOnEachItem_comboBox.Items.AddRange(new object[] {
            "0%",
            "2%",
            "5%",
            "10%",
            "15%",
            "20%",
            "25%",
            "50%"});
            this.discountoOnEachItem_comboBox.Location = new System.Drawing.Point(317, 352);
            this.discountoOnEachItem_comboBox.Name = "discountoOnEachItem_comboBox";
            this.discountoOnEachItem_comboBox.Size = new System.Drawing.Size(57, 21);
            this.discountoOnEachItem_comboBox.TabIndex = 36;
            // 
            // discount_Label
            // 
            this.discount_Label.AutoSize = true;
            this.discount_Label.BackColor = System.Drawing.Color.Transparent;
            this.discount_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount_Label.Location = new System.Drawing.Point(187, 351);
            this.discount_Label.Name = "discount_Label";
            this.discount_Label.Size = new System.Drawing.Size(126, 15);
            this.discount_Label.TabIndex = 35;
            this.discount_Label.Text = "Discount on Each Item";
            // 
            // AddingDiscountsOnItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 393);
            this.Controls.Add(this.discountoOnEachItem_comboBox);
            this.Controls.Add(this.discount_Label);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "AddingDiscountsOnItems";
            this.Text = "AddingDiscountsOnItems";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Done;
        private System.Windows.Forms.ComboBox discountoOnEachItem_comboBox;
        private System.Windows.Forms.Label discount_Label;
    }
}