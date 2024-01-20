namespace DataWin
{
    partial class modalAddProcess
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
            this.comboSub1 = new System.Windows.Forms.ComboBox();
            this.comboSub2 = new System.Windows.Forms.ComboBox();
            this.comboSub3 = new System.Windows.Forms.ComboBox();
            this.comboFreq = new System.Windows.Forms.ComboBox();
            this.comboActiv = new System.Windows.Forms.ComboBox();
            this.textProc = new System.Windows.Forms.TextBox();
            this.labelProc = new System.Windows.Forms.Label();
            this.labelActiv = new System.Windows.Forms.Label();
            this.labelFreq = new System.Windows.Forms.Label();
            this.labelSub3 = new System.Windows.Forms.Label();
            this.labelSub2 = new System.Windows.Forms.Label();
            this.labelSub1 = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.labelRtoVal = new System.Windows.Forms.Label();
            this.comboRtoVal = new System.Windows.Forms.ComboBox();
            this.labelOwner = new System.Windows.Forms.Label();
            this.comboOwner = new System.Windows.Forms.ComboBox();
            this.labelRtoPrev = new System.Windows.Forms.Label();
            this.textRtoPrev = new System.Windows.Forms.TextBox();
            this.labelTariff = new System.Windows.Forms.Label();
            this.comboTariff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboSub1
            // 
            this.comboSub1.FormattingEnabled = true;
            this.comboSub1.Location = new System.Drawing.Point(81, 36);
            this.comboSub1.Name = "comboSub1";
            this.comboSub1.Size = new System.Drawing.Size(311, 32);
            this.comboSub1.TabIndex = 35;
            this.comboSub1.SelectedIndexChanged += new System.EventHandler(this.comboSub1_SelectedIndexChanged);
            // 
            // comboSub2
            // 
            this.comboSub2.FormattingEnabled = true;
            this.comboSub2.Items.AddRange(new object[] {
            "null"});
            this.comboSub2.Location = new System.Drawing.Point(81, 110);
            this.comboSub2.Name = "comboSub2";
            this.comboSub2.Size = new System.Drawing.Size(311, 32);
            this.comboSub2.TabIndex = 37;
            this.comboSub2.SelectedIndexChanged += new System.EventHandler(this.comboSub2_SelectedIndexChanged);
            // 
            // comboSub3
            // 
            this.comboSub3.FormattingEnabled = true;
            this.comboSub3.Location = new System.Drawing.Point(81, 190);
            this.comboSub3.Name = "comboSub3";
            this.comboSub3.Size = new System.Drawing.Size(311, 32);
            this.comboSub3.TabIndex = 39;
            // 
            // comboFreq
            // 
            this.comboFreq.FormattingEnabled = true;
            this.comboFreq.Location = new System.Drawing.Point(81, 270);
            this.comboFreq.Name = "comboFreq";
            this.comboFreq.Size = new System.Drawing.Size(311, 32);
            this.comboFreq.TabIndex = 41;
            // 
            // comboActiv
            // 
            this.comboActiv.FormattingEnabled = true;
            this.comboActiv.Location = new System.Drawing.Point(81, 351);
            this.comboActiv.Name = "comboActiv";
            this.comboActiv.Size = new System.Drawing.Size(311, 32);
            this.comboActiv.TabIndex = 43;
            // 
            // textProc
            // 
            this.textProc.Location = new System.Drawing.Point(81, 745);
            this.textProc.Multiline = true;
            this.textProc.Name = "textProc";
            this.textProc.Size = new System.Drawing.Size(311, 32);
            this.textProc.TabIndex = 45;
            // 
            // labelProc
            // 
            this.labelProc.AutoSize = true;
            this.labelProc.Location = new System.Drawing.Point(143, 718);
            this.labelProc.Name = "labelProc";
            this.labelProc.Size = new System.Drawing.Size(187, 24);
            this.labelProc.TabIndex = 44;
            this.labelProc.Text = "Название процесса";
            // 
            // labelActiv
            // 
            this.labelActiv.AutoSize = true;
            this.labelActiv.Location = new System.Drawing.Point(152, 324);
            this.labelActiv.Name = "labelActiv";
            this.labelActiv.Size = new System.Drawing.Size(178, 24);
            this.labelActiv.TabIndex = 42;
            this.labelActiv.Text = "Вид деятельности";
            // 
            // labelFreq
            // 
            this.labelFreq.AutoSize = true;
            this.labelFreq.Location = new System.Drawing.Point(152, 243);
            this.labelFreq.Name = "labelFreq";
            this.labelFreq.Size = new System.Drawing.Size(172, 24);
            this.labelFreq.TabIndex = 40;
            this.labelFreq.Text = "Частота процесса";
            // 
            // labelSub3
            // 
            this.labelSub3.AutoSize = true;
            this.labelSub3.Location = new System.Drawing.Point(135, 163);
            this.labelSub3.Name = "labelSub3";
            this.labelSub3.Size = new System.Drawing.Size(201, 24);
            this.labelSub3.TabIndex = 38;
            this.labelSub3.Text = "Подразделение(ур.3)";
            // 
            // labelSub2
            // 
            this.labelSub2.AutoSize = true;
            this.labelSub2.Location = new System.Drawing.Point(135, 83);
            this.labelSub2.Name = "labelSub2";
            this.labelSub2.Size = new System.Drawing.Size(201, 24);
            this.labelSub2.TabIndex = 36;
            this.labelSub2.Text = "Подразделение(ур.2)";
            // 
            // labelSub1
            // 
            this.labelSub1.AutoSize = true;
            this.labelSub1.Location = new System.Drawing.Point(135, 9);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(201, 24);
            this.labelSub1.TabIndex = 34;
            this.labelSub1.Text = "Подразделение(ур.1)";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(295, 803);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(137, 61);
            this.cancelBtn.TabIndex = 47;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(13, 803);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(137, 61);
            this.addBtn.TabIndex = 46;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // labelRtoVal
            // 
            this.labelRtoVal.AutoSize = true;
            this.labelRtoVal.Location = new System.Drawing.Point(172, 475);
            this.labelRtoVal.Name = "labelRtoVal";
            this.labelRtoVal.Size = new System.Drawing.Size(143, 24);
            this.labelRtoVal.TabIndex = 48;
            this.labelRtoVal.Text = "Значение RTO";
            // 
            // comboRtoVal
            // 
            this.comboRtoVal.FormattingEnabled = true;
            this.comboRtoVal.Location = new System.Drawing.Point(81, 502);
            this.comboRtoVal.Name = "comboRtoVal";
            this.comboRtoVal.Size = new System.Drawing.Size(311, 32);
            this.comboRtoVal.TabIndex = 49;
            // 
            // labelOwner
            // 
            this.labelOwner.AutoSize = true;
            this.labelOwner.Location = new System.Drawing.Point(152, 400);
            this.labelOwner.Name = "labelOwner";
            this.labelOwner.Size = new System.Drawing.Size(187, 24);
            this.labelOwner.TabIndex = 50;
            this.labelOwner.Text = "Владелец процесса";
            // 
            // comboOwner
            // 
            this.comboOwner.FormattingEnabled = true;
            this.comboOwner.Location = new System.Drawing.Point(81, 427);
            this.comboOwner.Name = "comboOwner";
            this.comboOwner.Size = new System.Drawing.Size(311, 32);
            this.comboOwner.TabIndex = 51;
            // 
            // labelRtoPrev
            // 
            this.labelRtoPrev.AutoSize = true;
            this.labelRtoPrev.Location = new System.Drawing.Point(155, 557);
            this.labelRtoPrev.Name = "labelRtoPrev";
            this.labelRtoPrev.Size = new System.Drawing.Size(169, 24);
            this.labelRtoPrev.TabIndex = 52;
            this.labelRtoPrev.Text = "RTO предыдущее";
            // 
            // textRtoPrev
            // 
            this.textRtoPrev.Location = new System.Drawing.Point(81, 584);
            this.textRtoPrev.Multiline = true;
            this.textRtoPrev.Name = "textRtoPrev";
            this.textRtoPrev.Size = new System.Drawing.Size(311, 32);
            this.textRtoPrev.TabIndex = 53;
            // 
            // labelTariff
            // 
            this.labelTariff.AutoSize = true;
            this.labelTariff.Location = new System.Drawing.Point(209, 636);
            this.labelTariff.Name = "labelTariff";
            this.labelTariff.Size = new System.Drawing.Size(68, 24);
            this.labelTariff.TabIndex = 54;
            this.labelTariff.Text = "Тариф";
            // 
            // comboTariff
            // 
            this.comboTariff.FormattingEnabled = true;
            this.comboTariff.Location = new System.Drawing.Point(81, 663);
            this.comboTariff.Name = "comboTariff";
            this.comboTariff.Size = new System.Drawing.Size(311, 32);
            this.comboTariff.TabIndex = 55;
            // 
            // modalAddProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 877);
            this.Controls.Add(this.comboTariff);
            this.Controls.Add(this.labelTariff);
            this.Controls.Add(this.textRtoPrev);
            this.Controls.Add(this.labelRtoPrev);
            this.Controls.Add(this.comboOwner);
            this.Controls.Add(this.labelOwner);
            this.Controls.Add(this.comboRtoVal);
            this.Controls.Add(this.labelRtoVal);
            this.Controls.Add(this.comboSub1);
            this.Controls.Add(this.comboSub2);
            this.Controls.Add(this.comboSub3);
            this.Controls.Add(this.comboFreq);
            this.Controls.Add(this.comboActiv);
            this.Controls.Add(this.textProc);
            this.Controls.Add(this.labelProc);
            this.Controls.Add(this.labelActiv);
            this.Controls.Add(this.labelFreq);
            this.Controls.Add(this.labelSub3);
            this.Controls.Add(this.labelSub2);
            this.Controls.Add(this.labelSub1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "modalAddProcess";
            this.Text = "Добавление процесса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSub1;
        private System.Windows.Forms.ComboBox comboSub2;
        private System.Windows.Forms.ComboBox comboSub3;
        private System.Windows.Forms.ComboBox comboFreq;
        private System.Windows.Forms.ComboBox comboActiv;
        private System.Windows.Forms.TextBox textProc;
        private System.Windows.Forms.Label labelProc;
        private System.Windows.Forms.Label labelActiv;
        private System.Windows.Forms.Label labelFreq;
        private System.Windows.Forms.Label labelSub3;
        private System.Windows.Forms.Label labelSub2;
        private System.Windows.Forms.Label labelSub1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label labelRtoVal;
        private System.Windows.Forms.ComboBox comboRtoVal;
        private System.Windows.Forms.Label labelOwner;
        private System.Windows.Forms.ComboBox comboOwner;
        private System.Windows.Forms.Label labelRtoPrev;
        private System.Windows.Forms.TextBox textRtoPrev;
        private System.Windows.Forms.Label labelTariff;
        private System.Windows.Forms.ComboBox comboTariff;
    }
}