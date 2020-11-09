namespace entiform
{
    partial class AddForm
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
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Mark_t = new System.Windows.Forms.TextBox();
            this.price_t = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.size_t = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mileage_t = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.desc_t = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(12, 111);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mark";
            // 
            // Mark_t
            // 
            this.Mark_t.Location = new System.Drawing.Point(12, 25);
            this.Mark_t.Name = "Mark_t";
            this.Mark_t.Size = new System.Drawing.Size(100, 20);
            this.Mark_t.TabIndex = 2;
            // 
            // price_t
            // 
            this.price_t.Location = new System.Drawing.Point(12, 73);
            this.price_t.Name = "price_t";
            this.price_t.Size = new System.Drawing.Size(100, 20);
            this.price_t.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IssueYear";
            // 
            // size_t
            // 
            this.size_t.Location = new System.Drawing.Point(132, 73);
            this.size_t.Name = "size_t";
            this.size_t.Size = new System.Drawing.Size(100, 20);
            this.size_t.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Size";
            // 
            // mileage_t
            // 
            this.mileage_t.Location = new System.Drawing.Point(255, 25);
            this.mileage_t.Name = "mileage_t";
            this.mileage_t.Size = new System.Drawing.Size(100, 20);
            this.mileage_t.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mileage";
            // 
            // desc_t
            // 
            this.desc_t.Location = new System.Drawing.Point(255, 73);
            this.desc_t.Multiline = true;
            this.desc_t.Name = "desc_t";
            this.desc_t.Size = new System.Drawing.Size(100, 20);
            this.desc_t.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Description";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(132, 25);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(117, 20);
            this.date.TabIndex = 13;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 147);
            this.Controls.Add(this.date);
            this.Controls.Add(this.desc_t);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mileage_t);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.size_t);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.price_t);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Mark_t);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_button);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Mark_t;
        private System.Windows.Forms.TextBox price_t;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox size_t;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mileage_t;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox desc_t;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date;
    }
}