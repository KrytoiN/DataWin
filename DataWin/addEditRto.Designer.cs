namespace DataWin
{
    partial class addEditRto
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
            this.dataGridRto = new System.Windows.Forms.DataGridView();
            this.groupExitProces = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupAddEditProces = new System.Windows.Forms.GroupBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.groupUpdateRto = new System.Windows.Forms.GroupBox();
            this.labelProcess = new System.Windows.Forms.Label();
            this.comboEditSub3 = new System.Windows.Forms.ComboBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.labelSub3 = new System.Windows.Forms.Label();
            this.comboEditSub2 = new System.Windows.Forms.ComboBox();
            this.labelSub2 = new System.Windows.Forms.Label();
            this.comboEditSub1 = new System.Windows.Forms.ComboBox();
            this.labelSub1 = new System.Windows.Forms.Label();
            this.comboEditProcess = new System.Windows.Forms.ComboBox();
            this.labelDowntime = new System.Windows.Forms.Label();
            this.comboEditDowntime = new System.Windows.Forms.ComboBox();
            this.labelRto = new System.Windows.Forms.Label();
            this.textRto = new System.Windows.Forms.TextBox();
            this.labelRtoPrev = new System.Windows.Forms.Label();
            this.textRtoPrev = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRto)).BeginInit();
            this.groupExitProces.SuspendLayout();
            this.groupAddEditProces.SuspendLayout();
            this.groupUpdateRto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRto
            // 
            this.dataGridRto.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridRto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRto.Location = new System.Drawing.Point(6, 13);
            this.dataGridRto.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridRto.Name = "dataGridRto";
            this.dataGridRto.Size = new System.Drawing.Size(914, 791);
            this.dataGridRto.TabIndex = 23;
            this.dataGridRto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRto_CellClick);
            // 
            // groupExitProces
            // 
            this.groupExitProces.Controls.Add(this.exitBtn);
            this.groupExitProces.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupExitProces.Location = new System.Drawing.Point(1181, 667);
            this.groupExitProces.Name = "groupExitProces";
            this.groupExitProces.Size = new System.Drawing.Size(234, 137);
            this.groupExitProces.TabIndex = 32;
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
            this.groupAddEditProces.Location = new System.Drawing.Point(929, 667);
            this.groupAddEditProces.Name = "groupAddEditProces";
            this.groupAddEditProces.Size = new System.Drawing.Size(234, 137);
            this.groupAddEditProces.TabIndex = 31;
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
            // groupUpdateRto
            // 
            this.groupUpdateRto.Controls.Add(this.textRtoPrev);
            this.groupUpdateRto.Controls.Add(this.labelRtoPrev);
            this.groupUpdateRto.Controls.Add(this.textRto);
            this.groupUpdateRto.Controls.Add(this.labelRto);
            this.groupUpdateRto.Controls.Add(this.comboEditDowntime);
            this.groupUpdateRto.Controls.Add(this.labelDowntime);
            this.groupUpdateRto.Controls.Add(this.comboEditProcess);
            this.groupUpdateRto.Controls.Add(this.labelProcess);
            this.groupUpdateRto.Controls.Add(this.comboEditSub3);
            this.groupUpdateRto.Controls.Add(this.updateBtn);
            this.groupUpdateRto.Controls.Add(this.labelSub3);
            this.groupUpdateRto.Controls.Add(this.comboEditSub2);
            this.groupUpdateRto.Controls.Add(this.labelSub2);
            this.groupUpdateRto.Controls.Add(this.comboEditSub1);
            this.groupUpdateRto.Controls.Add(this.labelSub1);
            this.groupUpdateRto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupUpdateRto.Location = new System.Drawing.Point(1016, 14);
            this.groupUpdateRto.Name = "groupUpdateRto";
            this.groupUpdateRto.Size = new System.Drawing.Size(317, 647);
            this.groupUpdateRto.TabIndex = 30;
            this.groupUpdateRto.TabStop = false;
            this.groupUpdateRto.Text = "Изменение записи";
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(113, 260);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(87, 24);
            this.labelProcess.TabIndex = 28;
            this.labelProcess.Text = "Процесс";
            // 
            // comboEditSub3
            // 
            this.comboEditSub3.FormattingEnabled = true;
            this.comboEditSub3.Location = new System.Drawing.Point(18, 211);
            this.comboEditSub3.Name = "comboEditSub3";
            this.comboEditSub3.Size = new System.Drawing.Size(273, 32);
            this.comboEditSub3.TabIndex = 23;
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.Location = new System.Drawing.Point(94, 568);
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
            this.labelSub3.Location = new System.Drawing.Point(60, 184);
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
            this.comboEditSub2.Size = new System.Drawing.Size(273, 32);
            this.comboEditSub2.TabIndex = 3;
            // 
            // labelSub2
            // 
            this.labelSub2.AutoSize = true;
            this.labelSub2.Location = new System.Drawing.Point(60, 111);
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
            this.comboEditSub1.Size = new System.Drawing.Size(273, 32);
            this.comboEditSub1.TabIndex = 1;
            // 
            // labelSub1
            // 
            this.labelSub1.AutoSize = true;
            this.labelSub1.Location = new System.Drawing.Point(60, 35);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(194, 24);
            this.labelSub1.TabIndex = 0;
            this.labelSub1.Text = "Подразделение ур.1";
            // 
            // comboEditProcess
            // 
            this.comboEditProcess.FormattingEnabled = true;
            this.comboEditProcess.Location = new System.Drawing.Point(18, 287);
            this.comboEditProcess.Name = "comboEditProcess";
            this.comboEditProcess.Size = new System.Drawing.Size(273, 32);
            this.comboEditProcess.TabIndex = 29;
            // 
            // labelDowntime
            // 
            this.labelDowntime.AutoSize = true;
            this.labelDowntime.Location = new System.Drawing.Point(63, 332);
            this.labelDowntime.Name = "labelDowntime";
            this.labelDowntime.Size = new System.Drawing.Size(191, 24);
            this.labelDowntime.TabIndex = 30;
            this.labelDowntime.Text = "Влияние от простоя";
            // 
            // comboEditDowntime
            // 
            this.comboEditDowntime.FormattingEnabled = true;
            this.comboEditDowntime.Items.AddRange(new object[] {
            "Прямые потери - финансовый ущерб",
            "Косвенные потери - Регуляторное влияние",
            "Косвенные потери - Влияние на репутацию",
            "Косвенные потери - Влияние на операционную деятельность",
            "Косвенные потери - Правовое влияние "});
            this.comboEditDowntime.Location = new System.Drawing.Point(18, 359);
            this.comboEditDowntime.Name = "comboEditDowntime";
            this.comboEditDowntime.Size = new System.Drawing.Size(273, 32);
            this.comboEditDowntime.TabIndex = 31;
            // 
            // labelRto
            // 
            this.labelRto.AutoSize = true;
            this.labelRto.Location = new System.Drawing.Point(132, 405);
            this.labelRto.Name = "labelRto";
            this.labelRto.Size = new System.Drawing.Size(50, 24);
            this.labelRto.TabIndex = 32;
            this.labelRto.Text = "RTO";
            // 
            // textRto
            // 
            this.textRto.Location = new System.Drawing.Point(18, 432);
            this.textRto.Multiline = true;
            this.textRto.Name = "textRto";
            this.textRto.Size = new System.Drawing.Size(273, 32);
            this.textRto.TabIndex = 33;
            // 
            // labelRtoPrev
            // 
            this.labelRtoPrev.AutoSize = true;
            this.labelRtoPrev.Location = new System.Drawing.Point(75, 478);
            this.labelRtoPrev.Name = "labelRtoPrev";
            this.labelRtoPrev.Size = new System.Drawing.Size(169, 24);
            this.labelRtoPrev.TabIndex = 34;
            this.labelRtoPrev.Text = "RTO предыдущее";
            // 
            // textRtoPrev
            // 
            this.textRtoPrev.Location = new System.Drawing.Point(18, 505);
            this.textRtoPrev.Multiline = true;
            this.textRtoPrev.Name = "textRtoPrev";
            this.textRtoPrev.Size = new System.Drawing.Size(273, 32);
            this.textRtoPrev.TabIndex = 35;
            // 
            // addEditRto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 816);
            this.Controls.Add(this.groupExitProces);
            this.Controls.Add(this.groupAddEditProces);
            this.Controls.Add(this.groupUpdateRto);
            this.Controls.Add(this.dataGridRto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addEditRto";
            this.Text = "RTO";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRto)).EndInit();
            this.groupExitProces.ResumeLayout(false);
            this.groupAddEditProces.ResumeLayout(false);
            this.groupUpdateRto.ResumeLayout(false);
            this.groupUpdateRto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRto;
        private System.Windows.Forms.GroupBox groupExitProces;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupAddEditProces;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.GroupBox groupUpdateRto;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.ComboBox comboEditSub3;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label labelSub3;
        private System.Windows.Forms.ComboBox comboEditSub2;
        private System.Windows.Forms.Label labelSub2;
        private System.Windows.Forms.ComboBox comboEditSub1;
        private System.Windows.Forms.Label labelSub1;
        private System.Windows.Forms.ComboBox comboEditProcess;
        private System.Windows.Forms.ComboBox comboEditDowntime;
        private System.Windows.Forms.Label labelDowntime;
        private System.Windows.Forms.TextBox textRto;
        private System.Windows.Forms.Label labelRto;
        private System.Windows.Forms.TextBox textRtoPrev;
        private System.Windows.Forms.Label labelRtoPrev;
    }
}