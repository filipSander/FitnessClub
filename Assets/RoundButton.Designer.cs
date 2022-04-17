namespace FitnessClub.Assets
{
    partial class RoundButton
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
            this.Butt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Butt
            // 
            this.Butt.AutoSize = true;
            this.Butt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Butt.FlatAppearance.BorderSize = 0;
            this.Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Butt.ForeColor = System.Drawing.Color.Snow;
            this.Butt.Location = new System.Drawing.Point(5, 5);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(130, 40);
            this.Butt.TabIndex = 0;
            this.Butt.Text = "button";
            this.Butt.UseVisualStyleBackColor = false;
            // 
            // RoundButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.Butt);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RoundButton";
            this.Size = new System.Drawing.Size(140, 50);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RoundButtonPaint);
            this.Enter += new System.EventHandler(this.RoundButton_Enter);
            this.Resize += new System.EventHandler(this.RoundButtonResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button Butt;
    }
}
