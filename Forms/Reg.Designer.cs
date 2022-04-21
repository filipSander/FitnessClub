namespace FitnessClub.Forms
{
    partial class Reg
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
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.lblFIO = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.tbRepeatPass = new System.Windows.Forms.TextBox();
            this.apply = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFIO
            // 
            this.tbFIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbFIO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbFIO.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbFIO.ForeColor = System.Drawing.Color.Snow;
            this.tbFIO.Location = new System.Drawing.Point(33, 62);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(299, 26);
            this.tbFIO.TabIndex = 0;
            this.tbFIO.Tag = "input";
            this.tbFIO.TextChanged += new System.EventHandler(this.AllinputTextChanged);
            this.tbFIO.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFIO_KeyDown);
            this.tbFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFIO_KeyPress);
            // 
            // lblFIO
            // 
            this.lblFIO.AutoSize = true;
            this.lblFIO.Location = new System.Drawing.Point(30, 42);
            this.lblFIO.Name = "lblFIO";
            this.lblFIO.Size = new System.Drawing.Size(35, 17);
            this.lblFIO.TabIndex = 1;
            this.lblFIO.Tag = "desc";
            this.lblFIO.Text = "ФИО";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(30, 98);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(41, 17);
            this.lblLogin.TabIndex = 3;
            this.lblLogin.Tag = "desc";
            this.lblLogin.Text = "Логин";
            // 
            // tbLogin
            // 
            this.tbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbLogin.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.ForeColor = System.Drawing.Color.Snow;
            this.tbLogin.Location = new System.Drawing.Point(33, 118);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(299, 26);
            this.tbLogin.TabIndex = 2;
            this.tbLogin.Tag = "input";
            this.tbLogin.TextChanged += new System.EventHandler(this.AllinputTextChanged);
            this.tbLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFIO_KeyDown);
            this.tbLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFIO_KeyPress);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(30, 157);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(50, 17);
            this.lblPass.TabIndex = 5;
            this.lblPass.Tag = "desc";
            this.lblPass.Text = "Пароль";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPass.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPass.ForeColor = System.Drawing.Color.Snow;
            this.tbPass.Location = new System.Drawing.Point(33, 177);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(299, 26);
            this.tbPass.TabIndex = 4;
            this.tbPass.Tag = "input";
            this.tbPass.TextChanged += new System.EventHandler(this.AllinputTextChanged);
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFIO_KeyDown);
            this.tbPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFIO_KeyPress);
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Location = new System.Drawing.Point(30, 217);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(93, 17);
            this.lblRepeatPass.TabIndex = 7;
            this.lblRepeatPass.Tag = "desc";
            this.lblRepeatPass.Text = "Повтор пароля";
            // 
            // tbRepeatPass
            // 
            this.tbRepeatPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.tbRepeatPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRepeatPass.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRepeatPass.ForeColor = System.Drawing.Color.Snow;
            this.tbRepeatPass.Location = new System.Drawing.Point(33, 237);
            this.tbRepeatPass.Name = "tbRepeatPass";
            this.tbRepeatPass.Size = new System.Drawing.Size(299, 26);
            this.tbRepeatPass.TabIndex = 6;
            this.tbRepeatPass.Tag = "input";
            this.tbRepeatPass.TextChanged += new System.EventHandler(this.AllinputTextChanged);
            this.tbRepeatPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbFIO_KeyDown);
            this.tbRepeatPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFIO_KeyPress);
            // 
            // apply
            // 
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Location = new System.Drawing.Point(231, 301);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(101, 38);
            this.apply.TabIndex = 8;
            this.apply.Tag = "input";
            this.apply.Text = "Регистрация";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.applyClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Авторизация";
            this.label1.Click += new System.EventHandler(this.linkClick);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(363, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.lblRepeatPass);
            this.Controls.Add(this.tbRepeatPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblFIO);
            this.Controls.Add(this.tbFIO);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Snow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label lblFIO;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.TextBox tbRepeatPass;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label1;
    }
}