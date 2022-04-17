namespace FitnessClub.Assets
{
    partial class RoundTextBox
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
            this.Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Input.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.25F);
            this.Input.ForeColor = System.Drawing.Color.Snow;
            this.Input.Location = new System.Drawing.Point(5, 5);
            this.Input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(380, 24);
            this.Input.TabIndex = 0;
            this.Input.TextChanged += new System.EventHandler(this.inputTextChanged);
            // 
            // RoundTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.Controls.Add(this.Input);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.ForeColor = System.Drawing.Color.Snow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RoundTextBox";
            this.Size = new System.Drawing.Size(390, 34);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.RoundTextBoxPaint);
            this.Enter += new System.EventHandler(this.RoundTextBox_Enter);
            this.Resize += new System.EventHandler(this.RoundTextBox_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox Input;
    }
}
