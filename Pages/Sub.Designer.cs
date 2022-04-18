namespace FitnessClub.Pages
{
    partial class Sub
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
            this.adminContent = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLessons = new System.Windows.Forms.Label();
            this.lessonContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDateEx = new System.Windows.Forms.Label();
            this.tbDateEx = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.rcDesc = new System.Windows.Forms.RichTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.FlowLayoutPanel();
            this.adminContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(1241, 990);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Абонименты";
            // 
            // adminContent
            // 
            this.adminContent.Controls.Add(this.button1);
            this.adminContent.Controls.Add(this.lblLessons);
            this.adminContent.Controls.Add(this.lessonContainer);
            this.adminContent.Controls.Add(this.lblDateEx);
            this.adminContent.Controls.Add(this.tbDateEx);
            this.adminContent.Controls.Add(this.lblDesc);
            this.adminContent.Controls.Add(this.rcDesc);
            this.adminContent.Controls.Add(this.lblPrice);
            this.adminContent.Controls.Add(this.tbPrice);
            this.adminContent.Controls.Add(this.lblName);
            this.adminContent.Controls.Add(this.tbName);
            this.adminContent.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adminContent.ForeColor = System.Drawing.Color.Snow;
            this.adminContent.Location = new System.Drawing.Point(19, 316);
            this.adminContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminContent.Name = "adminContent";
            this.adminContent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.adminContent.Size = new System.Drawing.Size(753, 200);
            this.adminContent.TabIndex = 2;
            this.adminContent.TabStop = false;
            this.adminContent.Text = "Добавить";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(652, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 32);
            this.button1.TabIndex = 13;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.applayClick);
            // 
            // lblLessons
            // 
            this.lblLessons.AutoSize = true;
            this.lblLessons.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLessons.Location = new System.Drawing.Point(458, 37);
            this.lblLessons.Name = "lblLessons";
            this.lblLessons.Size = new System.Drawing.Size(47, 15);
            this.lblLessons.TabIndex = 12;
            this.lblLessons.Text = "Занятия";
            // 
            // lessonContainer
            // 
            this.lessonContainer.AutoScroll = true;
            this.lessonContainer.AutoScrollMinSize = new System.Drawing.Size(175, 112);
            this.lessonContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lessonContainer.Font = new System.Drawing.Font("Franklin Gothic Demi", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lessonContainer.Location = new System.Drawing.Point(461, 64);
            this.lessonContainer.Margin = new System.Windows.Forms.Padding(2);
            this.lessonContainer.Name = "lessonContainer";
            this.lessonContainer.Size = new System.Drawing.Size(175, 112);
            this.lessonContainer.TabIndex = 11;
            // 
            // lblDateEx
            // 
            this.lblDateEx.AutoSize = true;
            this.lblDateEx.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDateEx.Location = new System.Drawing.Point(18, 89);
            this.lblDateEx.Name = "lblDateEx";
            this.lblDateEx.Size = new System.Drawing.Size(79, 15);
            this.lblDateEx.TabIndex = 8;
            this.lblDateEx.Text = "Срок годности";
            // 
            // tbDateEx
            // 
            this.tbDateEx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbDateEx.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDateEx.ForeColor = System.Drawing.Color.Snow;
            this.tbDateEx.Location = new System.Drawing.Point(21, 108);
            this.tbDateEx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDateEx.Name = "tbDateEx";
            this.tbDateEx.Size = new System.Drawing.Size(214, 22);
            this.tbDateEx.TabIndex = 7;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDesc.Location = new System.Drawing.Point(257, 37);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(56, 15);
            this.lblDesc.TabIndex = 10;
            this.lblDesc.Text = "Описание";
            // 
            // rcDesc
            // 
            this.rcDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.rcDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rcDesc.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rcDesc.ForeColor = System.Drawing.Color.Snow;
            this.rcDesc.Location = new System.Drawing.Point(261, 67);
            this.rcDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rcDesc.Name = "rcDesc";
            this.rcDesc.Size = new System.Drawing.Size(176, 109);
            this.rcDesc.TabIndex = 9;
            this.rcDesc.Text = "";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPrice.Location = new System.Drawing.Point(18, 135);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(32, 15);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Цена";
            // 
            // tbPrice
            // 
            this.tbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbPrice.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPrice.ForeColor = System.Drawing.Color.Snow;
            this.tbPrice.Location = new System.Drawing.Point(21, 154);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(107, 22);
            this.tbPrice.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Franklin Gothic Demi", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(18, 37);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 15);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Наименование";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbName.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbName.ForeColor = System.Drawing.Color.Snow;
            this.tbName.Location = new System.Drawing.Point(21, 56);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(214, 22);
            this.tbName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Абонименты";
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.AutoScrollMinSize = new System.Drawing.Size(753, 0);
            this.container.Location = new System.Drawing.Point(19, 40);
            this.container.Margin = new System.Windows.Forms.Padding(2);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(753, 270);
            this.container.TabIndex = 15;
            this.container.WrapContents = false;
            // 
            // Sub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Controls.Add(this.adminContent);
            this.Controls.Add(this.container);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sub";
            this.Size = new System.Drawing.Size(797, 531);
            this.adminContent.ResumeLayout(false);
            this.adminContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox adminContent;
        private System.Windows.Forms.Label lblDateEx;
        private System.Windows.Forms.TextBox tbDateEx;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.RichTextBox rcDesc;
        private System.Windows.Forms.Label lblLessons;
        private System.Windows.Forms.FlowLayoutPanel lessonContainer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel container;
    }
}
