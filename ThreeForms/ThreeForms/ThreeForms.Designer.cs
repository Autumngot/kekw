namespace create_form
{
    partial class ThreeForms
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNotepad = new System.Windows.Forms.Button();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNotepad
            // 
            this.btnNotepad.Location = new System.Drawing.Point(82, 12);
            this.btnNotepad.Name = "btnNotepad";
            this.btnNotepad.Size = new System.Drawing.Size(474, 88);
            this.btnNotepad.TabIndex = 0;
            this.btnNotepad.Text = "простой блокнот с генерацией случайных паролей";
            this.btnNotepad.UseVisualStyleBackColor = true;
            this.btnNotepad.Click += new System.EventHandler(this.btnNotepad_Click);
            // 
            // btnTemperature
            // 
            this.btnTemperature.Location = new System.Drawing.Point(82, 106);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(474, 88);
            this.btnTemperature.TabIndex = 1;
            this.btnTemperature.Text = "конвертер температуры";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.btnTemperature_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(82, 200);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(474, 64);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "открытие изображений";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // ThreeForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 366);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.btnNotepad);
            this.Name = "ThreeForms";
            this.Text = "ThreeForms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNotepad;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.Button btnImage;
    }
}

