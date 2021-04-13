
namespace Praktika_ychebnaya
{
    partial class MainForm
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
            this.btnRaschet = new System.Windows.Forms.Button();
            this.tbxNedvizgimost = new System.Windows.Forms.TextBox();
            this.tbxVznos = new System.Windows.Forms.TextBox();
            this.tbxStavka = new System.Windows.Forms.TextBox();
            this.rtbxInfo = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbxSrok = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnRaschet
            // 
            this.btnRaschet.Location = new System.Drawing.Point(341, 308);
            this.btnRaschet.Name = "btnRaschet";
            this.btnRaschet.Size = new System.Drawing.Size(75, 23);
            this.btnRaschet.TabIndex = 0;
            this.btnRaschet.Text = "Рассчитать";
            this.btnRaschet.UseVisualStyleBackColor = true;
            this.btnRaschet.Click += new System.EventHandler(this.btnRaschet_Click);
            // 
            // tbxNedvizgimost
            // 
            this.tbxNedvizgimost.Location = new System.Drawing.Point(240, 25);
            this.tbxNedvizgimost.Name = "tbxNedvizgimost";
            this.tbxNedvizgimost.Size = new System.Drawing.Size(115, 20);
            this.tbxNedvizgimost.TabIndex = 1;
            // 
            // tbxVznos
            // 
            this.tbxVznos.Location = new System.Drawing.Point(255, 60);
            this.tbxVznos.Name = "tbxVznos";
            this.tbxVznos.Size = new System.Drawing.Size(100, 20);
            this.tbxVznos.TabIndex = 2;
            // 
            // tbxStavka
            // 
            this.tbxStavka.Location = new System.Drawing.Point(280, 100);
            this.tbxStavka.Name = "tbxStavka";
            this.tbxStavka.Size = new System.Drawing.Size(100, 20);
            this.tbxStavka.TabIndex = 4;
            // 
            // rtbxInfo
            // 
            this.rtbxInfo.Location = new System.Drawing.Point(28, 186);
            this.rtbxInfo.Name = "rtbxInfo";
            this.rtbxInfo.Size = new System.Drawing.Size(273, 145);
            this.rtbxInfo.TabIndex = 5;
            this.rtbxInfo.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Стоимость недвижимости";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Первоначальный взнос, руб.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(24, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Срок";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(210, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ставка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(24, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат расчета";
            // 
            // cmbxSrok
            // 
            this.cmbxSrok.FormattingEnabled = true;
            this.cmbxSrok.Items.AddRange(new object[] {
            "1 год",
            "2 года",
            "4 года",
            "5 лет",
            "10 лет",
            "15 лет",
            "20 лет",
            "25 лет",
            "30 лет"});
            this.cmbxSrok.Location = new System.Drawing.Point(76, 98);
            this.cmbxSrok.Name = "cmbxSrok";
            this.cmbxSrok.Size = new System.Drawing.Size(121, 21);
            this.cmbxSrok.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 347);
            this.Controls.Add(this.cmbxSrok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbxInfo);
            this.Controls.Add(this.tbxStavka);
            this.Controls.Add(this.tbxVznos);
            this.Controls.Add(this.tbxNedvizgimost);
            this.Controls.Add(this.btnRaschet);
            this.Name = "MainForm";
            this.Text = "Калькулятор ипотеки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRaschet;
        private System.Windows.Forms.TextBox tbxNedvizgimost;
        private System.Windows.Forms.TextBox tbxVznos;
        private System.Windows.Forms.TextBox tbxStavka;
        private System.Windows.Forms.RichTextBox rtbxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbxSrok;
    }
}

