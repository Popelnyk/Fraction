namespace Shooting
{
    partial class Shooting
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
            this.components = new System.ComponentModel.Container();
            this.lblRad = new System.Windows.Forms.Label();
            this.textBoxRad = new System.Windows.Forms.TextBox();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.labelNum = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelKoord = new System.Windows.Forms.Label();
            this.labelRem = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.labelMiss = new System.Windows.Forms.Label();
            this.labelHit = new System.Windows.Forms.Label();
            this.labelStat = new System.Windows.Forms.Label();
            this.labelDone1 = new System.Windows.Forms.Label();
            this.labelRem1 = new System.Windows.Forms.Label();
            this.labelHit1 = new System.Windows.Forms.Label();
            this.labelMiss1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelKoordX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRad
            // 
            this.lblRad.AutoSize = true;
            this.lblRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRad.Location = new System.Drawing.Point(467, 24);
            this.lblRad.Name = "lblRad";
            this.lblRad.Size = new System.Drawing.Size(201, 20);
            this.lblRad.TabIndex = 0;
            this.lblRad.Text = "Введите радиус мишени:";
            // 
            // textBoxRad
            // 
            this.textBoxRad.Location = new System.Drawing.Point(674, 24);
            this.textBoxRad.Name = "textBoxRad";
            this.textBoxRad.Size = new System.Drawing.Size(91, 20);
            this.textBoxRad.TabIndex = 1;
            this.textBoxRad.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxRad_Validating);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(727, 58);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(38, 20);
            this.textBoxNum.TabIndex = 2;
            this.textBoxNum.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNum_Validating);
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelNum.Location = new System.Drawing.Point(467, 58);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(260, 20);
            this.labelNum.TabIndex = 3;
            this.labelNum.Text = "Введите количество выстрелов:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(527, 239);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 20);
            this.textBoxY.TabIndex = 5;
            this.textBoxY.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxY_Validating);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(527, 201);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 20);
            this.textBoxX.TabIndex = 4;
            this.textBoxX.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxX_Validating);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelX.Location = new System.Drawing.Point(497, 201);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(24, 20);
            this.labelX.TabIndex = 6;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelY.Location = new System.Drawing.Point(497, 239);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(24, 20);
            this.labelY.TabIndex = 7;
            this.labelY.Text = "Y:";
            // 
            // labelKoord
            // 
            this.labelKoord.AutoSize = true;
            this.labelKoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelKoord.Location = new System.Drawing.Point(497, 151);
            this.labelKoord.Name = "labelKoord";
            this.labelKoord.Size = new System.Drawing.Size(255, 20);
            this.labelKoord.TabIndex = 8;
            this.labelKoord.Text = "Введите координаты выстрела:";
            // 
            // labelRem
            // 
            this.labelRem.AutoSize = true;
            this.labelRem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRem.Location = new System.Drawing.Point(666, 309);
            this.labelRem.Name = "labelRem";
            this.labelRem.Size = new System.Drawing.Size(63, 15);
            this.labelRem.TabIndex = 9;
            this.labelRem.Text = "Осталось";
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelDone.Location = new System.Drawing.Point(524, 309);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(57, 15);
            this.labelDone.TabIndex = 10;
            this.labelDone.Text = "Сделано";
            // 
            // labelMiss
            // 
            this.labelMiss.AutoSize = true;
            this.labelMiss.Location = new System.Drawing.Point(666, 360);
            this.labelMiss.Name = "labelMiss";
            this.labelMiss.Size = new System.Drawing.Size(58, 13);
            this.labelMiss.TabIndex = 11;
            this.labelMiss.Text = "Промахов";
            // 
            // labelHit
            // 
            this.labelHit.AutoSize = true;
            this.labelHit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelHit.Location = new System.Drawing.Point(524, 358);
            this.labelHit.Name = "labelHit";
            this.labelHit.Size = new System.Drawing.Size(72, 15);
            this.labelHit.TabIndex = 12;
            this.labelHit.Text = "Попаданий";
            // 
            // labelStat
            // 
            this.labelStat.AutoSize = true;
            this.labelStat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelStat.Location = new System.Drawing.Point(545, 272);
            this.labelStat.Name = "labelStat";
            this.labelStat.Size = new System.Drawing.Size(162, 17);
            this.labelStat.TabIndex = 13;
            this.labelStat.Text = "Статистика выстрелов:";
            // 
            // labelDone1
            // 
            this.labelDone1.AutoSize = true;
            this.labelDone1.Location = new System.Drawing.Point(545, 334);
            this.labelDone1.Name = "labelDone1";
            this.labelDone1.Size = new System.Drawing.Size(10, 13);
            this.labelDone1.TabIndex = 14;
            this.labelDone1.Text = "-";
            // 
            // labelRem1
            // 
            this.labelRem1.AutoSize = true;
            this.labelRem1.Location = new System.Drawing.Point(688, 334);
            this.labelRem1.Name = "labelRem1";
            this.labelRem1.Size = new System.Drawing.Size(10, 13);
            this.labelRem1.TabIndex = 15;
            this.labelRem1.Text = "-";
            // 
            // labelHit1
            // 
            this.labelHit1.AutoSize = true;
            this.labelHit1.Location = new System.Drawing.Point(545, 386);
            this.labelHit1.Name = "labelHit1";
            this.labelHit1.Size = new System.Drawing.Size(10, 13);
            this.labelHit1.TabIndex = 16;
            this.labelHit1.Text = "-";
            // 
            // labelMiss1
            // 
            this.labelMiss1.AutoSize = true;
            this.labelMiss1.Location = new System.Drawing.Point(688, 386);
            this.labelMiss1.Name = "labelMiss1";
            this.labelMiss1.Size = new System.Drawing.Size(10, 13);
            this.labelMiss1.TabIndex = 17;
            this.labelMiss1.Text = "-";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(440, 414);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(440, 414);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(440, 414);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // buttonShoot
            // 
            this.buttonShoot.Location = new System.Drawing.Point(660, 201);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(97, 58);
            this.buttonShoot.TabIndex = 6;
            this.buttonShoot.Text = "Выстрел";
            this.buttonShoot.UseVisualStyleBackColor = true;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(471, 105);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(294, 23);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Начать стрельбу";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(471, 415);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(294, 23);
            this.buttonStop.TabIndex = 7;
            this.buttonStop.Text = "Завершить стрельбу";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labelKoordX
            // 
            this.labelKoordX.AutoSize = true;
            this.labelKoordX.Location = new System.Drawing.Point(545, 185);
            this.labelKoordX.Name = "labelKoordX";
            this.labelKoordX.Size = new System.Drawing.Size(64, 13);
            this.labelKoordX.TabIndex = 19;
            this.labelKoordX.Text = "(-220 -- 220)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "(-207 -- 207)";
            // 
            // Shooting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKoordX);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelMiss1);
            this.Controls.Add(this.labelHit1);
            this.Controls.Add(this.labelRem1);
            this.Controls.Add(this.labelDone1);
            this.Controls.Add(this.labelStat);
            this.Controls.Add(this.labelHit);
            this.Controls.Add(this.labelMiss);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.labelRem);
            this.Controls.Add(this.labelKoord);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.textBoxNum);
            this.Controls.Add(this.textBoxRad);
            this.Controls.Add(this.lblRad);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Shooting";
            this.Text = "Shooting";
            this.Load += new System.EventHandler(this.Shooting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRad;
        private System.Windows.Forms.TextBox textBoxRad;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelKoord;
        private System.Windows.Forms.Label labelRem;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.Label labelMiss;
        private System.Windows.Forms.Label labelHit;
        private System.Windows.Forms.Label labelStat;
        private System.Windows.Forms.Label labelDone1;
        private System.Windows.Forms.Label labelRem1;
        private System.Windows.Forms.Label labelHit1;
        private System.Windows.Forms.Label labelMiss1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label labelKoordX;
        private System.Windows.Forms.Label label1;
    }
}

