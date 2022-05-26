namespace ОбувьДэмоУП
{
    partial class Listitem
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lId = new System.Windows.Forms.Label();
            this.lDiscount = new System.Windows.Forms.Label();
            this.lCost = new System.Windows.Forms.Label();
            this.lManufacturer = new System.Windows.Forms.Label();
            this.lDescription = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ContextMenuStrip = this.contextMenuStrip1;
            this.panel1.Controls.Add(this.lId);
            this.panel1.Controls.Add(this.lDiscount);
            this.panel1.Controls.Add(this.lCost);
            this.panel1.Controls.Add(this.lManufacturer);
            this.panel1.Controls.Add(this.lDescription);
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 98);
            this.panel1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 48);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(431, 80);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(15, 13);
            this.lId.TabIndex = 6;
            this.lId.Text = "id";
            // 
            // lDiscount
            // 
            this.lDiscount.Location = new System.Drawing.Point(705, 3);
            this.lDiscount.Name = "lDiscount";
            this.lDiscount.Size = new System.Drawing.Size(193, 13);
            this.lDiscount.TabIndex = 5;
            this.lDiscount.Text = "Размер скидки";
            this.lDiscount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lCost
            // 
            this.lCost.AutoSize = true;
            this.lCost.Location = new System.Drawing.Point(99, 59);
            this.lCost.Name = "lCost";
            this.lCost.Size = new System.Drawing.Size(33, 13);
            this.lCost.TabIndex = 4;
            this.lCost.Text = "Цена";
            // 
            // lManufacturer
            // 
            this.lManufacturer.AutoSize = true;
            this.lManufacturer.Location = new System.Drawing.Point(99, 46);
            this.lManufacturer.Name = "lManufacturer";
            this.lManufacturer.Size = new System.Drawing.Size(86, 13);
            this.lManufacturer.TabIndex = 3;
            this.lManufacturer.Text = "Производитель";
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(99, 33);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(57, 13);
            this.lDescription.TabIndex = 2;
            this.lDescription.Text = "Описание";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Location = new System.Drawing.Point(99, 20);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(83, 13);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "Наименование";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Listitem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.panel1);
            this.Name = "Listitem";
            this.Size = new System.Drawing.Size(909, 104);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lDiscount;
        private System.Windows.Forms.Label lCost;
        private System.Windows.Forms.Label lManufacturer;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lId;
        public System.Windows.Forms.Panel panel1;
    }
}
