
namespace Интернет_провайдер
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Mone = new System.Windows.Forms.Label();
            this.surna = new System.Windows.Forms.Label();
            this.nameLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.schet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Tar = new System.Windows.Forms.Label();
            this.udateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Счёт:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Изменить тариф";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Mone
            // 
            this.Mone.AutoSize = true;
            this.Mone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Mone.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mone.Location = new System.Drawing.Point(367, 9);
            this.Mone.Name = "Mone";
            this.Mone.Size = new System.Drawing.Size(43, 20);
            this.Mone.TabIndex = 2;
            this.Mone.Text = "Ден.";
            this.Mone.Click += new System.EventHandler(this.Mone_Click);
            // 
            // surna
            // 
            this.surna.AutoSize = true;
            this.surna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surna.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.surna.Location = new System.Drawing.Point(12, 9);
            this.surna.Name = "surna";
            this.surna.Size = new System.Drawing.Size(81, 20);
            this.surna.TabIndex = 3;
            this.surna.Text = "Фамилия";
            // 
            // nameLab
            // 
            this.nameLab.AutoSize = true;
            this.nameLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameLab.Location = new System.Drawing.Point(111, 9);
            this.nameLab.Name = "nameLab";
            this.nameLab.Size = new System.Drawing.Size(40, 20);
            this.nameLab.TabIndex = 4;
            this.nameLab.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(12, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Номер счёта:";
            // 
            // schet
            // 
            this.schet.AutoSize = true;
            this.schet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schet.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.schet.Location = new System.Drawing.Point(129, 41);
            this.schet.Name = "schet";
            this.schet.Size = new System.Drawing.Size(65, 20);
            this.schet.TabIndex = 6;
            this.schet.Text = "Цифры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(12, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Тариф:";
            // 
            // Tar
            // 
            this.Tar.AutoSize = true;
            this.Tar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Tar.Location = new System.Drawing.Point(82, 96);
            this.Tar.Name = "Tar";
            this.Tar.Size = new System.Drawing.Size(83, 20);
            this.Tar.TabIndex = 8;
            this.Tar.Text = "Название";
            // 
            // udateButton
            // 
            this.udateButton.Location = new System.Drawing.Point(335, 148);
            this.udateButton.Name = "udateButton";
            this.udateButton.Size = new System.Drawing.Size(75, 23);
            this.udateButton.TabIndex = 9;
            this.udateButton.Text = "Обновить";
            this.udateButton.UseVisualStyleBackColor = true;
            this.udateButton.Click += new System.EventHandler(this.udateButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(421, 183);
            this.Controls.Add(this.udateButton);
            this.Controls.Add(this.Tar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.schet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameLab);
            this.Controls.Add(this.surna);
            this.Controls.Add(this.Mone);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Интернет-провайдер ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Mone;
        private System.Windows.Forms.Label surna;
        private System.Windows.Forms.Label nameLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label schet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Tar;
        private System.Windows.Forms.Button udateButton;
    }
}

