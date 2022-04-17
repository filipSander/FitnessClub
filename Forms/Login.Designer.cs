namespace FitnessClub.Forms
{
    partial class Login
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
            this.loginLable = new System.Windows.Forms.Label();
            this.passLable = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.apply = new FitnessClub.Assets.RoundButton();
            this.passCtl = new FitnessClub.Assets.RoundTextBox();
            this.loginCtl = new FitnessClub.Assets.RoundTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLable
            // 
            this.loginLable.AutoSize = true;
            this.loginLable.Location = new System.Drawing.Point(29, 32);
            this.loginLable.Name = "loginLable";
            this.loginLable.Size = new System.Drawing.Size(52, 21);
            this.loginLable.TabIndex = 2;
            this.loginLable.Text = "Логин";
            // 
            // passLable
            // 
            this.passLable.AutoSize = true;
            this.passLable.Location = new System.Drawing.Point(29, 100);
            this.passLable.Name = "passLable";
            this.passLable.Size = new System.Drawing.Size(62, 21);
            this.passLable.TabIndex = 3;
            this.passLable.Text = "Пароль";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FitnessClub.Properties.Resources.ico;
            this.pictureBox1.Location = new System.Drawing.Point(339, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.showPassIconClick);
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.apply.ButtActionColor = System.Drawing.Color.Green;
            this.apply.ButtText = "Войти";
            this.apply.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apply.ForeColor = System.Drawing.Color.Snow;
            this.apply.Location = new System.Drawing.Point(365, 199);
            this.apply.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(140, 50);
            this.apply.TabIndex = 4;
            // 
            // passCtl
            // 
            this.passCtl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.passCtl.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.passCtl.ForeColor = System.Drawing.Color.Snow;
            this.passCtl.Location = new System.Drawing.Point(27, 126);
            this.passCtl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passCtl.Name = "passCtl";
            this.passCtl.PasswordChar = true;
            this.passCtl.Size = new System.Drawing.Size(296, 36);
            this.passCtl.TabIndex = 1;
            this.passCtl.Value = null;
            // 
            // loginCtl
            // 
            this.loginCtl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.loginCtl.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F);
            this.loginCtl.ForeColor = System.Drawing.Color.Snow;
            this.loginCtl.Location = new System.Drawing.Point(27, 58);
            this.loginCtl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginCtl.Name = "loginCtl";
            this.loginCtl.PasswordChar = false;
            this.loginCtl.Size = new System.Drawing.Size(296, 36);
            this.loginCtl.TabIndex = 0;
            this.loginCtl.Value = null;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(523, 264);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.passLable);
            this.Controls.Add(this.loginLable);
            this.Controls.Add(this.passCtl);
            this.Controls.Add(this.loginCtl);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Login";
            this.Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Assets.RoundTextBox loginCtl;
        private Assets.RoundTextBox passCtl;
        private System.Windows.Forms.Label loginLable;
        private System.Windows.Forms.Label passLable;
        private Assets.RoundButton apply;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

