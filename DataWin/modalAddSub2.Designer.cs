namespace DataWin
{
    partial class modalAddSub2
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
            this.labelSub2 = new System.Windows.Forms.Label();
            this.comboSub1 = new System.Windows.Forms.ComboBox();
            this.textSub2 = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.labelSub1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSub2
            // 
            this.labelSub2.AutoSize = true;
            this.labelSub2.Location = new System.Drawing.Point(99, 84);
            this.labelSub2.Name = "labelSub2";
            this.labelSub2.Size = new System.Drawing.Size(290, 24);
            this.labelSub2.TabIndex = 9;
            this.labelSub2.Text = "Название подразделения (ур2)";
            // 
            // comboSub1
            // 
            this.comboSub1.FormattingEnabled = true;
            this.comboSub1.Location = new System.Drawing.Point(40, 36);
            this.comboSub1.Name = "comboSub1";
            this.comboSub1.Size = new System.Drawing.Size(382, 32);
            this.comboSub1.TabIndex = 8;
            // 
            // textSub2
            // 
            this.textSub2.Location = new System.Drawing.Point(40, 111);
            this.textSub2.Multiline = true;
            this.textSub2.Name = "textSub2";
            this.textSub2.Size = new System.Drawing.Size(382, 34);
            this.textSub2.TabIndex = 10;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(342, 169);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 60);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(10, 169);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 60);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // labelSub1
            // 
            this.labelSub1.AutoSize = true;
            this.labelSub1.Location = new System.Drawing.Point(98, 9);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(291, 24);
            this.labelSub1.TabIndex = 7;
            this.labelSub1.Text = "Название подразделение (ур1)";
            // 
            // modalAddSub2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 247);
            this.Controls.Add(this.labelSub2);
            this.Controls.Add(this.comboSub1);
            this.Controls.Add(this.textSub2);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.labelSub1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "modalAddSub2";
            this.Text = "Добавление подразделения ур.2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSub2;
        private System.Windows.Forms.ComboBox comboSub1;
        private System.Windows.Forms.TextBox textSub2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label labelSub1;
    }
}