namespace DataWin
{
    partial class modalAddSub3
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
            this.labelSub1 = new System.Windows.Forms.Label();
            this.labelSub3 = new System.Windows.Forms.Label();
            this.comboSub2 = new System.Windows.Forms.ComboBox();
            this.textSub3 = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.labelSub2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboSub1
            // 
            this.comboSub1.FormattingEnabled = true;
            this.comboSub1.Location = new System.Drawing.Point(40, 36);
            this.comboSub1.Name = "comboSub1";
            this.comboSub1.Size = new System.Drawing.Size(382, 32);
            this.comboSub1.TabIndex = 10;
            this.comboSub1.SelectedIndexChanged += new System.EventHandler(this.comboSub1_SelectedIndexChanged);
            // 
            // labelSub1
            // 
            this.labelSub1.AutoSize = true;
            this.labelSub1.Location = new System.Drawing.Point(98, 9);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(291, 24);
            this.labelSub1.TabIndex = 9;
            this.labelSub1.Text = "Название подразделение (ур1)";
            // 
            // labelSub3
            // 
            this.labelSub3.AutoSize = true;
            this.labelSub3.Location = new System.Drawing.Point(99, 153);
            this.labelSub3.Name = "labelSub3";
            this.labelSub3.Size = new System.Drawing.Size(290, 24);
            this.labelSub3.TabIndex = 13;
            this.labelSub3.Text = "Название подразделения (ур3)";
            // 
            // comboSub2
            // 
            this.comboSub2.FormattingEnabled = true;
            this.comboSub2.Location = new System.Drawing.Point(40, 105);
            this.comboSub2.Name = "comboSub2";
            this.comboSub2.Size = new System.Drawing.Size(382, 32);
            this.comboSub2.TabIndex = 12;
            // 
            // textSub3
            // 
            this.textSub3.Location = new System.Drawing.Point(40, 180);
            this.textSub3.Multiline = true;
            this.textSub3.Name = "textSub3";
            this.textSub3.Size = new System.Drawing.Size(382, 34);
            this.textSub3.TabIndex = 14;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(342, 238);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 60);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(10, 238);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 60);
            this.addBtn.TabIndex = 15;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // labelSub2
            // 
            this.labelSub2.AutoSize = true;
            this.labelSub2.Location = new System.Drawing.Point(98, 78);
            this.labelSub2.Name = "labelSub2";
            this.labelSub2.Size = new System.Drawing.Size(291, 24);
            this.labelSub2.TabIndex = 11;
            this.labelSub2.Text = "Название подразделение (ур2)";
            // 
            // modalAddSub3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 315);
            this.Controls.Add(this.comboSub1);
            this.Controls.Add(this.labelSub1);
            this.Controls.Add(this.labelSub3);
            this.Controls.Add(this.comboSub2);
            this.Controls.Add(this.textSub3);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.labelSub2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "modalAddSub3";
            this.Text = "Добавление подразделения ур.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSub1;
        private System.Windows.Forms.Label labelSub1;
        private System.Windows.Forms.Label labelSub3;
        private System.Windows.Forms.ComboBox comboSub2;
        private System.Windows.Forms.TextBox textSub3;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label labelSub2;
    }
}