namespace FitnessClub.Pages
{
    partial class Lesson
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCaDesc = new System.Windows.Forms.Label();
            this.Ctagent = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.CheckBox();
            this.day7 = new System.Windows.Forms.Label();
            this.day6 = new System.Windows.Forms.Label();
            this.day5 = new System.Windows.Forms.Label();
            this.day4 = new System.Windows.Forms.Label();
            this.day3 = new System.Windows.Forms.Label();
            this.day2 = new System.Windows.Forms.Label();
            this.day1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDayDesc = new System.Windows.Forms.Label();
            this.lblTimeDesc = new System.Windows.Forms.Label();
            this.lblNameDesc = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Занятия";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCaDesc);
            this.groupBox1.Controls.Add(this.Ctagent);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.day7);
            this.groupBox1.Controls.Add(this.day6);
            this.groupBox1.Controls.Add(this.day5);
            this.groupBox1.Controls.Add(this.day4);
            this.groupBox1.Controls.Add(this.day3);
            this.groupBox1.Controls.Add(this.day2);
            this.groupBox1.Controls.Add(this.day1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblDayDesc);
            this.groupBox1.Controls.Add(this.lblTimeDesc);
            this.groupBox1.Controls.Add(this.lblNameDesc);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.Snow;
            this.groupBox1.Location = new System.Drawing.Point(18, 310);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(758, 207);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // lblCaDesc
            // 
            this.lblCaDesc.AutoSize = true;
            this.lblCaDesc.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaDesc.Location = new System.Drawing.Point(22, 100);
            this.lblCaDesc.Name = "lblCaDesc";
            this.lblCaDesc.Size = new System.Drawing.Size(44, 15);
            this.lblCaDesc.TabIndex = 24;
            this.lblCaDesc.Text = "Мастер";
            // 
            // Ctagent
            // 
            this.Ctagent.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ctagent.FormattingEnabled = true;
            this.Ctagent.Location = new System.Drawing.Point(25, 126);
            this.Ctagent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ctagent.Name = "Ctagent";
            this.Ctagent.Size = new System.Drawing.Size(216, 25);
            this.Ctagent.TabIndex = 23;
            this.Ctagent.Click += new System.EventHandler(this.inputControlClick);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status.Location = new System.Drawing.Point(560, 174);
            this.status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(75, 21);
            this.status.TabIndex = 22;
            this.status.Text = "Активна";
            this.status.UseVisualStyleBackColor = true;
            // 
            // day7
            // 
            this.day7.AutoSize = true;
            this.day7.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day7.Location = new System.Drawing.Point(497, 134);
            this.day7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day7.Name = "day7";
            this.day7.Size = new System.Drawing.Size(24, 17);
            this.day7.TabIndex = 21;
            this.day7.Text = "ВС";
            this.day7.Click += new System.EventHandler(this.day1_Click);
            // 
            // day6
            // 
            this.day6.AutoSize = true;
            this.day6.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day6.Location = new System.Drawing.Point(470, 134);
            this.day6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day6.Name = "day6";
            this.day6.Size = new System.Drawing.Size(23, 17);
            this.day6.TabIndex = 20;
            this.day6.Text = "СУ";
            this.day6.Click += new System.EventHandler(this.day1_Click);
            // 
            // day5
            // 
            this.day5.AutoSize = true;
            this.day5.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day5.Location = new System.Drawing.Point(444, 134);
            this.day5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(22, 17);
            this.day5.TabIndex = 19;
            this.day5.Text = "ПТ";
            this.day5.Click += new System.EventHandler(this.day1_Click);
            // 
            // day4
            // 
            this.day4.AutoSize = true;
            this.day4.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day4.Location = new System.Drawing.Point(417, 134);
            this.day4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day4.Name = "day4";
            this.day4.Size = new System.Drawing.Size(22, 17);
            this.day4.TabIndex = 18;
            this.day4.Text = "ЧТ";
            this.day4.Click += new System.EventHandler(this.day1_Click);
            // 
            // day3
            // 
            this.day3.AutoSize = true;
            this.day3.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day3.Location = new System.Drawing.Point(389, 134);
            this.day3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(24, 17);
            this.day3.TabIndex = 17;
            this.day3.Text = "СР";
            this.day3.Click += new System.EventHandler(this.day1_Click);
            // 
            // day2
            // 
            this.day2.AutoSize = true;
            this.day2.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day2.Location = new System.Drawing.Point(363, 134);
            this.day2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day2.Name = "day2";
            this.day2.Size = new System.Drawing.Size(22, 17);
            this.day2.TabIndex = 16;
            this.day2.Text = "ВТ";
            this.day2.Click += new System.EventHandler(this.day1_Click);
            // 
            // day1
            // 
            this.day1.AutoSize = true;
            this.day1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.day1.Location = new System.Drawing.Point(335, 134);
            this.day1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.day1.Name = "day1";
            this.day1.Size = new System.Drawing.Size(24, 17);
            this.day1.TabIndex = 15;
            this.day1.Text = "ПН";
            this.day1.Click += new System.EventHandler(this.day1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 63);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(651, 166);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.applayClick);
            // 
            // lblDayDesc
            // 
            this.lblDayDesc.AutoSize = true;
            this.lblDayDesc.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDayDesc.Location = new System.Drawing.Point(335, 106);
            this.lblDayDesc.Name = "lblDayDesc";
            this.lblDayDesc.Size = new System.Drawing.Size(70, 15);
            this.lblDayDesc.TabIndex = 8;
            this.lblDayDesc.Text = "День недели";
            // 
            // lblTimeDesc
            // 
            this.lblTimeDesc.AutoSize = true;
            this.lblTimeDesc.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimeDesc.Location = new System.Drawing.Point(335, 34);
            this.lblTimeDesc.Name = "lblTimeDesc";
            this.lblTimeDesc.Size = new System.Drawing.Size(103, 15);
            this.lblTimeDesc.TabIndex = 5;
            this.lblTimeDesc.Text = "Время проведения";
            // 
            // lblNameDesc
            // 
            this.lblNameDesc.AutoSize = true;
            this.lblNameDesc.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameDesc.Location = new System.Drawing.Point(22, 34);
            this.lblNameDesc.Name = "lblNameDesc";
            this.lblNameDesc.Size = new System.Drawing.Size(82, 15);
            this.lblNameDesc.TabIndex = 3;
            this.lblNameDesc.Text = "Наименование";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbName.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.Snow;
            this.tbName.Location = new System.Drawing.Point(25, 65);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(216, 22);
            this.tbName.TabIndex = 2;
            this.tbName.Click += new System.EventHandler(this.inputControlClick);
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.AutoScrollMinSize = new System.Drawing.Size(753, 0);
            this.container.Location = new System.Drawing.Point(18, 34);
            this.container.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(753, 259);
            this.container.TabIndex = 4;
            this.container.WrapContents = false;
            // 
            // Lesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.container);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Lesson";
            this.Size = new System.Drawing.Size(797, 531);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDayDesc;
        private System.Windows.Forms.Label lblTimeDesc;
        private System.Windows.Forms.Label lblNameDesc;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label day7;
        private System.Windows.Forms.Label day6;
        private System.Windows.Forms.Label day5;
        private System.Windows.Forms.Label day4;
        private System.Windows.Forms.Label day3;
        private System.Windows.Forms.Label day2;
        private System.Windows.Forms.Label day1;
        private System.Windows.Forms.Label lblCaDesc;
        private System.Windows.Forms.ComboBox Ctagent;
        private System.Windows.Forms.CheckBox status;
        private System.Windows.Forms.FlowLayoutPanel container;
    }
}
