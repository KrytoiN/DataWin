namespace DataWin
{
    partial class addEditOwners
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
            this.groupUpdate = new System.Windows.Forms.GroupBox();
            this.textEditOwner = new System.Windows.Forms.TextBox();
            this.labelSub1 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dataGridOwner = new System.Windows.Forms.DataGridView();
            this.groupExit.SuspendLayout();
            this.groupAddEdit.SuspendLayout();
            this.groupUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // groupExit
            // 
            this.groupExit.Controls.Add(this.exitBtn);
            this.groupExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupExit.Location = new System.Drawing.Point(775, 365);
            this.groupExit.Name = "groupExit";
            this.groupExit.Size = new System.Drawing.Size(234, 149);
            this.groupExit.TabIndex = 16;
            this.groupExit.TabStop = false;
            this.groupExit.Text = "Выход";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.Location = new System.Drawing.Point(46, 46);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(122, 73);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // groupAddEdit
            // 
            this.groupAddEdit.Controls.Add(this.plusBtn);
            this.groupAddEdit.Controls.Add(this.minusBtn);
            this.groupAddEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupAddEdit.Location = new System.Drawing.Point(775, 198);
            this.groupAddEdit.Name = "groupAddEdit";
            this.groupAddEdit.Size = new System.Drawing.Size(234, 137);
            this.groupAddEdit.TabIndex = 15;
            this.groupAddEdit.TabStop = false;
            this.groupAddEdit.Text = "Добавление/удаление";
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
            // groupUpdate
            // 
            this.groupUpdate.Controls.Add(this.textEditOwner);
            this.groupUpdate.Controls.Add(this.labelSub1);
            this.groupUpdate.Controls.Add(this.updateBtn);
            this.groupUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupUpdate.Location = new System.Drawing.Point(740, 12);
            this.groupUpdate.Name = "groupUpdate";
            this.groupUpdate.Size = new System.Drawing.Size(291, 168);
            this.groupUpdate.TabIndex = 14;
            this.groupUpdate.TabStop = false;
            this.groupUpdate.Text = "Изменение записи";
            // 
            // textEditOwner
            // 
            this.textEditOwner.Location = new System.Drawing.Point(9, 63);
            this.textEditOwner.Multiline = true;
            this.textEditOwner.Name = "textEditOwner";
            this.textEditOwner.Size = new System.Drawing.Size(273, 32);
            this.textEditOwner.TabIndex = 13;
            // 
            // labelSub1
            // 
            this.labelSub1.AutoSize = true;
            this.labelSub1.Location = new System.Drawing.Point(68, 36);
            this.labelSub1.Name = "labelSub1";
            this.labelSub1.Size = new System.Drawing.Size(155, 24);
            this.labelSub1.TabIndex = 6;
            this.labelSub1.Text = "ФИО владельца";
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateBtn.Location = new System.Drawing.Point(99, 101);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 47);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Обновить";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dataGridOwner
            // 
            this.dataGridOwner.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridOwner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOwner.Location = new System.Drawing.Point(12, 12);
            this.dataGridOwner.Name = "dataGridOwner";
            this.dataGridOwner.Size = new System.Drawing.Size(696, 502);
            this.dataGridOwner.TabIndex = 13;
            this.dataGridOwner.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOwner_CellClick);
            // 
            // addEditOwners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 545);
            this.Controls.Add(this.groupExit);
            this.Controls.Add(this.groupAddEdit);
            this.Controls.Add(this.groupUpdate);
            this.Controls.Add(this.dataGridOwner);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "addEditOwners";
            this.Text = "Владельцы";
            this.groupExit.ResumeLayout(false);
            this.groupAddEdit.ResumeLayout(false);
            this.groupUpdate.ResumeLayout(false);
            this.groupUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOwner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupExit;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.GroupBox groupAddEdit;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.GroupBox groupUpdate;
        private System.Windows.Forms.TextBox textEditOwner;
        private System.Windows.Forms.Label labelSub1;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dataGridOwner;
    }
}