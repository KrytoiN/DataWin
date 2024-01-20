namespace DataWin
{
    partial class addEditSub2
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
            this.groupExit = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupAddEdit = new System.Windows.Forms.GroupBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.dataGridSub2 = new System.Windows.Forms.DataGridView();
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.labelSub2 = new System.Windows.Forms.Label();
            this.labelSub1 = new System.Windows.Forms.Label();
            this.comboEditSub1 = new System.Windows.Forms.ComboBox();
            this.textEditSub2 = new System.Windows.Forms.TextBox();
            this.groupExit.SuspendLayout();
            this.groupAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSub2)).BeginInit();
            this.groupUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupExit
            // 
            this.groupExit.Controls.Add(this.exitBtn);
            this.groupExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupExit.Location = new System.Drawing.Point(768, 422);
            this.groupExit.Name = "groupExit";
            this.groupExit.Size = new System.Drawing.Size(234, 149);
            this.groupExit.TabIndex = 11;
            this.groupExit.TabStop = false;
            this.groupExit.Text = "Выход";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(46, 46);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 73);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupAddEdit
            // 
            this.groupAddEdit.Controls.Add(this.plusBtn);
            this.groupAddEdit.Controls.Add(this.minusBtn);
            this.groupAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAddEdit.Location = new System.Drawing.Point(768, 262);
            this.groupAddEdit.Name = "groupAddEdit";
            this.groupAddEdit.Size = new System.Drawing.Size(234, 137);
            this.groupAddEdit.TabIndex = 8;
            this.groupAddEdit.TabStop = false;
            this.groupAddEdit.Text = "Добавление/удаление";
            // 
            // plusBtn
            // 
            this.plusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusBtn.Location = new System.Drawing.Point(25, 28);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(179, 47);
            this.plusBtn.TabIndex = 9;
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
            this.minusBtn.TabIndex = 10;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // dataGridSub2
            // 
            this.dataGridSub2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridSub2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSub2.Location = new System.Drawing.Point(19, 24);
            this.dataGridSub2.Name = "dataGridSub2";
            this.dataGridSub2.Size = new System.Drawing.Size(696, 547);
            this.dataGridSub2.TabIndex = 1;
            this.dataGridSub2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSub2_CellClick);
            // 
            // groupUpdate
            // 
            this.groupUpdate.Controls.Add(this.textEditSub2);
            this.groupUpdate.Controls.Add(this.comboEditSub1);
            this.groupUpdate.Controls.Add(this.updateBtn);
            this.groupUpdate.Controls.Add(this.labelSub2);
            this.groupUpdate.Controls.Add(this.labelSub1);
            this.groupUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupUpdate.Location = new System.Drawing.Point(721, 12);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(317, 244);
            this.groupUpdate.TabIndex = 2;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Изменение записи";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.Location = new System.Drawing.Point(105, 176);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 47);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "Обновить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // labelSub2
            // 
            this.labelSub2.AutoSize = true;
            this.labelSub2.Location = new System.Drawing.Point(60, 111);
            this.labelSub2.Name = "labelSub2";
            this.labelSub2.Size = new System.Drawing.Size(194, 24);
            this.labelSub2.TabIndex = 5;
            this.labelSub2.Text = "Подразделение ур.2";
            // 
            // labelSub1
            // 
            this.labelSub1.AutoSize = true;
            this.labelSub1.Location = new System.Drawing.Point(60, 35);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(194, 24);
            this.labelSub1.TabIndex = 3;
            this.labelSub1.Text = "Подразделение ур.1";
            // 
            // comboEditSub1
            // 
            this.comboEditSub1.FormattingEnabled = true;
            this.comboEditSub1.Location = new System.Drawing.Point(22, 62);
            this.comboEditSub1.Name = "comboEditSub1";
            this.comboEditSub1.Size = new System.Drawing.Size(276, 32);
            this.comboEditSub1.TabIndex = 3;
            // 
            // textEditSub2
            // 
            this.textEditSub2.Location = new System.Drawing.Point(22, 138);
            this.textEditSub2.Multiline = true;
            this.textEditSub2.Name = "textEditSub2";
            this.textEditSub2.Size = new System.Drawing.Size(276, 32);
            this.textEditSub2.TabIndex = 4;
            // 
            // addEditSub2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 595);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.groupExit);
            this.Controls.Add(this.groupAddEdit);
            this.Controls.Add(this.dataGridSub2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addEditSub2";
            this.Text = "Подразделение ур.2";
            this.groupExit.ResumeLayout(false);
            this.groupAddEdit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSub2)).EndInit();
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupExit;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupAddEdit;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.DataGridView dataGridSub2;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Label labelSub2;
        private System.Windows.Forms.Label labelSub1;
        private System.Windows.Forms.TextBox textEditSub2;
        private System.Windows.Forms.ComboBox comboEditSub1;
    }
}