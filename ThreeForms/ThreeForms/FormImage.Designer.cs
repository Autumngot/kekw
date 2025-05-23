namespace create_form
{
    partial class FormImage
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(12, 12);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(617, 355);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pbImage_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 373);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(157, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Загрузить изображение";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(175, 373);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(49, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Ширина:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(176, 412);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(48, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Высота:";
            // 
            // nudWidth
            // 
            this.nudWidth.Location = new System.Drawing.Point(178, 389);
            this.nudWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(120, 20);
            this.nudWidth.TabIndex = 4;
            this.nudWidth.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(178, 428);
            this.nudHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 20);
            this.nudHeight.TabIndex = 5;
            this.nudHeight.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(178, 454);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(120, 23);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "Изменить размер";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(304, 373);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(157, 23);
            this.btnMainMenu.TabIndex = 7;
            this.btnMainMenu.Text = "Назад";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 402);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(157, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить изображение";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 539);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.nudWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pbImage);
            this.Name = "FormImage";
            this.Text = "FormImage";
            this.Load += new System.EventHandler(this.FormImage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnSave;
    }
}