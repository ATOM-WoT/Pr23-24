namespace Практическая_23
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.HSBRed = new System.Windows.Forms.HScrollBar();
            this.HSBGreen = new System.Windows.Forms.HScrollBar();
            this.HSBBlue = new System.Windows.Forms.HScrollBar();
            this.NUDRed = new System.Windows.Forms.NumericUpDown();
            this.NUDGreen = new System.Windows.Forms.NumericUpDown();
            this.NUDBlue = new System.Windows.Forms.NumericUpDown();
            this.PBColors = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOtherColors = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUDRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(30, 29);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(52, 13);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "Красный";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(30, 95);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(52, 13);
            this.lblGreen.TabIndex = 1;
            this.lblGreen.Text = "Зеленый";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(30, 163);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(38, 13);
            this.lblBlue.TabIndex = 2;
            this.lblBlue.Text = "Синий";
            // 
            // HSBRed
            // 
            this.HSBRed.LargeChange = 1;
            this.HSBRed.Location = new System.Drawing.Point(110, 29);
            this.HSBRed.Maximum = 255;
            this.HSBRed.Name = "HSBRed";
            this.HSBRed.Size = new System.Drawing.Size(270, 17);
            this.HSBRed.TabIndex = 3;
            this.HSBRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBRed_Scroll);
            this.HSBRed.ValueChanged += new System.EventHandler(this.HSBRed_ValueChanged);
            // 
            // HSBGreen
            // 
            this.HSBGreen.LargeChange = 1;
            this.HSBGreen.Location = new System.Drawing.Point(110, 95);
            this.HSBGreen.Maximum = 255;
            this.HSBGreen.Name = "HSBGreen";
            this.HSBGreen.Size = new System.Drawing.Size(270, 17);
            this.HSBGreen.TabIndex = 4;
            this.HSBGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBGreen_Scroll);
            this.HSBGreen.ValueChanged += new System.EventHandler(this.HSBGreen_ValueChanged);
            // 
            // HSBBlue
            // 
            this.HSBBlue.LargeChange = 1;
            this.HSBBlue.Location = new System.Drawing.Point(110, 163);
            this.HSBBlue.Maximum = 255;
            this.HSBBlue.Name = "HSBBlue";
            this.HSBBlue.Size = new System.Drawing.Size(270, 17);
            this.HSBBlue.TabIndex = 5;
            this.HSBBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HSBBlue_Scroll);
            this.HSBBlue.ValueChanged += new System.EventHandler(this.HSBBlue_ValueChanged);
            // 
            // NUDRed
            // 
            this.NUDRed.Location = new System.Drawing.Point(412, 29);
            this.NUDRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDRed.Name = "NUDRed";
            this.NUDRed.Size = new System.Drawing.Size(39, 20);
            this.NUDRed.TabIndex = 6;
            this.NUDRed.ValueChanged += new System.EventHandler(this.NUDRed_ValueChanged);
            // 
            // NUDGreen
            // 
            this.NUDGreen.Location = new System.Drawing.Point(412, 95);
            this.NUDGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDGreen.Name = "NUDGreen";
            this.NUDGreen.Size = new System.Drawing.Size(39, 20);
            this.NUDGreen.TabIndex = 7;
            this.NUDGreen.ValueChanged += new System.EventHandler(this.NUDGreen_ValueChanged);
            // 
            // NUDBlue
            // 
            this.NUDBlue.Location = new System.Drawing.Point(412, 163);
            this.NUDBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NUDBlue.Name = "NUDBlue";
            this.NUDBlue.Size = new System.Drawing.Size(39, 20);
            this.NUDBlue.TabIndex = 8;
            this.NUDBlue.ValueChanged += new System.EventHandler(this.NUDBlue_ValueChanged);
            // 
            // PBColors
            // 
            this.PBColors.Location = new System.Drawing.Point(510, 29);
            this.PBColors.Name = "PBColors";
            this.PBColors.Size = new System.Drawing.Size(151, 138);
            this.PBColors.TabIndex = 9;
            this.PBColors.TabStop = false;
            this.PBColors.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(57, 224);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(71, 29);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "ОК";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(186, 224);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(71, 29);
            this.btnCancle.TabIndex = 11;
            this.btnCancle.Text = "Отмена";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOtherColors
            // 
            this.btnOtherColors.Location = new System.Drawing.Point(510, 224);
            this.btnOtherColors.Name = "btnOtherColors";
            this.btnOtherColors.Size = new System.Drawing.Size(90, 29);
            this.btnOtherColors.TabIndex = 12;
            this.btnOtherColors.Text = "Другие цвета";
            this.btnOtherColors.UseVisualStyleBackColor = true;
            this.btnOtherColors.Click += new System.EventHandler(this.btnOtherColors_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 286);
            this.Controls.Add(this.btnOtherColors);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.PBColors);
            this.Controls.Add(this.NUDBlue);
            this.Controls.Add(this.NUDGreen);
            this.Controls.Add(this.NUDRed);
            this.Controls.Add(this.HSBBlue);
            this.Controls.Add(this.HSBGreen);
            this.Controls.Add(this.HSBRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Палитра";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUDRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBColors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.HScrollBar HSBRed;
        private System.Windows.Forms.HScrollBar HSBGreen;
        private System.Windows.Forms.HScrollBar HSBBlue;
        private System.Windows.Forms.NumericUpDown NUDRed;
        private System.Windows.Forms.NumericUpDown NUDGreen;
        private System.Windows.Forms.NumericUpDown NUDBlue;
        private System.Windows.Forms.PictureBox PBColors;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOtherColors;
    }
}