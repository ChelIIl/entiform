namespace entiform
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllCarsTable = new System.Windows.Forms.DataGridView();
            this.search_button = new System.Windows.Forms.Button();
            this.Mark_t = new System.Windows.Forms.TextBox();
            this.size_t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chdnge_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AllCarsTable
            // 
            this.AllCarsTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.AllCarsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllCarsTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AllCarsTable.Location = new System.Drawing.Point(0, 130);
            this.AllCarsTable.Name = "AllCarsTable";
            this.AllCarsTable.Size = new System.Drawing.Size(644, 150);
            this.AllCarsTable.TabIndex = 0;
            this.AllCarsTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.AllCarsTable_CellMouseDoubleClick);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(25, 101);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 23);
            this.search_button.TabIndex = 1;
            this.search_button.Text = "Поиск";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Mark_t
            // 
            this.Mark_t.Location = new System.Drawing.Point(12, 75);
            this.Mark_t.Name = "Mark_t";
            this.Mark_t.Size = new System.Drawing.Size(100, 20);
            this.Mark_t.TabIndex = 2;
            // 
            // size_t
            // 
            this.size_t.Location = new System.Drawing.Point(12, 25);
            this.size_t.Name = "size_t";
            this.size_t.Size = new System.Drawing.Size(100, 20);
            this.size_t.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Марка машины";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Объем бака";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(118, 17);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 23);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(118, 46);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 23);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Добавить";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Обновить ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chdnge_button
            // 
            this.chdnge_button.Location = new System.Drawing.Point(118, 101);
            this.chdnge_button.Name = "chdnge_button";
            this.chdnge_button.Size = new System.Drawing.Size(75, 23);
            this.chdnge_button.TabIndex = 9;
            this.chdnge_button.Text = "Изменить";
            this.chdnge_button.UseVisualStyleBackColor = true;
            this.chdnge_button.Click += new System.EventHandler(this.chdnge_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 280);
            this.Controls.Add(this.chdnge_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.size_t);
            this.Controls.Add(this.Mark_t);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.AllCarsTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.AllCarsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AllCarsTable;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.TextBox Mark_t;
        private System.Windows.Forms.TextBox size_t;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button chdnge_button;
    }
}

