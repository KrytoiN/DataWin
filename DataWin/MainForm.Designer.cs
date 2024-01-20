namespace DataWin
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
            this.groupMain = new System.Windows.Forms.GroupBox();
            this.btnAddiction = new System.Windows.Forms.Button();
            this.btnRto = new System.Windows.Forms.Button();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnActiv = new System.Windows.Forms.Button();
            this.btnFreq = new System.Windows.Forms.Button();
            this.btnSub3 = new System.Windows.Forms.Button();
            this.btnSub2 = new System.Windows.Forms.Button();
            this.btnSub1 = new System.Windows.Forms.Button();
            this.btnOwner = new System.Windows.Forms.Button();
            this.btnRtoValues = new System.Windows.Forms.Button();
            this.btnTarrifs = new System.Windows.Forms.Button();
            this.groupMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMain
            // 
            this.groupMain.Controls.Add(this.btnTarrifs);
            this.groupMain.Controls.Add(this.btnRtoValues);
            this.groupMain.Controls.Add(this.btnOwner);
            this.groupMain.Controls.Add(this.btnAddiction);
            this.groupMain.Controls.Add(this.btnRto);
            this.groupMain.Controls.Add(this.btnProcess);
            this.groupMain.Controls.Add(this.btnActiv);
            this.groupMain.Controls.Add(this.btnFreq);
            this.groupMain.Controls.Add(this.btnSub3);
            this.groupMain.Controls.Add(this.btnSub2);
            this.groupMain.Controls.Add(this.btnSub1);
            this.groupMain.Location = new System.Drawing.Point(12, 12);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(681, 737);
            this.groupMain.TabIndex = 0;
            this.groupMain.TabStop = false;
            this.groupMain.Text = "Добавление/редактирование";
            // 
            // btnAddiction
            // 
            this.btnAddiction.Location = new System.Drawing.Point(33, 578);
            this.btnAddiction.Name = "btnAddiction";
            this.btnAddiction.Size = new System.Drawing.Size(201, 63);
            this.btnAddiction.TabIndex = 7;
            this.btnAddiction.Text = "Степени зависимости";
            this.btnAddiction.UseVisualStyleBackColor = true;
            this.btnAddiction.Click += new System.EventHandler(this.btnAddiction_Click);
            // 
            // btnRto
            // 
            this.btnRto.Location = new System.Drawing.Point(267, 578);
            this.btnRto.Name = "btnRto";
            this.btnRto.Size = new System.Drawing.Size(201, 63);
            this.btnRto.TabIndex = 6;
            this.btnRto.Text = "RTO";
            this.btnRto.UseVisualStyleBackColor = true;
            this.btnRto.Click += new System.EventHandler(this.btnRto_Click);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(257, 232);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(201, 63);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Процессы";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnActiv
            // 
            this.btnActiv.Location = new System.Drawing.Point(257, 94);
            this.btnActiv.Name = "btnActiv";
            this.btnActiv.Size = new System.Drawing.Size(201, 63);
            this.btnActiv.TabIndex = 4;
            this.btnActiv.Text = "Вид деятельности";
            this.btnActiv.UseVisualStyleBackColor = true;
            this.btnActiv.Click += new System.EventHandler(this.btnActiv_Click);
            // 
            // btnFreq
            // 
            this.btnFreq.Location = new System.Drawing.Point(50, 94);
            this.btnFreq.Name = "btnFreq";
            this.btnFreq.Size = new System.Drawing.Size(201, 63);
            this.btnFreq.TabIndex = 3;
            this.btnFreq.Text = "Частоты процессов";
            this.btnFreq.UseVisualStyleBackColor = true;
            this.btnFreq.Click += new System.EventHandler(this.btnFreq_Click);
            // 
            // btnSub3
            // 
            this.btnSub3.Location = new System.Drawing.Point(464, 25);
            this.btnSub3.Name = "btnSub3";
            this.btnSub3.Size = new System.Drawing.Size(201, 63);
            this.btnSub3.TabIndex = 2;
            this.btnSub3.Text = "Подразделение ур.3";
            this.btnSub3.UseVisualStyleBackColor = true;
            this.btnSub3.Click += new System.EventHandler(this.btnSub3_Click);
            // 
            // btnSub2
            // 
            this.btnSub2.Location = new System.Drawing.Point(257, 25);
            this.btnSub2.Name = "btnSub2";
            this.btnSub2.Size = new System.Drawing.Size(201, 63);
            this.btnSub2.TabIndex = 1;
            this.btnSub2.Text = "Подразделение ур.2";
            this.btnSub2.UseVisualStyleBackColor = true;
            this.btnSub2.Click += new System.EventHandler(this.btnSub2_Click);
            // 
            // btnSub1
            // 
            this.btnSub1.Location = new System.Drawing.Point(50, 25);
            this.btnSub1.Name = "btnSub1";
            this.btnSub1.Size = new System.Drawing.Size(201, 63);
            this.btnSub1.TabIndex = 0;
            this.btnSub1.Text = "Подразделение ур.1";
            this.btnSub1.UseVisualStyleBackColor = true;
            this.btnSub1.Click += new System.EventHandler(this.btnSub1_Click);
            // 
            // btnOwner
            // 
            this.btnOwner.Location = new System.Drawing.Point(133, 163);
            this.btnOwner.Name = "btnOwner";
            this.btnOwner.Size = new System.Drawing.Size(201, 63);
            this.btnOwner.TabIndex = 8;
            this.btnOwner.Text = "ФИО владельцев";
            this.btnOwner.UseVisualStyleBackColor = true;
            this.btnOwner.Click += new System.EventHandler(this.btnOwner_Click);
            // 
            // btnRtoValues
            // 
            this.btnRtoValues.Location = new System.Drawing.Point(464, 94);
            this.btnRtoValues.Name = "btnRtoValues";
            this.btnRtoValues.Size = new System.Drawing.Size(201, 63);
            this.btnRtoValues.TabIndex = 9;
            this.btnRtoValues.Text = "Значения RTO";
            this.btnRtoValues.UseVisualStyleBackColor = true;
            this.btnRtoValues.Click += new System.EventHandler(this.btnRtoValues_Click);
            // 
            // btnTarrifs
            // 
            this.btnTarrifs.Location = new System.Drawing.Point(351, 163);
            this.btnTarrifs.Name = "btnTarrifs";
            this.btnTarrifs.Size = new System.Drawing.Size(201, 63);
            this.btnTarrifs.TabIndex = 10;
            this.btnTarrifs.Text = "Названия тарифов";
            this.btnTarrifs.UseVisualStyleBackColor = true;
            this.btnTarrifs.Click += new System.EventHandler(this.btnTarrifs_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 797);
            this.Controls.Add(this.groupMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMain;
        private System.Windows.Forms.Button btnSub1;
        private System.Windows.Forms.Button btnSub3;
        private System.Windows.Forms.Button btnSub2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnActiv;
        private System.Windows.Forms.Button btnFreq;
        private System.Windows.Forms.Button btnAddiction;
        private System.Windows.Forms.Button btnRto;
        private System.Windows.Forms.Button btnOwner;
        private System.Windows.Forms.Button btnRtoValues;
        private System.Windows.Forms.Button btnTarrifs;
    }
}

