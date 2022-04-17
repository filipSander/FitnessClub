namespace FitnessClub.Forms
{
    partial class Error
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
            this.desc = new System.Windows.Forms.Label();
            this.roundButton1 = new FitnessClub.Assets.RoundButton();
            this.SuspendLayout();
            // 
            // desc
            // 
            this.desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(230, 97);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(44, 21);
            this.desc.TabIndex = 0;
            this.desc.Text = "desc";
            this.desc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundButton1
            // 
            this.roundButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(71)))));
            this.roundButton1.ButtActionColor = System.Drawing.Color.Maroon;
            this.roundButton1.ButtText = "Ок";
            this.roundButton1.Font = new System.Drawing.Font("Franklin Gothic Demi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roundButton1.ForeColor = System.Drawing.Color.Snow;
            this.roundButton1.Location = new System.Drawing.Point(451, 177);
            this.roundButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(110, 54);
            this.roundButton1.TabIndex = 1;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(567, 236);
            this.Controls.Add(this.roundButton1);
            this.Controls.Add(this.desc);
            this.Font = new System.Drawing.Font("Franklin Gothic Demi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Error";
            this.Text = "Error";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label desc;
        private Assets.RoundButton roundButton1;
    }
}