namespace DataWin
{
    partial class modalAddTariff
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.labelTariff = new System.Windows.Forms.Label();
            this.textTariff = new System.Windows.Forms.TextBox();
            this.labelExp = new System.Windows.Forms.Label();
            this.textExp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.Location = new System.Drawing.Point(287, 179);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 51);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(12, 179);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(112, 51);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // labelTariff
            // 
            this.labelTariff.AutoSize = true;
            this.labelTariff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTariff.Location = new System.Drawing.Point(57, 9);
            this.labelTariff.Name = "labelTariff";
            this.labelTariff.Size = new System.Drawing.Size(293, 24);
            this.labelTariff.TabIndex = 17;
            this.labelTariff.Text = "Введите название тарифа НРД";
            // 
            // textTariff
            // 
            this.textTariff.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textTariff.Location = new System.Drawing.Point(23, 36);
            this.textTariff.Multiline = true;
            this.textTariff.Name = "textTariff";
            this.textTariff.Size = new System.Drawing.Size(364, 38);
            this.textTariff.TabIndex = 16;
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExp.Location = new System.Drawing.Point(156, 88);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(109, 24);
            this.labelExp.TabIndex = 20;
            this.labelExp.Text = "Пояснение";
            // 
            // textExp
            // 
            this.textExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textExp.Location = new System.Drawing.Point(23, 115);
            this.textExp.Multiline = true;
            this.textExp.Name = "textExp";
            this.textExp.Size = new System.Drawing.Size(364, 38);
            this.textExp.TabIndex = 21;
            // 
            // modalAddTariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 249);
            this.Controls.Add(this.textExp);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.labelTariff);
            this.Controls.Add(this.textTariff);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "modalAddTariff";
            this.Text = "Добавление тарифа НРД";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label labelTariff;
        private System.Windows.Forms.TextBox textTariff;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.TextBox textExp;
    }
}