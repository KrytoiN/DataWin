namespace DataWin
{
    partial class addEditProcess
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
            this.dataGridProcess = new System.Windows.Forms.DataGridView();
            this.groupUpdateProces = new System.Windows.Forms.GroupBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.textEditProc = new System.Windows.Forms.TextBox();
            this.comboEditActiv = new System.Windows.Forms.ComboBox();
            this.labelActiv = new System.Windows.Forms.Label();
            this.comboEditFreq = new System.Windows.Forms.ComboBox();
            this.comboEditSub3 = new System.Windows.Forms.ComboBox();
            this.labelFreq = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.labelSub3 = new System.Windows.Forms.Label();
            this.comboEditSub2 = new System.Windows.Forms.ComboBox();
            this.labelSub2 = new System.Windows.Forms.Label();
            this.comboEditSub1 = new System.Windows.Forms.ComboBox();
            this.labelSub1 = new System.Windows.Forms.Label();
            this.groupExitProces = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupAddEditProces = new System.Windows.Forms.GroupBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.comboEditTariff = new System.Windows.Forms.ComboBox();
            this.labelTariff = new System.Windows.Forms.Label();
            this.textEditRtoPrev = new System.Windows.Forms.TextBox();
            this.labelRtoPrev = new System.Windows.Forms.Label();
            this.comboEditOwner = new System.Windows.Forms.ComboBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.comboEditRtoVal = new System.Windows.Forms.ComboBox();
            this.labelRtoVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).BeginInit();
            this.groupUpdateProces.SuspendLayout();
            this.groupExitProces.SuspendLayout();
            this.groupAddEditProces.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProcess
            // 
            this.dataGridProcess.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridProcess.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProcess.Location = new System.Drawing.Point(15, 15);
            this.dataGridProcess.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridProcess.Name = "dataGridProcess";
            this.dataGridProcess.Size = new System.Drawing.Size(910, 1001);
            this.dataGridProcess.TabIndex = 22;
            this.dataGridProcess.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProcess_CellClick);
            // 
            // groupUpdateProces
            // 
            this.groupUpdateProces.Controls.Add(this.comboEditTariff);
            this.groupUpdateProces.Controls.Add(this.labelTariff);
            this.groupUpdateProces.Controls.Add(this.textEditRtoPrev);
            this.groupUpdateProces.Controls.Add(this.labelRtoPrev);
            this.groupUpdateProces.Controls.Add(this.updateBtn);
            this.groupUpdateProces.Controls.Add(this.comboEditOwner);
            this.groupUpdateProces.Controls.Add(this.labelOwner);
            this.groupUpdateProces.Controls.Add(this.comboEditRtoVal);
            this.groupUpdateProces.Controls.Add(this.labelRtoVal);
            this.groupUpdateProces.Controls.Add(this.labelProcess);
            this.groupUpdateProces.Controls.Add(this.textEditProc);
            this.groupUpdateProces.Controls.Add(this.comboEditActiv);
            this.groupUpdateProces.Controls.Add(this.labelActiv);
            this.groupUpdateProces.Controls.Add(this.comboEditFreq);
            this.groupUpdateProces.Controls.Add(this.comboEditSub3);
            this.groupUpdateProces.Controls.Add(this.labelFreq);
            this.groupUpdateProces.Controls.Add(this.labelSub3);
            this.groupUpdateProces.Controls.Add(this.comboEditSub2);
            this.groupUpdateProces.Controls.Add(this.labelSub2);
            this.groupUpdateProces.Controls.Add(this.comboEditSub1);
            this.groupUpdateProces.Controls.Add(this.labelSub1);
            this.groupUpdateProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupUpdateProces.Location = new System.Drawing.Point(1028, 15);
            this.groupUpdateProces.Name = "groupUpdateProces";
            this.groupUpdateProces.Size = new System.Drawing.Size(363, 844);
            this.groupUpdateProces.TabIndex = 26;
            this.groupUpdateProces.TabStop = false;
            this.groupUpdateProces.Text = "Изменение записи";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(142, 701);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(87, 24);
            this.labelProcess.TabIndex = 28;
            this.labelProcess.Text = "Процесс";
            // 
            // textEditProc
            // 
            this.textEditProc.Location = new System.Drawing.Point(18, 728);
            this.textEditProc.Multiline = true;
            this.textEditProc.Name = "textEditProc";
            this.textEditProc.Size = new System.Drawing.Size(311, 32);
            this.textEditProc.TabIndex = 27;
            // 
            // comboEditActiv
            // 
            this.comboEditActiv.FormattingEnabled = true;
            this.comboEditActiv.Location = new System.Drawing.Point(18, 357);
            this.comboEditActiv.Name = "comboEditActiv";
            this.comboEditActiv.Size = new System.Drawing.Size(311, 32);
            this.comboEditActiv.TabIndex = 26;
            // 
            // labelActiv
            // 
            this.labelActiv.AutoSize = true;
            this.labelActiv.Location = new System.Drawing.Point(83, 330);
            this.labelActiv.Name = "labelActiv";
            this.labelActiv.Size = new System.Drawing.Size(178, 24);
            this.labelActiv.TabIndex = 25;
            this.labelActiv.Text = "Вид деятельности";
            // 
            // comboEditFreq
            // 
            this.comboEditFreq.FormattingEnabled = true;
            this.comboEditFreq.Location = new System.Drawing.Point(18, 284);
            this.comboEditFreq.Name = "comboEditFreq";
            this.comboEditFreq.Size = new System.Drawing.Size(311, 32);
            this.comboEditFreq.TabIndex = 24;
            // 
            // comboEditSub3
            // 
            this.comboEditSub3.FormattingEnabled = true;
            this.comboEditSub3.Location = new System.Drawing.Point(18, 211);
            this.comboEditSub3.Name = "comboEditSub3";
            this.comboEditSub3.Size = new System.Drawing.Size(311, 32);
            this.comboEditSub3.TabIndex = 23;
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(92, 257);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(172, 24);
            this.labelFreq.TabIndex = 22;
            this.labelFreq.Text = "Частота процесса";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.Location = new System.Drawing.Point(128, 766);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(133, 62);
            this.updateBtn.TabIndex = 21;
            this.updateBtn.Text = "Обновить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // labelSub3
            // 
            this.labelSub3.AutoSize = true;
            this.labelSub3.Location = new System.Drawing.Point(82, 184);
            this.labelSub3.Name = "labelSub3";
            this.labelSub3.Size = new System.Drawing.Size(194, 24);
            this.labelSub3.TabIndex = 4;
            this.labelSub3.Text = "Подразделение ур.3";
            // 
            // comboEditSub2
            // 
            this.comboEditSub2.FormattingEnabled = true;
            this.comboEditSub2.Location = new System.Drawing.Point(18, 138);
            this.comboEditSub2.Name = "comboEditSub2";
            this.comboEditSub2.Size = new System.Drawing.Size(311, 32);
            this.comboEditSub2.TabIndex = 3;
            this.comboEditSub2.SelectedIndexChanged += new System.EventHandler(this.comboEditSub2_SelectedIndexChanged);
            // 
            // labelSub2
            // 
            this.labelSub2.AutoSize = true;
            this.labelSub2.Location = new System.Drawing.Point(82, 111);
            this.labelSub2.Name = "labelSub2";
            this.labelSub2.Size = new System.Drawing.Size(194, 24);
            this.labelSub2.TabIndex = 2;
            this.labelSub2.Text = "Подразделение ур.2";
            // 
            // comboEditSub1
            // 
            this.comboEditSub1.FormattingEnabled = true;
            this.comboEditSub1.Location = new System.Drawing.Point(18, 62);
            this.comboEditSub1.Name = "comboEditSub1";
            this.comboEditSub1.Size = new System.Drawing.Size(311, 32);
            this.comboEditSub1.TabIndex = 1;
            this.comboEditSub1.SelectedIndexChanged += new System.EventHandler(this.comboEditSub1_SelectedIndexChanged);
            // 
            // labelSub1
            // 
            this.labelSub1.AutoSize = true;
            this.labelSub1.Location = new System.Drawing.Point(82, 35);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(194, 24);
            this.labelSub1.TabIndex = 0;
            this.labelSub1.Text = "Подразделение ур.1";
            // 
            // groupExitProces
            // 
            this.groupExitProces.Controls.Add(this.exitBtn);
            this.groupExitProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupExitProces.Location = new System.Drawing.Point(1209, 879);
            this.groupExitProces.Name = "groupExitProces";
            this.groupExitProces.Size = new System.Drawing.Size(234, 137);
            this.groupExitProces.TabIndex = 29;
            this.groupExitProces.TabStop = false;
            this.groupExitProces.Text = "Выход";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(39, 44);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(143, 74);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "Выход";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupAddEditProces
            // 
            this.groupAddEditProces.Controls.Add(this.plusBtn);
            this.groupAddEditProces.Controls.Add(this.minusBtn);
            this.groupAddEditProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAddEditProces.Location = new System.Drawing.Point(938, 879);
            this.groupAddEditProces.Name = "groupAddEditProces";
            this.groupAddEditProces.Size = new System.Drawing.Size(234, 137);
            this.groupAddEditProces.TabIndex = 28;
            this.groupAddEditProces.TabStop = false;
            this.groupAddEditProces.Text = "Добавление/удаление";
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(25, 28);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(179, 47);
            this.plusBtn.TabIndex = 1;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusBtn.Location = new System.Drawing.Point(25, 81);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(179, 47);
            this.minusBtn.TabIndex = 2;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // comboEditTariff
            // 
            this.comboEditTariff.FormattingEnabled = true;
            this.comboEditTariff.Location = new System.Drawing.Point(18, 652);
            this.comboEditTariff.Name = "comboEditTariff";
            this.comboEditTariff.Size = new System.Drawing.Size(311, 32);
            this.comboEditTariff.TabIndex = 63;
            // 
            // labelTariff
            // 
            this.labelTariff.AutoSize = true;
            this.labelTariff.Location = new System.Drawing.Point(151, 625);
            this.labelTariff.Name = "labelTariff";
            this.labelTariff.Size = new System.Drawing.Size(68, 24);
            this.labelTariff.TabIndex = 62;
            this.labelTariff.Text = "Тариф";
            // 
            // textEditRtoPrev
            // 
            this.textEditRtoPrev.Location = new System.Drawing.Point(18, 579);
            this.textEditRtoPrev.Multiline = true;
            this.textEditRtoPrev.Name = "textEditRtoPrev";
            this.textEditRtoPrev.Size = new System.Drawing.Size(311, 32);
            this.textEditRtoPrev.TabIndex = 61;
            // 
            // labelRtoPrev
            // 
            this.labelRtoPrev.AutoSize = true;
            this.labelRtoPrev.Location = new System.Drawing.Point(95, 552);
            this.labelRtoPrev.Name = "labelRtoPrev";
            this.labelRtoPrev.Size = new System.Drawing.Size(169, 24);
            this.labelRtoPrev.TabIndex = 60;
            this.labelRtoPrev.Text = "RTO предыдущее";
            // 
            // comboEditOwner
            // 
            this.comboEditOwner.FormattingEnabled = true;
            this.comboEditOwner.Location = new System.Drawing.Point(18, 430);
            this.comboEditOwner.Name = "comboEditOwner";
            this.comboEditOwner.Size = new System.Drawing.Size(311, 32);
            this.comboEditOwner.TabIndex = 59;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(89, 403);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(187, 24);
            this.labelOwner.TabIndex = 58;
            this.labelOwner.Text = "Владелец процесса";
            // 
            // comboEditRtoVal
            // 
            this.comboEditRtoVal.FormattingEnabled = true;
            this.comboEditRtoVal.Location = new System.Drawing.Point(18, 504);
            this.comboEditRtoVal.Name = "comboEditRtoVal";
            this.comboEditRtoVal.Size = new System.Drawing.Size(311, 32);
            this.comboEditRtoVal.TabIndex = 57;
            // 
            // labelRtoVal
            // 
            this.labelRtoVal.AutoSize = true;
            this.labelRtoVal.Location = new System.Drawing.Point(112, 477);
            this.labelRtoVal.Name = "labelRtoVal";
            this.labelRtoVal.Size = new System.Drawing.Size(143, 24);
            this.labelRtoVal.TabIndex = 56;
            this.labelRtoVal.Text = "Значение RTO";
            // 
            // addEditProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 1040);
            this.Controls.Add(this.groupExitProces);
            this.Controls.Add(this.groupAddEditProces);
            this.Controls.Add(this.groupUpdateProces);
            this.Controls.Add(this.dataGridProcess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "addEditProcess";
            this.Text = "Процессы";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProcess)).EndInit();
            this.groupUpdateProces.ResumeLayout(false);
            this.groupUpdateProces.PerformLayout();
            this.groupExitProces.ResumeLayout(false);
            this.groupAddEditProces.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProcess;
        private System.Windows.Forms.GroupBox groupUpdateProces;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.TextBox textEditProc;
        private System.Windows.Forms.ComboBox comboEditActiv;
        private System.Windows.Forms.Label labelActiv;
        private System.Windows.Forms.ComboBox comboEditFreq;
        private System.Windows.Forms.ComboBox comboEditSub3;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label labelSub3;
        private System.Windows.Forms.ComboBox comboEditSub2;
        private System.Windows.Forms.Label labelSub2;
        private System.Windows.Forms.ComboBox comboEditSub1;
        private System.Windows.Forms.Label labelSub1;
        private System.Windows.Forms.GroupBox groupExitProces;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupAddEditProces;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.ComboBox comboEditTariff;
        private System.Windows.Forms.Label labelTariff;
        private System.Windows.Forms.TextBox textEditRtoPrev;
        private System.Windows.Forms.Label labelRtoPrev;
        private System.Windows.Forms.ComboBox comboEditOwner;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.ComboBox comboEditRtoVal;
        private System.Windows.Forms.Label labelRtoVal;
    }
}