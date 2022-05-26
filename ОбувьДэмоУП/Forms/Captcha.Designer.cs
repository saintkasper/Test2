namespace ОбувьДэмоУП
{
    partial class Captcha
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.C4 = new System.Windows.Forms.Label();
            this.C3 = new System.Windows.Forms.Label();
            this.C2 = new System.Windows.Forms.Label();
            this.C1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(342, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "text";
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(62, 172);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(288, 29);
            this.textBox1.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(135, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите капчу";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 14;
            this.button2.Text = "Отправить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 40);
            this.button1.TabIndex = 13;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // C4
            // 
            this.C4.AutoSize = true;
            this.C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C4.Location = new System.Drawing.Point(233, 98);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(20, 24);
            this.C4.TabIndex = 12;
            this.C4.Text = "1";
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(186, 117);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(20, 24);
            this.C3.TabIndex = 11;
            this.C3.Text = "1";
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(163, 82);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(20, 24);
            this.C2.TabIndex = 10;
            this.C2.Text = "1";
            // 
            // C1
            // 
            this.C1.AutoSize = true;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1.Location = new System.Drawing.Point(116, 107);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(20, 24);
            this.C1.TabIndex = 9;
            this.C1.Text = "1";
            // 
            // Captcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.C4);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Name = "Captcha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capthca";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Capthca_FormClosing);
            this.Load += new System.EventHandler(this.Capthca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label C4;
        private System.Windows.Forms.Label C3;
        private System.Windows.Forms.Label C2;
        private System.Windows.Forms.Label C1;
    }
}