namespace create_form
{
    partial class FormTemperature
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
            this.lblInput = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.lblKelvin = new System.Windows.Forms.Label();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 9);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(139, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Введите температуру (°C):";
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(157, 6);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(100, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(15, 100);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(107, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "конвертировать";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(12, 36);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(70, 13);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.Text = "Фаренгейт: ";
            // 
            // lblKelvin
            // 
            this.lblKelvin.AutoSize = true;
            this.lblKelvin.Location = new System.Drawing.Point(12, 65);
            this.lblKelvin.Name = "lblKelvin";
            this.lblKelvin.Size = new System.Drawing.Size(56, 13);
            this.lblKelvin.TabIndex = 4;
            this.lblKelvin.Text = "Кельвин: ";
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(157, 100);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(107, 23);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Text = "Назад";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // FormTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 268);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.lblKelvin);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.lblInput);
            this.Name = "FormTemperature";
            this.Text = "FormTemperature";
            this.Load += new System.EventHandler(this.FormTemperature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Label lblKelvin;
        private System.Windows.Forms.Button btnMainMenu;
    }
}