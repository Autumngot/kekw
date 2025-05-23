namespace create_form
{
    partial class FormNotepad
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.nudLength = new System.Windows.Forms.NumericUpDown();
            this.lblLength = new System.Windows.Forms.Label();
            this.cbSymbols = new System.Windows.Forms.CheckBox();
            this.cbDigits = new System.Windows.Forms.CheckBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(634, 41);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(114, 23);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "Новый";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(634, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(114, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Открыть";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(634, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(319, 14);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(309, 154);
            this.rtbText.TabIndex = 3;
            this.rtbText.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.nudLength);
            this.groupBox1.Controls.Add(this.lblLength);
            this.groupBox1.Controls.Add(this.cbSymbols);
            this.groupBox1.Controls.Add(this.cbDigits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Генерация пароля";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(17, 24);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.ReadOnly = true;
            this.tbPassword.Size = new System.Drawing.Size(255, 20);
            this.tbPassword.TabIndex = 11;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(72, 119);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(114, 23);
            this.btnGenerate.TabIndex = 9;
            this.btnGenerate.Text = "Сгенерировать";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // nudLength
            // 
            this.nudLength.Location = new System.Drawing.Point(63, 61);
            this.nudLength.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudLength.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudLength.Name = "nudLength";
            this.nudLength.Size = new System.Drawing.Size(41, 20);
            this.nudLength.TabIndex = 6;
            this.nudLength.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(14, 63);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(43, 13);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "Длина:";
            this.lblLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbSymbols
            // 
            this.cbSymbols.AutoSize = true;
            this.cbSymbols.Location = new System.Drawing.Point(129, 87);
            this.cbSymbols.Name = "cbSymbols";
            this.cbSymbols.Size = new System.Drawing.Size(72, 17);
            this.cbSymbols.TabIndex = 8;
            this.cbSymbols.Text = "символы";
            this.cbSymbols.UseVisualStyleBackColor = true;
            // 
            // cbDigits
            // 
            this.cbDigits.AutoSize = true;
            this.cbDigits.Checked = true;
            this.cbDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDigits.Location = new System.Drawing.Point(129, 64);
            this.cbDigits.Name = "cbDigits";
            this.cbDigits.Size = new System.Drawing.Size(60, 17);
            this.cbDigits.TabIndex = 7;
            this.cbDigits.Text = "цифры";
            this.cbDigits.UseVisualStyleBackColor = true;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(634, 99);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(113, 23);
            this.btnMainMenu.TabIndex = 10;
            this.btnMainMenu.Text = "Назад";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // FormNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 376);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnNew);
            this.Name = "FormNotepad";
            this.Text = "FormNotepad";
            this.Load += new System.EventHandler(this.FormNotepad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLength)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown nudLength;
        private System.Windows.Forms.CheckBox cbDigits;
        private System.Windows.Forms.CheckBox cbSymbols;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.TextBox tbPassword;
    }
}